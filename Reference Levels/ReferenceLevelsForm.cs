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
//   * Connecting to the APx API
//   * Opening a project file
//   * Setting and reading reference levels
//   * Control the generator level and read updated level measurement values
//
//-------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class Form1 : Form
	{
		public Form1()
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

				// Read the dBrG text value 
                TextBoxdBrGValue.Text = APx.SignalPathSetup.References.AnalogOutputReferences.dBrG.Value.ToString();

				// Read the dBrA text value 
                TextBoxdBrAValue.Text = APx.SignalPathSetup.References.AnalogInputReferences.dBrA.Value.ToString();

				// Read the dBrB text value 
                TextBoxdBrBValue.Text = APx.SignalPathSetup.References.AnalogInputReferences.dBrB.Value.ToString();
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrGValue_Click(object sender, EventArgs e)
		{
			try
			{
				// Set the dBrG value to the user entered text value
                APx.SignalPathSetup.References.AnalogOutputReferences.dBrG.Value = double.Parse(TextBoxdBrGValue.Text);
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrGToGeneratorValue_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Level and Gain Measurement
				APx.ShowMeasurement("Signal Path1", "Level and Gain");

				double generatorLevel = APx.LevelAndGain.Generator.Levels.GetValue(OutputChannelIndex.Ch1);

				// Set the dBrG value to the first generator channel value
                APx.SignalPathSetup.References.AnalogOutputReferences.dBrG.Value = generatorLevel;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrA_Click(object sender, EventArgs e)
		{
			try
			{
				// Set the dBrA value to the user entered text value
                APx.SignalPathSetup.References.AnalogInputReferences.dBrA.Value = double.Parse(TextBoxdBrAValue.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrAToMeterValue_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Level and Gain measurement
				APx.ShowMeasurement("Signal Path1", "Level and Gain");

				// Turn the generator on
				APx.LevelAndGain.Generator.On = true;

				//wait for the DUT to respond
				System.Threading.Thread.Sleep(500);

				// Get the Rms Level meter values. These values are not settled.
				double[] rmsLevels;
				rmsLevels = APx.LevelAndGain.Level.GetValues();

				// Set the dBrA value to the meter value for channel 1
                APx.SignalPathSetup.References.AnalogInputReferences.dBrA.Value = rmsLevels[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrB_Click(object sender, EventArgs e)
		{
			try
			{
				// Set the dBrB value to the user entered text value
                APx.SignalPathSetup.References.AnalogInputReferences.dBrB.Value = double.Parse(TextBoxdBrBValue.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonSetdBrBToMeterValue_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate the Level and Gain Measurement
				APx.ShowMeasurement("Signal Path1", "Level and Gain");

				// Turn the generator on
				APx.LevelAndGain.Generator.On = true;

				//wait for the DUT to respond
				System.Threading.Thread.Sleep(500);

				// Get the Rms Level meter values. These values are not settled.
				double[] rmsLevels;
				rmsLevels = APx.LevelAndGain.Level.GetValues();

				// Set the dBrA value to the meter value for channel 1
                APx.SignalPathSetup.References.AnalogInputReferences.dBrB.Value = rmsLevels[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonGetdBrValues_Click(object sender, EventArgs e)
		{
			// Read the dBrA text value which is formatted with units and display it on the screen
            LabeldBrA.Text = APx.SignalPathSetup.References.AnalogInputReferences.dBrA.Text;

			// Read the dBrA raw value as a number
			double dBrA = APx.SignalPathSetup.References.AnalogInputReferences.dBrA.Value;

			// Read the dBrB text value which is formatted with units and display it on the screen
            LabeldBrB.Text = APx.SignalPathSetup.References.AnalogInputReferences.dBrB.Text;

			// Read the dBrB raw value as a number
			double dBrB = APx.SignalPathSetup.References.AnalogInputReferences.dBrB.Value;
		}
	}
}