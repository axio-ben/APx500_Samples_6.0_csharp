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
//   * Run a sequence and display pass/fail information
//
//-------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using AudioPrecision.API;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace APx500_Samples
{
	public partial class RunSequenceForm : Form
	{
		public RunSequenceForm()
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


		private void ButtonBrowse_Click(Object sender, EventArgs e)
		{
			if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				TextBoxProjectFile.Text = OpenFileDialog1.FileName;
				try
				{
					// Open the project file
					APx.OpenProject(TextBoxProjectFile.Text);
				}
				catch (Exception ex)
				{
					// Display an error message
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ButtonRunSequence_Click(Object sender, EventArgs e)
		{
			try
			{
				// Run the sequence
				APx.Sequence.Run();
			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// update on screen indicator
			if (APx.Sequence.Passed)
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

			Application.DoEvents();
		}
	}
} 
