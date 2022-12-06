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
//   * Runing a sequence.
//   * Display sequence results in an on screen grid.
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
		public APx500 APx = new APx500();

		// This function runs the APx sequence as if the user pressed the Start Sequence button.
		private void ButtonRunSequence_Click(object sender, EventArgs e)
		{
			// Use a Try..Catch block to handle any errors
			try
			{
				// Connect to APx500
				APx = new APx500();

				// Make the APx500 application window visible
				APx.Visible = true;

				// This sample uses a TreeView control to mimic the display in the APx Measurement Navigator
				TreeView1.Nodes.Clear();

				// Clear any results from the grid
				DataGridView1.Columns.Clear();
				DataGridView1.Rows.Clear();

				// Run the sequence
				APx.Sequence.Run();
               
                // Traverse each signal path in the sequence
				foreach (ISignalPath signalPath in APx.Sequence)
				{
					if (signalPath.Checked)
					{
						// add a node to the tree for this signal path
						TreeNode signalPathNode = new TreeNode(signalPath.Name);
						signalPathNode.Tag = signalPath;
						TreeView1.Nodes.Add(signalPathNode);

						// Traverse each measurement in the signal path
						foreach (ISequenceMeasurement measurement in signalPath)
						{
							// Check to see if this measurement obtained results during the sequence run
							if (measurement.HasSequenceResults)
							{
								// measurement has sequence results, so add it to the tree
								TreeNode measurementNode = new TreeNode(measurement.Name);
								measurementNode.Tag = measurement;
								signalPathNode.Nodes.Add(measurementNode);

								// Traverse each result for the measurement.  Only the results which were checked
								// in the APx Measurement Navigator will appear in this collection
								foreach (ISequenceResult sequenceResult in measurement.SequenceResults)
								{
									// add a node to the tree for the result
									TreeNode resultNode = new TreeNode(sequenceResult.Name);
									resultNode.Tag = sequenceResult;
									measurementNode.Nodes.Add(resultNode);
								}
							}
						}
					}
				}

			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error in sequence", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if(TreeView1.Nodes.Count > 0)
				TreeView1.Nodes[0].Expand();
		}

		// When the user clicks on a new node in the tree, attempt to show the results for that node
		private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				// clear out any existing data
				DataGridView1.Columns.Clear();
				DataGridView1.Rows.Clear();
				Application.DoEvents();
				Cursor = Cursors.WaitCursor;

				// check to see that the user clicked on a measurement result node
				if ((e.Node.Tag) is ISequenceResult)
				{
					// The user clicked on a measurement result node
					ISequenceResult result;
					result = (ISequenceResult)e.Node.Tag;

					// See if the result contains meter values
					if (result.HasMeterValues)
					{
						// The result contains meter values, so add two columns to the grid
						DataGridView1.Columns.Add("Channel", "Channel");
						DataGridView1.Columns.Add("Value", "Value (" + result.MeterUnit + ")");

						// get the meter values
						double[] values;
						values = result.GetMeterValues();
						for (int i = 0; i <= values.Length - 1; i++)
						{
							// Add the meter values to the grid
							DataGridView1.Rows.Add(string.Format("Ch{0}", i + 1), values[i]);
						}
					}
					else if (result.HasXYValues)
					{
						// the result contains X,Y graph values

						// Traverse each channel and fill the grid with X,Y pairs for the graph data
						for (int ch = 0; ch <= result.ChannelCount - 1; ch++)
						{
							// add X and Y columns for this channel
						    string channelName = string.Format("Channel{0}", ch + 1);
							DataGridView1.Columns.Add(channelName + " X", channelName + " X (" + result.XUnit + ")");
							DataGridView1.Columns.Add(channelName + " Y", channelName + " Y (" + result.YUnit + ")");

							// Get the X and Y values for this channel
						    double[] xValues = result.GetXValues(ch);
						    double[] yValues = result.GetYValues(ch);

                            //for the first channel RowCount will be zero.
							if (DataGridView1.RowCount == 0 && xValues.Length > 0)
							{
								//add all the rows that will be needed.
								DataGridView1.Rows.Add(xValues.Length);
							}

							for (int i = 0; i <= xValues.Length - 1; i++)
							{
								// add the x,y pairs to the grid
								DataGridView1.Rows[i].Cells[ch * 2].Value = xValues[i];
								DataGridView1.Rows[i].Cells[(ch * 2) + 1].Value = yValues[i];
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}


		// This function runs the sequence by manually traversing the sequence in the APx project and running the checked measurements individually
		private void ButtonCustomSequence_Click(object sender, EventArgs e)
		{
			try
			{
				APx.Visible = true;

				// This sample uses a TreeView control to mimic the display in the APx Measurement Navigator
				TreeView1.Nodes.Clear();

				// Clear out any old data
				DataGridView1.Columns.Clear();
				DataGridView1.Rows.Clear();

				// Traverse each signal path in the sequence
				foreach (ISignalPath signalPath in APx.Sequence)
				{
					// check to see if the signal path is checked
					if (signalPath.Checked)
					{
						// signal path is checked, so add it to the tree
						TreeNode signalPathNode = new TreeNode(signalPath.Name);
						signalPathNode.Tag = signalPath;
						TreeView1.Nodes.Add(signalPathNode);

						// traverse each measurement in the signal path
						foreach (ISequenceMeasurement measurement in signalPath)
						{
							// check to see if meaurement is checked
							if (measurement.Checked)
							{
								// measurement is checked, so add it to the tree
								TreeNode measurementNode = new TreeNode(measurement.Name);
								measurementNode.Tag = measurement;
								signalPathNode.Nodes.Add(measurementNode);
								measurementNode.EnsureVisible();

								Application.DoEvents();

								// run the measurement
								measurement.Run();

								// Add each checked result from the measurement to the tree
								foreach (ISequenceResult sequenceResult in measurement.SequenceResults)
								{
									TreeNode resultNode = new TreeNode(sequenceResult.Name);
									resultNode.Tag = sequenceResult;
									measurementNode.Nodes.Add(resultNode);
								}
								measurementNode.Expand();
							}
						}
					}
				}

			}
			catch (Exception ex)
			{
				// Display an error message
				MessageBox.Show(ex.Message, "Error in sequence", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			TreeView1.Nodes[0].Expand();

		}

		private void ButtonOpenProject_Click(object sender, EventArgs e)
		{
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBoxProjectFile.Text = OpenFileDialog1.FileName;
				// Open the specified project file
				APx.OpenProject(TextBoxProjectFile.Text);
			}
		}
	}
}