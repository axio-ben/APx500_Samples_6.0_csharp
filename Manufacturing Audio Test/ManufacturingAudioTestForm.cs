//-------------------------------------------------------------------------------------
// -- C# .NET 2.0 Sample ---
//
// Created by Audio Precision
// Copyright 2006 - 2013 by Audio Precision, All rights reserved.
// For use by owners and users of Audio Precision measurement systems.
//
// Audio Precision, PO Box 2209, Beaverton, OR  97075-2209    USA
// 503-627-0832, US toll free 1-800 231-7350   FAX 503 641-8906
// www.ap.com    techsupport@audioprecision.com
//
// Description: This sample program demonstrates the following scenario:
//   * An example of a production test application which runs measurements and writes 
//     measurement results out to a text file.
//
//-------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class ManufacturingAudioTestForm : Form
	{
		private APx500 APx;
		private IMeterGraph CurrentMeter;
		private DateTime TestTime;

		private double[] CurrentMeterValues;
		private double[] CurrentLowerLimit;
		private double[] CurrentUpperLimit;
		private string CurrentUnit;

		private const string PASS = "Pass";
		private const string FAIL = "Fail";

		public ManufacturingAudioTestForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			//try
			//{
			//	APx = new APx500();
			//	APx.Visible = false;
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message, "Error loading APx", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	Close();
			//}
			BringToFront();
			Application.DoEvents();
		}

		//This class represents a measurement and signal path
		//These are items in a drop-down box which allows the user to jump to a specific measurement
		private class JumpItem
		{
			public readonly string Measurement;
			public readonly string SignalPath;
			public JumpItem(string signalPathName, string measurementName)
			{
				this.Measurement = measurementName;
				this.SignalPath = signalPathName;
			}

			//make the text in the drop down box appear as "SignalPathName.MeasurementName"
			public override string ToString()
			{
				return SignalPath + "." + Measurement;
			}
		}

		private void ButtonOpenFile_Click(object sender, EventArgs e)
		{
			if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Cursor = Cursors.WaitCursor;
					ComboBoxJump.Items.Clear();

					//open the project file
					APx.OpenProject(OpenFileDialog1.FileName);

					//update the display to reflect information from the project file
					LabelTestFileName.Text = Path.GetFileName(OpenFileDialog1.FileName);
					LabelTestFileDate.Text = File.GetLastWriteTime(OpenFileDialog1.FileName).ToString();
					LabelModelNameValue.Text = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName);

					TextBoxSerialNumber.Text = "";

					//count all of the checked signal paths and measurements in the sequence in the project file
					int total = 0;
					foreach (ISignalPath signalPath in APx.Sequence)
					{
						if(signalPath.Checked)
						{
							foreach (ISequenceMeasurement measurement in signalPath)
							{
								//count every checked measurement
								if(measurement.Checked)
								{
									total++;
									ComboBoxJump.Items.Add(new JumpItem(signalPath.Name, measurement.Name));
								}
							}
						}
					}

					Application.DoEvents();

					//select the first item in the jump to list
					if(ComboBoxJump.Items.Count > 0)
					{
						ComboBoxJump.SelectedIndex = 0;
						JumpItem item = (JumpItem) ComboBoxJump.Items[0];
						SelectMeasurement(item.SignalPath, item.Measurement);
					}
					LabelStepNumber.Text = "1";
					LabelStepCount.Text = total.ToString();
				}
				catch (Exception ex)
				{
					//an error occurred while loading the project, so reset the user interface
					ComboBoxJump.Items.Clear();
					LabelTestFile.Text = "";
					LabelTestFileDate.Text = "";
					LabelStepNumber.Text = "";
					LabelStepCount.Text = "";
					MessageBox.Show(ex.Message, "Error Loading Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					//cause the screen to repaint
					Invalidate();
					Application.DoEvents();
					Cursor = Cursors.Default;
				}
			}
		}

		private void SelectMeasurement(string SignalPath, string Measurement)
		{
			//a new measurement has been selected from the drop-list.  Update the text fields in the user
			//interface and extract the prompts from the sequence and display them in the instruction box
			StringBuilder instructions = new StringBuilder();
			foreach (IPromptStep prompt in APx.Sequence[SignalPath][Measurement].SequenceSteps.PromptSteps)
			{
				//extract a prompt and append it to the instructions
				if (instructions.Length > 0)
					instructions.AppendLine();
				instructions.Append(prompt.Text);
				//place the text into the instruction box
				RichTextBoxInstructions.Text = instructions.ToString();
			}

			LabelTestValue.Text = Measurement;
			Application.DoEvents();
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			//record the test time so we can use it later for writing out the data files
			TestTime = DateTime.Now;
			RunMeasurement();
		}

		private void RunMeasurement()
		{
			//make sure there is a measurement selected
			if (ComboBoxJump.Items.Count == 0)
				return;

			Application.DoEvents();

			//unsubscribe from old events so the grid stops updating
			if (CurrentMeter != null)
				UnsubscribeFromMeterEvents(CurrentMeter);

			//clear the previous meter data, if(any
			CurrentMeter = null;
			CurrentMeterValues = null;
			CurrentUpperLimit = null;
			CurrentLowerLimit = null;
			CurrentUnit = null;

			JumpItem item = (JumpItem)ComboBoxJump.Items[ComboBoxJump.SelectedIndex];

			//get the signal path and measurement names from the drop-list
			ISignalPath signalPath = APx.Sequence[item.SignalPath];
			ISequenceMeasurement measurement = signalPath[item.Measurement];

			//clear the contents of the grid
			ListViewResults.Items.Clear();

			LabelStepNumber.Text = (ComboBoxJump.SelectedIndex + 1).ToString();

			//make sure the new measurement is selected and its instructions are displayed
			SelectMeasurement(item.SignalPath, item.Measurement);

			//get the output and input connector which are used in the grid
			string outputConnectorName = APx.SignalPathSetup.OutputConnector.Name;
			string inputConnectorName = APx.SignalPathSetup.InputConnector.Name;

			//make the measurement active
			APx.ShowMeasurement(signalPath.Name, measurement.Name);

			//Figure out which type of measurement the user has selected.
			//if(it is a measurement which displays continuously updating meter values
			//then we need to select the first checked meter graph and display its meter
			//values in the grid
			switch (measurement.MeasurementType)
			{
				case MeasurementType.DCLevel:
					CurrentMeter = APx.DCLevel.DCLevel;
					break;
	
				case MeasurementType.Imd:
					APx.Imd.Generator.On = true;
					if (APx.Imd.ImdRatio.Checked)
						CurrentMeter = APx.Imd.ImdRatio;
					break;

				case MeasurementType.Frequency:
					APx.Frequency.Generator.On = true;
					CurrentMeter = APx.Frequency.Frequency;
					break;

				case MeasurementType.InterchannelPhase:
					APx.InterchannelPhase.Generator.On = true;
					CurrentMeter = APx.InterchannelPhase.Phase;
					break;

				case MeasurementType.LevelAndGain:
					//turn generator on
					APx.LevelAndGain.Generator.On = true;

					if (APx.LevelAndGain.Level.Checked)
						CurrentMeter = APx.LevelAndGain.Level;
					else if (APx.LevelAndGain.Gain.Checked)
						CurrentMeter = APx.LevelAndGain.Gain;
					break;

				case MeasurementType.Noise:
					CurrentMeter = APx.Noise.Level;
					break;
	
				case MeasurementType.SignalPathSetup:
                    APx.SignalPathSetup.Generator.On = true;

                    if (APx.SignalPathSetup.Level.Checked)
                        CurrentMeter = APx.SignalPathSetup.Level;
                    else if (APx.SignalPathSetup.ThdNRatio.Checked)
                        CurrentMeter = APx.SignalPathSetup.ThdNRatio;
					break;

				case MeasurementType.ThdN:
					APx.ThdN.Generator.On = true;

					if (APx.ThdN.ThdNRatio.Checked)
						CurrentMeter = APx.ThdN.ThdNRatio;
					else if (APx.ThdN.ThdNLevel.Checked)
						CurrentMeter = APx.ThdN.ThdNLevel;
					break;
	
				case MeasurementType.BandpassLevel:
					APx.BandpassLevel.Generator.On = true;
					if (APx.BandpassLevel.Level.Checked)
						CurrentMeter = APx.BandpassLevel.Level;
					break;
				
				default:
					//Was a continuously updating meter type, so it must be a "batch" measurement, or a measurement that runs to completion
					//and) displays static results
					if (MessageBox.Show(
							"Follow the instructions to prepare the DUT for testing. When ready, press OK to take the measurement.",
							"Run Batch Measurement", MessageBoxButtons.OKCancel) == DialogResult.OK)
					{
						try
						{
							//run the measuremement
							measurement.Run();

							//if(the measurement ran successfully
							if (measurement.HasSequenceResults)
								//populate the grid with the first checked result
								PopulateBatchResult(measurement.SequenceResults[0], outputConnectorName, inputConnectorName);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					break;
			}

			//if(the user selected a continously updating meter above, show its values in the grid
			if (CurrentMeter != null)
			{
				PopulateList(CurrentMeter, outputConnectorName, inputConnectorName);
				//listen for updates from APx. 
				SubscribeToMeterEvents(CurrentMeter);
			}

			Application.DoEvents();
		}

		private void SubscribeToMeterEvents(IMeterGraph meter)
		{
			//Listen to events from APx
			meter.ValuesChanged += APEvents.AddMeterValuesHandler(MeterValueChanged);
		}

		private void UnsubscribeFromMeterEvents(IMeterGraph meter)
		{
			//Stop listening to events
			meter.ValuesChanged -= APEvents.RemoveMeterValuesHandler(MeterValueChanged);
		}

		//Fills the grid with meter data for continuously updating meter graphs
		private void PopulateList(IMeterGraph meter, string outputConnectorName, string inputConnectorName)
		{
			double[] meterValues = meter.GetValues();
			string[] meterValuesText = meter.GetText();

			double[] lowerLimit = meter.Limits.Lower.GetValues();
			string[] lowerLimitText = meter.Limits.Lower.GetText();

			double[] upperLimit = meter.Limits.Upper.GetValues();
			string[] upperLimitText = meter.Limits.Upper.GetText();

			PopulateMeterValues(meterValues, meter.Axis.Unit, meterValuesText, lowerLimit, lowerLimitText, upperLimit, upperLimitText, outputConnectorName, inputConnectorName);
		}

		//Fills the grid with meter data
		private void PopulateMeterValues(double[] meterValues, string unit, string[] meterValuesText, double[] lowerLimit, string[] lowerLimitText, double[] upperLimit, string[] upperLimitText, string outputConnectorName, string inputConnectorName)
		{
			//store the current values for use later in the Export function
			CurrentMeterValues = meterValues;
			CurrentUpperLimit = upperLimit;
			CurrentLowerLimit = lowerLimit;
			CurrentUnit = unit;

			bool allPassed = true;
			for (int i = 0; i < meterValues.Length; i++)
			{
				//create a new item to add to the grid
				ListViewItem lvi = new ListViewItem(outputConnectorName);
				lvi.UseItemStyleForSubItems = false;

				Color backColor;
				//alternating row colors
				if (i % 2 != 0)
					backColor = SystemColors.Info;
				else
					backColor = SystemColors.Window;

				//add the fields
				lvi.SubItems.Add(inputConnectorName);
				lvi.SubItems.Add(lowerLimitText[i]);
				lvi.SubItems.Add("<=");
				lvi.SubItems.Add(meterValuesText[i]);
				lvi.SubItems.Add("<=");
				lvi.SubItems.Add(upperLimitText[i]);

				//check to see if(the meter value passed limit checks
				if (PassedLimitCheck(meterValues[i], lowerLimit[i], upperLimit[i]))
				{
					//Passed, so put in "Pass" text and make the field green
					lvi.SubItems.Add(PASS);
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkGreen;
				}
				else
				{
					//Failed, so put in "Fail" text and make the field red
					lvi.SubItems.Add(FAIL);
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkRed;
					allPassed = false;
				}

				foreach (ListViewItem.ListViewSubItem subItem in lvi.SubItems)
				{
					subItem.BackColor = backColor;
				}

				//add the item to the grid
				ListViewResults.Items.Add(lvi);
			}

			if (allPassed)
			{
				//if(all channels passed,) update the overall pass/fail status to pass
				LabelPassFailValue.Text = PASS;
				LabelPassFailValue.ForeColor = Color.White;
				LabelPassFailValue.BackColor = Color.DarkGreen;
			}
			else
			{
				//otherwise, at least one channel failed, so update the overall status to fail
				LabelPassFailValue.Text = FAIL;
				LabelPassFailValue.ForeColor = Color.White;
				LabelPassFailValue.BackColor = Color.DarkRed;
			}

			Application.DoEvents();
		}

		//Fill the grid with values produced from a batch measurement
		private void PopulateBatchResult(ISequenceResult result, string outputConnectorName, string inputConnectorName)
		{
			if (result.HasMeterValues)
			{
				//if(the measurement produced meter values, display the meter values in the grid
				PopulateMeterValues(result.GetMeterValues(), result.MeterUnit, result.GetMeterText(),
				                    result.GetMeterLowerLimitValues(), result.GetMeterLowerLimitText(),
				                    result.GetMeterUpperLimitValues(), result.GetMeterUpperLimitText(), outputConnectorName,
				                    inputConnectorName);
			}
			else
			{
				//otherwise, the measurement produced an X,Y graph, or an X,Y graph was checked
				//in this case, just add one row that indicates whether or !the graph passed limit checks
				ListViewItem lvi = new ListViewItem(outputConnectorName);
				lvi.UseItemStyleForSubItems = false;

				lvi.SubItems.Add(inputConnectorName);
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("X,Y Graph Result");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				if (result.PassedLowerLimitCheck && result.PassedUpperLimitCheck && !result.HasErrorMessage)
				{
					lvi.SubItems.Add(PASS);
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkGreen;

					LabelPassFailValue.Text = PASS;
					LabelPassFailValue.ForeColor = Color.White;
					LabelPassFailValue.BackColor = Color.DarkGreen;
				}
				else
				{
					lvi.SubItems.Add(FAIL);
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkRed;

					LabelPassFailValue.Text = FAIL;
					LabelPassFailValue.ForeColor = Color.White;
					LabelPassFailValue.BackColor = Color.DarkRed;
				}

				ListViewResults.Items.Add(lvi);
				Application.DoEvents();
			}
		}

		private void MeterValueChanged(object sender, MeterValuesChangedEventArgs e)
		{
			//APx fired an event indicating new meter values are available
			//Update the grid with the latest meter values
			UpdateValues(e.Values);
		}

		//Check to see if(a meter value passes limit checks
		private static bool PassedLimitCheck(double meterValue, double lowerLimitValue, double upperLimitvalue)
		{
			bool Passed = true;

			//When a limit value is undefined, it has a value of Double.NaN
			//Check to make sure the limit value is !Double.NaN, and) check to see that the
			//meter value complies with the limit
			if (!double.IsNaN(lowerLimitValue) && meterValue < lowerLimitValue)
				Passed = false;

			//When a limit value is undefined, it has a value of Double.NaN
			//Check to make sure the limit value is !Double.NaN, and) check to see that the
			//meter value complies with the limit
			if (!double.IsNaN(upperLimitvalue) && meterValue > upperLimitvalue)
				Passed = false;

			return Passed;
		}

		private void UpdateValues(IMeterValues values)
		{
			CurrentMeterValues = values.GetValues(values.Unit);
			CurrentLowerLimit = values.LowerLimitValues;
			CurrentUpperLimit = values.UpperLimitValues;

			bool allPassed = true;
			//update the grid values
			for (int i = 0; i < values.Count; i++)
			{
				ListViewItem lvi = ListViewResults.Items[i];
				lvi.SubItems[4].Text = values.Text[i];

				//See if(the value passed limit checks
				if (PassedLimitCheck(values[i], values.LowerLimitValues[i], values.UpperLimitValues[i]))
				{
					lvi.SubItems[7].Text = PASS;
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkGreen;
				}
				else
				{
					lvi.SubItems[7].Text = FAIL;
					lvi.SubItems[7].ForeColor = Color.White;
					lvi.SubItems[7].BackColor = Color.DarkRed;
					allPassed = false;
				}
			}

			//update the overall pass/fail indicator
			if (allPassed)
			{
				LabelPassFailValue.Text = PASS;
				LabelPassFailValue.ForeColor = Color.White;
				LabelPassFailValue.BackColor = Color.DarkGreen;
			}
			else
			{
				LabelPassFailValue.Text = FAIL;
				LabelPassFailValue.ForeColor = Color.White;
				LabelPassFailValue.BackColor = Color.DarkRed;
			}
		}

		//Event handler for the Next button on the user interface
		private void ButtonNext_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			//unsubscribe from old events so the grid stops updating
			if (CurrentMeter != null)
				UnsubscribeFromMeterEvents(CurrentMeter);

			//export the data to a CSV text file
			ExportMeasurementResults();

			CurrentMeter = null;
			CurrentMeterValues = null;
			CurrentUpperLimit = null;
			CurrentLowerLimit = null;
			CurrentUnit = null;

			bool tryRunNextMeasurement = false;
			//When the user presses next, check to see if(the limits failed.  if(failed, offer the user the ability to try { {again.
			if (LabelPassFailValue.Text == FAIL)
			{
				DialogResult result;
				result = MessageBox.Show(
						"The measurement did not pass the limit checks.  Press Retry to make the measurement again, or press Ignore to continue to the next measurement.",
						"Failed Limits", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
				if (result == DialogResult.Abort)
				{
					//User choose to cancel the measurement
					ButtonStop.PerformClick();
				}
				else if (result == DialogResult.Retry)
				{
					//User chose to try { {again
					RunMeasurement();
				}
				else
				{
					//otherwise, user chose to ignore the failure and move to the next measurement
					tryRunNextMeasurement = true;
				}
			}
			else
			{
				//measurement passed limits
				tryRunNextMeasurement = true;
			}

			if (tryRunNextMeasurement)
			{
				//if(this is !the last measurement, go to the next one
				if (ComboBoxJump.SelectedIndex < ComboBoxJump.Items.Count - 1)
				{
					//move to the next measurement
					ComboBoxJump.SelectedIndex = ComboBoxJump.SelectedIndex + 1;
					//run the next measurement
					RunMeasurement();
				}
				else
				{
					//it was the last measurement, so stop
					ButtonStop.PerformClick();
					ShowSummaryReport();
				}
			}

			Cursor = Cursors.Default;
		}

		//Write the current results out to a CSV text file
		private void ExportMeasurementResults()
    {
    	if (CurrentMeterValues != null)
    	{
    		//Get the directory to create the text file
    		//The directory will be the same as this program//s .EXE 
    		string dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";

    		DateTime reportTime = DateTime.Now;
    		//The file name automatically includes the current date/time
    		string dateTimeString = reportTime.ToString("MM_dd_yyyy_HH_mm_");

    		//write out single measurement result
    		string fileName = dir + LabelModelNameValue.Text + "_" + TextBoxSerialNumber.Text + "_" + LabelTestValue.Text +
    		                  "_" + LabelStepNumber.Text + "_" + dateTimeString + ".csv";

    		//create a text file
    		using (StreamWriter sw = new StreamWriter(fileName))
    		{
    			sw.AutoFlush = true;
    			sw.WriteLine("Test Number,{0}", LabelStepNumber.Text);
    			sw.WriteLine("Test Name,{0}", LabelTestValue.Text);
    			sw.WriteLine("Time of Test,{0}", reportTime);
    			sw.WriteLine("DUT Input,{0}", APx.SignalPathSetup.OutputConnector.Name);
    			sw.WriteLine("DUT Output,{0}", APx.SignalPathSetup.InputConnector.Name);
    			sw.WriteLine("Pass/Fail,{0}", LabelPassFailValue.Text);

    			sw.WriteLine("Value, Unit,Pass/Fail");

    			//write out each pass/fail status to the file
    			for (int i = 0; i < CurrentMeterValues.Length; i++)
    			{
    				string PassFail;
    				if (PassedLimitCheck(CurrentMeterValues[i], CurrentLowerLimit[i], CurrentUpperLimit[i]))
    					PassFail = PASS;
    				else
    					PassFail = FAIL;

					if(double.IsNaN(CurrentMeterValues[i]))
						sw.WriteLine(",{0},{1}", CurrentUnit, PassFail);
					else
						sw.WriteLine("{0},{1},{2}", CurrentMeterValues[i], CurrentUnit, PassFail);
    			}
    		}

    		//Append to overall report
    		dateTimeString = TestTime.ToString("MM_dd_yyyy_HH_mm_");
    		fileName = dir + LabelModelNameValue.Text + "_" + TextBoxSerialNumber.Text + "_" + dateTimeString + ".csv";
    		bool appending = false;
    		if (File.Exists(fileName))
    			appending = true;


    		using (StreamWriter report = new StreamWriter(fileName, true))
    		{
    			report.AutoFlush = true;

    			if (!appending)
    			{
    				//write out a header
    				report.WriteLine("File Name,{0}", LabelTestFileName.Text);
    				report.WriteLine("Model Name,{0}", LabelModelNameValue.Text);
    				report.WriteLine("Serial Number,{0}", TextBoxSerialNumber.Text);
    				report.WriteLine("Time of Test,{0}", TestTime);

    				report.Write("Test Number,Test Name");
    				for (int i = 0; i < 7; i++)
    					report.Write(",Ch{0}", i + 1);
					report.WriteLine(", Unit,Pass/Fail");
				}

    			report.Write("{0},{1}", LabelStepNumber.Text, LabelTestValue.Text);
				for (int i = 0; i < CurrentMeterValues.Length - 1; i++)
				{
					if(double.IsNaN(CurrentMeterValues[i]))
						report.Write(",");
					else 
						report.Write(",{0}", CurrentMeterValues[i]);
				}

    			report.WriteLine(",{0},{1}", CurrentUnit, LabelPassFailValue.Text);
    		}
    	}
    }

		//when the user reaches the end of the sequence, launch the CSV text file so it can be displayed by Excel
		private void ShowSummaryReport()
		{
			string dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";
			string dateTimeString = TestTime.ToString("MM_dd_yyyy_HH_mm_");
			string fileName = dir + LabelModelNameValue.Text + "_" + TextBoxSerialNumber.Text + "_" + dateTimeString + ".csv";
			if (File.Exists(fileName))
			{
				//launch the file
				ProcessStartInfo pInfo = new ProcessStartInfo(fileName);
				pInfo.WorkingDirectory = dir;
				Process.Start(pInfo);
			}
		}

		//event handler for the Stop button
		private void ButtonStop_Click(object sender, EventArgs e)
		{
			//clear out any cached data regarding the previous measurement
			ClearOldMeasurement();

			//reset the jump to drop-list to the beginning
			if (ComboBoxJump.Items.Count > 0)
			{
				LabelStepNumber.Text = "1";
				ComboBoxJump.SelectedIndex = 0;
			}

			Application.DoEvents();
		}

	    public delegate void UnsubscribeMeterDelegate(IMeterGraph meter);

		private void ClearOldMeasurement()
		{
			//unsubscribe from old events so the grid stops updating
			if (CurrentMeter != null)
				BeginInvoke(new UnsubscribeMeterDelegate(UnsubscribeFromMeterEvents), CurrentMeter);

			CurrentMeter = null;
			CurrentMeterValues = null;
			CurrentUpperLimit = null;
			CurrentLowerLimit = null;
			CurrentUnit = null;

			ListViewResults.Items.Clear();
			LabelPassFailValue.Text = "";
			LabelPassFailValue.BackColor = SystemColors.ControlDark;
			LabelPassFailValue.ForeColor = SystemColors.WindowText;
		}

		//Event handler for the Jump button
		private void ButtonJump_Click(object sender, EventArgs e)
		{
			//clear out any cached data regarding the previous measurement
			ClearOldMeasurement();

			//if(there is anything in the drop-list,) show it
			if (ComboBoxJump.Items.Count > 0)
			{
				JumpItem item = (JumpItem)ComboBoxJump.SelectedItem;
				LabelStepNumber.Text = (ComboBoxJump.SelectedIndex + 1).ToString();
				//activate the measurement specified in the list in APx
				APx.ShowMeasurement(item.SignalPath, item.Measurement);
				//update the user interface to reflect the new selection
				SelectMeasurement(item.SignalPath, item.Measurement);
			}
		}

		//event handler for this user interface window closing
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			//unsubscribe from old events so the grid stops updating
			if (CurrentMeter != null)
				UnsubscribeFromMeterEvents(CurrentMeter);

			CurrentMeter = null;
			CurrentMeterValues = null;
			CurrentUpperLimit = null;
			CurrentLowerLimit = null;
			CurrentUnit = null;

			//close APx
			if (APx != null)
				APx.Exit();
		}
	}
}
