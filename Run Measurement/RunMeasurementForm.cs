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
//   * Run measurements and display pass/fail information
//
//-------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class RunMeasurementForm : Form
	{
		public RunMeasurementForm()
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
				APx.OpenProject(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\SampleProject.approjX");
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonFrequencyResponse_Click(Object sender, EventArgs e)
		{
			try
			{
				// Run the Frequency Response measurement
				APx.Sequence["Signal Path1"]["Frequency Response"].Run();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// Update the passed/failed indicator for this measurement
			UpdateMeasurementPassed("Signal Path1", "Frequency Response");
		}

		private void ButtonLevelAndGain_Click(Object sender, EventArgs e)
		{
			try
			{
				// Run the Level and Gain measurement 
				APx.Sequence["Signal Path1"]["Level and Gain"].Run();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// Update the passed/failed indicator for this measurement
			UpdateMeasurementPassed("Signal Path1", "Level and Gain");
		}

		private void UpdateMeasurementPassed(string signalPathName, string measurementName)
		{
			bool Passed;
			Passed = true;

			// Examine the requested measurement to see if it passed limit checks
			if (APx.Sequence[signalPathName][measurementName].HasSequenceResults)
			{
				// The measurement recorded results.
				// Now traverse each result see if it passed limits
				foreach (ISequenceResult result in APx.Sequence[signalPathName][measurementName].SequenceResults)
				{
					Passed = Passed & (result.PassedUpperLimitCheck & result.PassedLowerLimitCheck);
				}
			}
			else
			{
				Passed = false;
			}

			// update the on screen indicator
			if (Passed)
			{
				LabelResult.Text = "Passed";
				LabelResult.BackColor = Color.DarkGreen;
				LabelResult.ForeColor = Color.White;
			}
			else
			{
				LabelResult.Text = "Failed";
				LabelResult.BackColor = Color.DarkRed;
				LabelResult.ForeColor = Color.White;
			}
		}
	}
} 
