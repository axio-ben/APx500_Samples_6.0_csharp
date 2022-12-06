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
//   * Opening a project file.
//   * Display meter readings in an on screen grid.
//-------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class DisplayMeterResults : Form
	{
		public DisplayMeterResults()
		{
			InitializeComponent();
		}

		// Declare the APx object
		public APx500 APx;

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Use a Try..Catch block to handle any errors
			try
			{
				// Connect to APx500
				APx = new APx500();

				// Make the APx500 application window visible
				APx.Visible = true;

				// Open the project file included with this code example, located in the same directory as this .EXE
				APx.OpenProject(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\SampleProject.approjx");
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			ComboBox1.SelectedIndex = 0;
		}

		private void Button1_Click(object sender, EventArgs e)
		{

			// Clear any old data from the grid
			DataGridView1.Rows.Clear();

			try
			{
				if (ComboBox1.Text == "RMS Level")
				{
					// User chose Level and Gain, Rms Level, so show the Level and Gain measurement
					APx.ShowMeasurement("Signal Path1", "Level and Gain");

					// Run the measurement and get settled readings
					// Since this measurement normally updates continuously, you need to run it from the APx.Sequence object
					// to obtain settled readings.
					APx.Sequence["Signal Path1"]["Level and Gain"].Run();

					// Check the HasSequenceResults property to ensure settled readings were acquired
					if (APx.Sequence["Signal Path1"]["Level and Gain"].HasSequenceResults)
					{
						// get the object which represents the Rms Level meter values
						ISequenceResult result;
						result = APx.Sequence["Signal Path1"]["Level and Gain"].SequenceResults[MeasurementResultType.LevelMeter];

						// get the meter readings
						double[] meterValues = result.GetMeterValues();
						for (int i = 0; i < meterValues.Length; i++)
						{
							// add the meter readings to the grid
							DataGridView1.Rows.Add(string.Format("Ch{0}", i + 1), meterValues[i]);
						}
					}
				}
				else
				{
					// User chose Signal to Noise Ratio, so show the Signal to Noise Ratio measurement
					APx.ShowMeasurement("Signal Path1", "Signal to Noise Ratio");

					// Run the Signal to Noise Ratio measurement and get settled readings.
					// This measurement always produces settled readings, so you can call Start() on it directly
					// Alternatively, you could also call APx.Sequence.Item("Signal Path1").Item("Signal to Noise Ratio").Run()
					APx.SignalToNoiseRatio.Start();

					// Get the meter readings
					double[] meterValues;
					meterValues = APx.SignalToNoiseRatio.SignalToNoiseRatio.GetValues();
					for (int i = 0; i < meterValues.Length; i++)
					{
						// add the meter readings to the grid
						DataGridView1.Rows.Add(string.Format("Ch{0}", i + 1), meterValues[i]);
					}
				}
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
} 
