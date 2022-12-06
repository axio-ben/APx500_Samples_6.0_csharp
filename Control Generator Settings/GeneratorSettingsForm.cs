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
//   * Retrieve channel names.
//   * Enable / disable generator.
//-------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class GeneratorSettings : Form
	{
		public GeneratorSettings()
		{
			InitializeComponent();
		}

		// Declare the APx object
		public APx500 APx;

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			//// Use a Try..Catch block to handle any errors
			//try
			//{
			//	// Connect to APx500
			//	APx = new APx500();

			//	// Make the APx500 application window visible
			//	APx.Visible = true;

			//	// Open the project file included with this code example, located in the same directory as this .EXE
			//	APx.OpenProject(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\SampleProject.approjx");

			//	// Activate the Level and Gain measurement to access settings
			//	APx.ShowMeasurement("Signal Path1", "Level and Gain");
			//	// Get the generator frequency
			//	TextBoxLevelAndGainFrequency.Text = APx.LevelAndGain.Generator.Frequency.Value.ToString();
			//	// Get the generator level for the first generator channel
			//	TextBoxLevelAndGainLevel.Text = APx.LevelAndGain.Generator.Levels.GetText(OutputChannelIndex.Ch1);

			//	// Activate the Signal to Noise Ration measurement to access settings
			//	APx.ShowMeasurement("Signal Path1", "Signal to Noise Ratio");
			//	// Get the generator frequency
			//	TextBoxSnrFrequency.Text = APx.SignalToNoiseRatio.Generator.Frequency.Value.ToString();
			//	// Get the generator level for the first generator channel
			//	TextBoxSnrLevel.Text = APx.SignalToNoiseRatio.Generator.Levels.GetText(OutputChannelIndex.Ch1);

			//	// Activate the Frequency Response measurement
			//	APx.ShowMeasurement("Signal Path1", "Frequency Response");
			//	// Get the start frequency for the sweep
			//	TextBoxFrequencyResponseStartFrequency.Text = APx.FrequencyResponse.Generator.StartFrequency.Value.ToString();
			//	// Get the stop frequency for the sweep
			//	TextBoxFrequencyResponseStopFrequency.Text = APx.FrequencyResponse.Generator.StopFrequency.Value.ToString();
			//	// Get the generator level for the first generator channel
			//	TextBoxFrequencyResponseLevel.Text = APx.FrequencyResponse.Generator.Levels.GetText(OutputChannelIndex.Ch1);

			//	// Activate the Stepped Frequency Sweep measurement
			//	APx.ShowMeasurement("Signal Path1", "Stepped Frequency Sweep");
			//	// Get the start frequency for the sweep
			//	TextBoxSteppedFrequencySweepStartFrequency.Text = APx.SteppedFrequencySweep.Generator.StartFrequency.Value.ToString();
			//	// Get the stop frequency for the sweep
			//	TextBoxSteppedFrequencySweepStopFrequency.Text = APx.SteppedFrequencySweep.Generator.StopFrequency.Value.ToString();
			//	// Get the generator level for the first generator channel
			//	TextBoxSteppedFrequencySweepLevel.Text = APx.SteppedFrequencySweep.Generator.Levels.GetText(OutputChannelIndex.Ch1);
			//	// Get the number of sweep points
			//	NumericUpDownSteeppedFrequencySwepPoints.Value = APx.SteppedFrequencySweep.Generator.SweepParameters.NumberOfPoints;
			//}
			//catch (Exception ex)
			//{
			//	// Display an error message
			//	MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void ButtonLevelAndGain1_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Level and Gain measurement
				APx.ShowMeasurement("Signal Path1", "Level and Gain");
				// Set the generator frequency
				APx.LevelAndGain.Generator.Frequency.Value = double.Parse(TextBoxLevelAndGainFrequency.Text);
				// Set the generator level
				APx.LevelAndGain.Generator.Levels.SetValue(OutputChannelIndex.Ch1, TextBoxLevelAndGainLevel.Text);
				// Turn the generator on
				APx.LevelAndGain.Generator.On = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSnr1_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Signal to Noise Ratio measurement
				APx.ShowMeasurement("Signal Path1", "Signal to Noise Ratio");
				// Set the generator frequency
				APx.SignalToNoiseRatio.Generator.Frequency.Value = double.Parse(TextBoxSnrFrequency.Text);
				// Set the generator level
				APx.SignalToNoiseRatio.Generator.Levels.SetValue(OutputChannelIndex.Ch1, TextBoxSnrLevel.Text);
				// Run the measurement
				APx.SignalToNoiseRatio.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonFrequencyResponse1_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Frequency Response measurement
				APx.ShowMeasurement("Signal Path1", "Frequency Response");
				// Set the start frequency
				APx.FrequencyResponse.Generator.StartFrequency.Value = double.Parse(TextBoxFrequencyResponseStartFrequency.Text);
				// Set the stop frequency
				APx.FrequencyResponse.Generator.StopFrequency.Value = double.Parse(TextBoxFrequencyResponseStopFrequency.Text);
				// Set the generator level
				APx.FrequencyResponse.Generator.Levels.SetValue(OutputChannelIndex.Ch1, TextBoxFrequencyResponseLevel.Text);
				// Run the measurement
				APx.FrequencyResponse.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSteppedFrequency1_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Stepped Frequency Sweep measurement
				APx.ShowMeasurement("Signal Path1", "Stepped Frequency Sweep");
				// Set the start frequency
				APx.SteppedFrequencySweep.Generator.StartFrequency.Value = double.Parse(TextBoxSteppedFrequencySweepStartFrequency.Text);
				// Set the stop frequency
				APx.SteppedFrequencySweep.Generator.StopFrequency.Value = double.Parse(TextBoxSteppedFrequencySweepStopFrequency.Text);
				// Set the number of sweep points
				APx.SteppedFrequencySweep.Generator.SweepParameters.NumberOfPoints = (int)NumericUpDownSteeppedFrequencySwepPoints.Value;
				// Set the generator level
				APx.SteppedFrequencySweep.Generator.Levels.SetValue(OutputChannelIndex.Ch1, TextBoxSteppedFrequencySweepLevel.Text);
				// Run the measurement
				APx.SteppedFrequencySweep.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}