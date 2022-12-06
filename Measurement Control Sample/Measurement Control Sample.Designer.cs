namespace Measurement_Control_Sample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TestResultLabel = new System.Windows.Forms.Label();
			this.SteppedLevelSweepButton = new System.Windows.Forms.Button();
			this.SteppedFrequencySweepButton = new System.Windows.Forms.Button();
			this.ContinuousSweepButton = new System.Windows.Forms.Button();
			this.FrequencyResponseButton = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.TestResultLabel);
			this.GroupBox1.Location = new System.Drawing.Point(167, 14);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(147, 110);
			this.GroupBox1.TabIndex = 9;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Test Result";
			// 
			// TestResultLabel
			// 
			this.TestResultLabel.Location = new System.Drawing.Point(6, 48);
			this.TestResultLabel.Name = "TestResultLabel";
			this.TestResultLabel.Size = new System.Drawing.Size(135, 13);
			this.TestResultLabel.TabIndex = 0;
			this.TestResultLabel.Text = "IN PROGRESS";
			this.TestResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SteppedLevelSweepButton
			// 
			this.SteppedLevelSweepButton.Location = new System.Drawing.Point(14, 101);
			this.SteppedLevelSweepButton.Name = "SteppedLevelSweepButton";
			this.SteppedLevelSweepButton.Size = new System.Drawing.Size(147, 23);
			this.SteppedLevelSweepButton.TabIndex = 8;
			this.SteppedLevelSweepButton.Text = "Stepped Level Sweep";
			this.SteppedLevelSweepButton.UseVisualStyleBackColor = true;
			this.SteppedLevelSweepButton.Click += new System.EventHandler(this.SteppedLevelSweepButton_Click);
			// 
			// SteppedFrequencySweepButton
			// 
			this.SteppedFrequencySweepButton.Location = new System.Drawing.Point(14, 72);
			this.SteppedFrequencySweepButton.Name = "SteppedFrequencySweepButton";
			this.SteppedFrequencySweepButton.Size = new System.Drawing.Size(147, 23);
			this.SteppedFrequencySweepButton.TabIndex = 7;
			this.SteppedFrequencySweepButton.Text = "Stepped Frequency Sweep";
			this.SteppedFrequencySweepButton.UseVisualStyleBackColor = true;
			this.SteppedFrequencySweepButton.Click += new System.EventHandler(this.SteppedFrequencySweepButton_Click);
			// 
			// ContinuousSweepButton
			// 
			this.ContinuousSweepButton.Location = new System.Drawing.Point(14, 43);
			this.ContinuousSweepButton.Name = "ContinuousSweepButton";
			this.ContinuousSweepButton.Size = new System.Drawing.Size(147, 23);
			this.ContinuousSweepButton.TabIndex = 6;
			this.ContinuousSweepButton.Text = "Continuous Sweep";
			this.ContinuousSweepButton.UseVisualStyleBackColor = true;
			this.ContinuousSweepButton.Click += new System.EventHandler(this.ContinuousSweepButton_Click);
			// 
			// FrequencyResponseButton
			// 
			this.FrequencyResponseButton.Location = new System.Drawing.Point(14, 14);
			this.FrequencyResponseButton.Name = "FrequencyResponseButton";
			this.FrequencyResponseButton.Size = new System.Drawing.Size(147, 23);
			this.FrequencyResponseButton.TabIndex = 5;
			this.FrequencyResponseButton.Text = "Frequency Response";
			this.FrequencyResponseButton.UseVisualStyleBackColor = true;
			this.FrequencyResponseButton.Click += new System.EventHandler(this.FrequencyResponseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 138);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.SteppedLevelSweepButton);
			this.Controls.Add(this.SteppedFrequencySweepButton);
			this.Controls.Add(this.ContinuousSweepButton);
			this.Controls.Add(this.FrequencyResponseButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Measurement Control Sample";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label TestResultLabel;
		internal System.Windows.Forms.Button SteppedLevelSweepButton;
		internal System.Windows.Forms.Button SteppedFrequencySweepButton;
		internal System.Windows.Forms.Button ContinuousSweepButton;
		internal System.Windows.Forms.Button FrequencyResponseButton;
	}
}

