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
//   * Reading the APx500 software//s version number.
//   * Reading the connected APx instrument//s serial number.
//   * Detecting installed APx options.
//   * Shutting down the APx500 software.
//
//-------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using AudioPrecision.API;

namespace APx_Information_Sample
{
	public partial class Form1 : Form
	{
		// Holds a reference to the APx500 software.
		private APx500 APx;

		public Form1()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Connect to the APx500 software.
			APx = new APx500();

			// Show the APx500 software's window.
			APx.Visible = true;

			// Put this program's window on top of the others.
			this.Focus();                              
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			// Shutdown the APx500 software.
			APx.Exit();      
			APx = null;

			base.OnFormClosed(e);
		}

		private void GetInfoButton_Click(object sender, EventArgs e)
		{
			// Read the APx500 software//s version number.
			SoftwareVersionTextBox.Text = APx.Version.SoftwareVersion;       

			// Check to see if the APx500 software is running in demo mode.
			if (APx.IsDemoMode)
			{
				// If the APx500 software is in demo mode it is
				// impossible to read the hardware's serial number.
				HardwareVersionTextBox.Text = "Hardware is not detected.";
			}
			else
			{
				// Read the connected APx instrument's serial number.
				HardwareVersionTextBox.Text = APx.Version.InstrumentID;
			}

			ListBoxOptions.Items.Clear();

			foreach (APxOption opt in Enum.GetValues(typeof(APxOption)))
			{
				if (APx.Version.IsOptionPresent(opt))
					ListBoxOptions.Items.Add(opt);
			}
		}
	}
}