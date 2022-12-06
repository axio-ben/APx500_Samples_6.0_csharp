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
//   * Connecting to the APx API.
//   * Opening a project file.
//   * Running a sequence.
//   * Retrieve measurement data at specific frequencies
//
//-------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace Read_Sweep_Values
{
	public partial class Form1 : Form
	{
		private readonly APx500 APx = new APx500();

		public Form1()
		{
			InitializeComponent();
            APx.Visible = true;
		}

		private void buttonSteppedFrequencySweep_Click(object sender, EventArgs e)
		{
			ReadSweepValues("Signal Path1", "Stepped Frequency Sweep", MeasurementResultType.LevelVsFrequency);

		}

		private void buttonFrequencyResponse_Click(object sender, EventArgs e)
		{
			ReadSweepValues("Signal Path1", "Frequency Response", MeasurementResultType.LevelVsFrequency);
		}

		private void ButtonOpenProject_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBoxProjectFile.Text = openFileDialog1.FileName;
				//Open the specified project file
				APx.OpenProject(textBoxProjectFile.Text);
			}
		}

		private void ReadSweepValues(string SignalPathName, string MeasurementName, MeasurementResultType ResultType)
		{
			try
			{
				ISignalPath SignalPath;
				SignalPath = APx.Sequence[SignalPathName];

				ISequenceMeasurement Measurement;
				Measurement = SignalPath[MeasurementName];

				//run the sweep
				Measurement.Run();

				//get the desired result
				ISequenceResult Result;
				Result = Measurement.SequenceResults[ResultType];

				//go through each channel and write out the values for 20Hz, 200Hz, 1000Hz, 2000Hz, 20000Hz
				for (int ch = 0; ch < Result.ChannelCount; ch++)
				{
					//get the values from the graph
				    double[] XValues = Result.GetXValues(ch);
				    double[] YValues = Result.GetYValues(ch);
					
					Console.WriteLine("Channel{0}", ch);

					//find the index of the x value closest to 20Hz
					int index = FindSweepPointIndex(XValues, 20);
					Console.WriteLine("20Hz, {0}, {1}", XValues[index], YValues[index]);

					//get the value closest to 200Hz
                    index = FindSweepPointIndex(XValues, 200);
                    Console.WriteLine("200Hz, {0}, {1}", XValues[index], YValues[index]);

					//get the value closest to 1000Hz
                    index = FindSweepPointIndex(XValues, 1000);
                    Console.WriteLine("1000Hz, {0}, {1}", XValues[index], YValues[index]);

					//get the value closest to 2000Hz
                    index = FindSweepPointIndex(XValues, 2000);
                    Console.WriteLine("2000Hz, {0}, {1}", XValues[index], YValues[index]);

					//get the value closest to 20000Hz
                    index = FindSweepPointIndex(XValues, 20000);
                    Console.WriteLine("20000Hz, {0}, {1}", XValues[index], YValues[index]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int FindSweepPointIndex(double[] xValues, double XValue)
		{
			//allow for a small tolerance in case measured value is slightly off from desired value
			XValue *= 1.001;

			int closestIndex = 0;
			double lastValue = Double.MinValue;

			//iterate through each value in the list until we find the closest match without
			//going over the desired value
			for (int i = 0; i < xValues.Length; i++)
			{
				if (xValues[i] > lastValue && xValues[i] <= XValue)
				{
					closestIndex = i;
					lastValue = xValues[i];
				}
				else
					break;
			}

			return closestIndex;
		}
	}
}