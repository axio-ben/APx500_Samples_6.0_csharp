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
//   * Configuring input and output switchers.
//-------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class ConfigureSwitchersForm : Form 
	{
		public ConfigureSwitchersForm()
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

				// Activate Signal Path Setup
				APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

				// Load the combo box for Channel A with all possible values for the Channel A selection
				foreach (SwitcherChannelSelection switcherChannel in Enum.GetValues(typeof(SwitcherChannelSelection)))
				{
					ComboBoxOutputChannelA.Items.Add(switcherChannel);
				}
				ComboBoxOutputChannelA.SelectedIndex = 0;

				// Load the combo box for Channel B with all possible values for the Channel B selection
				foreach (OutputSwitcherChannelBSelection switcherChannel in Enum.GetValues(typeof(OutputSwitcherChannelBSelection)))
				{
					ComboBoxOutputChannelB.Items.Add(switcherChannel);
				}
				ComboBoxOutputChannelB.SelectedIndex = 0;

				// Load the combo box for Channel A with all possible values for the Channel A selection
				foreach (SwitcherChannelSelection switcherChannel in Enum.GetValues(typeof(SwitcherChannelSelection)))
				{
					ComboBoxInputChannelA.Items.Add(switcherChannel);
				}
				ComboBoxInputChannelA.SelectedIndex = 0;

				// Load the combo box for Channel B with all possible values for the Channel B selection
				foreach (SwitcherChannelSelection switcherChannel in Enum.GetValues(typeof(SwitcherChannelSelection)))
				{
					ComboBoxInputChannelB.Items.Add(switcherChannel);
				}
				ComboBoxInputChannelB.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonOutputSwitcher_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate Signal Path Setup
				APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

				// Turn on support for output switchers
				APx.SignalPathSetup.UseOutputSwitcher = true;

				// get the switcher address
				SwitcherAddress address = (SwitcherAddress)NumericUpDownOutputChannel.Value;

				// get the Channel A selection
				SwitcherChannelSelection channelA = (SwitcherChannelSelection)ComboBoxOutputChannelA.SelectedIndex;
				// set the Channel A selection
				APx.SignalPathSetup.OutputSwitcherConfiguration.SetChannelA(address, channelA);

				// get the Channel B selection
				OutputSwitcherChannelBSelection channelB = (OutputSwitcherChannelBSelection)ComboBoxOutputChannelB.SelectedIndex;
				// Set the Channel B selection
				APx.SignalPathSetup.OutputSwitcherConfiguration.SetChannelB(address, channelB);
			}
			catch(Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonInputSwitcher_Click(object sender, EventArgs e)
		{
			try
			{
				// Activate Signal Path Setup
				APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

				// Turn on support for input switchers
				APx.SignalPathSetup.UseInputSwitcher = true;

				// get the switcher address
				SwitcherAddress address = (SwitcherAddress)NumericUpDownInputChannel.Value;

				// get the Channel A selection
				SwitcherChannelSelection channelA = (SwitcherChannelSelection)ComboBoxInputChannelA.SelectedIndex;
				// set the Channel A selection
				APx.SignalPathSetup.InputSwitcherConfiguration.SetChannelA(address, channelA);

				// get the Channel B selection
				SwitcherChannelSelection channelB = (SwitcherChannelSelection)ComboBoxInputChannelB.SelectedIndex;
				// set the Channel B selection
				APx.SignalPathSetup.InputSwitcherConfiguration.SetChannelB(address, channelB);
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonOpenOutput_Click(object sender, EventArgs e)
		{
			// Activate Signal Path Setup
			APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

			OpenFileDialog1.DefaultExt = ".swo";
			OpenFileDialog1.Filter = "Switcher Files (*.swo)|*.swo";
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// load the output switcher configuration from a file
				APx.SignalPathSetup.OutputSwitcherConfiguration.Open(OpenFileDialog1.FileName);
			}
		}

		private void ButtonSaveOutput_Click(object sender, EventArgs e)
		{
			APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

			SaveFileDialog1.DefaultExt = ".swo";
			SaveFileDialog1.Filter = "Switcher Files (*.swo)|*.swo";
			if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// save the current output switcher configuration to a file
				APx.SignalPathSetup.OutputSwitcherConfiguration.Save(SaveFileDialog1.FileName);
			}
		}

		private void ButtonOpenInput_Click(object sender, EventArgs e)
		{
			APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

			OpenFileDialog1.DefaultExt = ".swi";
			OpenFileDialog1.Filter = "Switcher Files (*.swi)|*.swi";
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// load the input switcher configuration from a file
				APx.SignalPathSetup.InputSwitcherConfiguration.Open(OpenFileDialog1.FileName);
			}
		}

		private void ButtonSaveInput_Click(object sender, EventArgs e)
		{
			APx.ShowMeasurement("Signal Path1", "Signal Path Setup");

			SaveFileDialog1.DefaultExt = ".swi";
			SaveFileDialog1.Filter = "Switcher Files (*.swi)|*.swi";
			if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// save the current input switcher configuration to a file
				APx.SignalPathSetup.InputSwitcherConfiguration.Save(SaveFileDialog1.FileName);
			}
		}
	}
}