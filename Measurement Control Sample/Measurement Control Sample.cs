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
//   * Running a specific measurement.
//   * Checking the pass/fail result of a specific measurement.
//   * Updating this sample program//s user interface with information about the current measurement//s status.
//   * Shutting down the APx500 software.
//
//-------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace Measurement_Control_Sample
{
	public partial class Form1 : Form
	{
		// This enumeration represents possible testing states.
		enum TestingStatus
		{
			Stopped,
			InProgress,
			Passed,
			Failed,
		}

		private APx500 APx;

		public Form1()
		{
			InitializeComponent();

			//Connect to the APx500 software.
			APx = new APx500();
			//Show the APx500 software's window.
			APx.Visible = true;
			//Load the sample project file.
			APx.OpenProject(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sample APx500 Project.approjx");
			//Set the current testing status to stopped.
			SetTestingStatus(TestingStatus.Stopped);
			//Put this program's window on top of the others.
			this.Focus();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			//Shutdown the APx500 software
			APx.Exit();
			APx = null;

			base.OnFormClosed(e);
		}

		private void FrequencyResponseButton_Click(object sender, EventArgs e)
		{
			//Let the user know a measurement is in progress.
			SetTestingStatus(TestingStatus.InProgress);
			APx.ShowMeasurement("Signal Path1", "Frequency Response");
			try
			{
				//Run the measurement.
				APx.FrequencyResponse.Start();
				//Check the test result and update the form's status indicator.		
				CheckTestStatus(APx.FrequencyResponse.PassedLimitChecks);
			}
			catch(APException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SetTestingStatus(TestingStatus.Failed);
			}
		}

		private void ContinuousSweepButton_Click(object sender, EventArgs e)
		{
			//Let the user know a measurement is in progress.
			SetTestingStatus(TestingStatus.InProgress);
			APx.ShowMeasurement("Signal Path1", "Continuous Sweep");
			try
			{
				//Run the measurement.
				APx.ContinuousSweep.Start();
				//Check the test result and update the form's status indicator.		}
				CheckTestStatus(APx.ContinuousSweep.PassedLimitChecks);
			}
			catch (APException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SetTestingStatus(TestingStatus.Failed);
			}
		}

		private void SteppedFrequencySweepButton_Click(object sender, EventArgs e)
		{
			//Let the user know a measurement is in progress.
			SetTestingStatus(TestingStatus.InProgress);
			APx.ShowMeasurement("Signal Path1", "Stepped Frequency Sweep");
			try
			{
				//Run the measurement.
				APx.SteppedFrequencySweep.Start();
				//Check the test result and update the form's status indicator.
				CheckTestStatus(APx.SteppedFrequencySweep.PassedLimitChecks);
				SetTestingStatus(TestingStatus.Failed);
			}
			catch (APException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SteppedLevelSweepButton_Click(object sender, EventArgs e)
		{
			//Let the user know a measurement is in progress.
			SetTestingStatus(TestingStatus.InProgress);
			APx.ShowMeasurement("Signal Path1", "Stepped Level Sweep");
			try
			{
				//Run the measurement.
				APx.SteppedLevelSweep.Start();
				// Check the test result and update the form's status indicator.
				CheckTestStatus(APx.SteppedLevelSweep.PassedLimitChecks);
				SetTestingStatus(TestingStatus.Failed);
			}
			catch (APException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//This function updates this form's testing status indicator text.
		private void SetTestingStatus(TestingStatus newStatus)
		{
			switch (newStatus)
			{
				case TestingStatus.Stopped:
					TestResultLabel.Text = "";
					break;

				case TestingStatus.InProgress:
					TestResultLabel.Text = "In Progress...";
					TestResultLabel.ForeColor = Color.Black;
					break;

				case TestingStatus.Failed:
					TestResultLabel.Text = "FAILED";
					TestResultLabel.ForeColor = Color.Red;
					break;

				case TestingStatus.Passed:
					TestResultLabel.Text = "PASSED";
					TestResultLabel.ForeColor = Color.Green;
					break;
			}

			// Cause this form to be redrawn with the updated status indicator.
			// Otherwise, it may take a noticeable amount of time before the repaint happens.
			Application.DoEvents();
		}

		//Translate a True or False into Pass or Fail and update the form.
		private void CheckTestStatus(bool status)
		{
			if (status)
				SetTestingStatus(TestingStatus.Passed);
			else
				SetTestingStatus(TestingStatus.Failed);
		}
	}
}