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
//   * Starting and connecting to the APx500 software.
//   * Loading a pre-made project file.
//   * Running a sequence of tests.
//   * Checking the pass/fail result of an entire test sequence.
//   * Exporting the measurement results of a test sequence to CSV and PDF file formats.
//   * Exporting the measurement results of a test sequence to a custom text format.
//   * Shutting down the APx500 software.
//
//-------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace Export_Sample
{
	public partial class Form1 : Form
	{
		private APx500 APx;

		public Form1()
		{
			InitializeComponent();

			APx = new APx500(); // Connect to the APx500 software.
			APx.Visible = true; // Show the APx500 software's window.
			this.Focus(); // Put this program's window on top of the others.
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			APx.Exit(); //Shutdown the APx500 software
			APx = null;

			base.OnFormClosed(e);
		}

		private void LoadProjectButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Load the sample project.
				APx.OpenProject(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sample APx500 Project.approjx");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RunTestButton_Click(object sender, EventArgs e)
		{
			// Run the enire test sequence.
			APx.Sequence.Run();

			// Check to see if all the tests passed and alert the user of the result.
			string resultMessage = "Failed";
			MessageBoxIcon resultIcon = MessageBoxIcon.Error;
			if (APx.Sequence.Passed)
			{
				resultMessage = "Passed";
				resultIcon = MessageBoxIcon.Information;
			}
			MessageBox.Show("Sequence " + resultMessage + "\r\n" + "See report for details.", "Sequence Results",
							MessageBoxButtons.OK, resultIcon);
		}

		private void ExportCsvButton_Click(object sender, EventArgs e)
		{
			string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Report.csv";

			// Export the sequence report as a Comma-Separated-Values (CSV) file.
			APx.Sequence.Report.ExportText(filename);

			MessageBox.Show("Report saved as: " + filename, "Saved Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ExportPdfButton_Click(object sender, EventArgs e)
		{
			string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Report.pdf";

			//Export the sequence report as an Adobe Portable Document Format (PDF) file.
			APx.Sequence.Report.ExportPdf(filename);

			MessageBox.Show("Report saved as: " + filename, "Saved Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ExportCustomTextButton_Click(object sender, EventArgs e)
		{
			string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Custom Report.txt";

			// Create (or overwrite) a text file for a custom sequence report format.
			using (StreamWriter sw = new StreamWriter(filename))
			{
				// Write a header into the report file.
				sw.WriteLine("Custom sequence report:");

				// Output each measurement result set.
				foreach (ISignalPath signalPath in APx.Sequence)
				{
					if (signalPath.Checked)
					{
						foreach (ISequenceMeasurement measurement in signalPath)
						{
							if (measurement.Checked)
							{
								foreach (ISequenceResult result in measurement.SequenceResults)
								{
									// Skip down a couple lines, and write out the current measurement's title.
									sw.WriteLine();
									sw.WriteLine();
									sw.WriteLine("Measurement: " + result.Name);

									// Indicate the primary pass/fail status of this measurement.
									sw.Write("Result: ");
									if (result.PassedLowerLimitCheck && result.PassedUpperLimitCheck)
										sw.WriteLine("passed");
									else
										sw.WriteLine("failed");

									if (result.HasMeterValues)
										WriteMeter(sw, result.Name, result.GetMeterValues());
									else if (result.HasXYValues)
										WriteGraph(sw, result);
									else if (result.HasRawTextResults)
										WriteTextValues(sw, result);
								}
							}
						}
					}
				}
			} // Close the custom report file.

			MessageBox.Show("Report saved as: " + filename, "Saved Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void WriteGraph(StreamWriter stream, ISequenceResult result)
		{
			// Skip down a line and indicate the start of new graph data.
			stream.WriteLine();
			// Include the name of the graph.
			stream.WriteLine("Graph: " + result.Name);

			for (int channel = 0; channel < result.ChannelCount; channel++)
			{
				// Write out the channel number.
				stream.Write("Ch" + channel + 1);

				double[] xValues = result.GetXValues(channel);
				double[] yValues = result.GetYValues(channel);

				// Write out a row for each measurement point in the data.
				// For each measurement point write out the x,y pairs for each channel.
				for (int measurementPoint = 0; measurementPoint < xValues.Length; measurementPoint++)
				{
					// Write out the "(x, y)" pair.
					stream.Write("(" + xValues[measurementPoint] + ", " + yValues[measurementPoint] + ") ");
				}

				//Start the next measurement point on the next line.
				stream.WriteLine();
			}
		}

		private void WriteMeter(StreamWriter stream, string meterName, double[] meterValues)
		{
			// Skip down a line and indicate the start of new meter readings.
			stream.WriteLine();
			// Include the name of the meters.
			stream.WriteLine("Meter: " + meterName);

			// Write each channel's meter reading on it's own line.
			for (int ch = 0; ch < meterValues.Length; ch++)
				stream.WriteLine("Channel " + ch + 1 + ": " + meterValues[ch]);
		}

		private void WriteTextValues(StreamWriter stream, ISequenceResult result)
		{
			// Skip down a line and indicate the start of new results.
			stream.WriteLine();
			// Include the name of the meters.
			stream.WriteLine("Text: " + result.Name);
			
			foreach(string rawResult in result.GetRawTextResults())
				stream.WriteLine(rawResult);
		}
	}
}