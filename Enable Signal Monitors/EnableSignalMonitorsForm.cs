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
//   * Enable / disable APx signal monitors 
//       - (disabling the monitors improves measurement speed).
//-------------------------------------------------------------------------------------

using System;
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
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonEnableSignalMonitors_Click(Object sender, EventArgs e)
		{
			// Turn the signal monitors on
			APx.SignalMonitorsEnabled = true;
		}

		private void ButtonDisableSignalMonitors_Click(Object sender, EventArgs e)
		{
			// Turn the signal monitors off
			APx.SignalMonitorsEnabled = false;
		}
	}
} 
