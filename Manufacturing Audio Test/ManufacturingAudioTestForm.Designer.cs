namespace APx500_Samples
{
	partial class ManufacturingAudioTestForm
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
			this.ColumnHeaderUpperLimit = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderPassFail = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderLessThan = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderGreaterThan = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderActual = new System.Windows.Forms.ColumnHeader();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.RichTextBoxInstructions = new System.Windows.Forms.RichTextBox();
			this.TextBoxSerialNumber = new System.Windows.Forms.TextBox();
			this.ButtonOpenFile = new System.Windows.Forms.Button();
			this.ButtonStop = new System.Windows.Forms.Button();
			this.ButtonNext = new System.Windows.Forms.Button();
			this.ButtonStart = new System.Windows.Forms.Button();
			this.ComboBoxJump = new System.Windows.Forms.ComboBox();
			this.ButtonJump = new System.Windows.Forms.Button();
			this.LabelPassFailValue = new System.Windows.Forms.Label();
			this.LabelPassFail = new System.Windows.Forms.Label();
			this.ColumnHeaderLowerLimit = new System.Windows.Forms.ColumnHeader();
			this.LabelStepCount = new System.Windows.Forms.Label();
			this.LabelStepNumber = new System.Windows.Forms.Label();
			this.LabelStepOf = new System.Windows.Forms.Label();
			this.LabelStep = new System.Windows.Forms.Label();
			this.LabelSerialNumber = new System.Windows.Forms.Label();
			this.LabelTestFile = new System.Windows.Forms.Label();
			this.LabelModelNameValue = new System.Windows.Forms.Label();
			this.LabelModelName = new System.Windows.Forms.Label();
			this.ColumnHeaderDutInput = new System.Windows.Forms.ColumnHeader();
			this.ListViewResults = new System.Windows.Forms.ListView();
			this.ColumnHeaderDutOutput = new System.Windows.Forms.ColumnHeader();
			this.LabelTestFileDate = new System.Windows.Forms.Label();
			this.LabelTestFileName = new System.Windows.Forms.Label();
			this.LabelInstructions = new System.Windows.Forms.Label();
			this.LabelTestValue = new System.Windows.Forms.Label();
			this.LabelTest = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ColumnHeaderUpperLimit
			// 
			this.ColumnHeaderUpperLimit.Text = "Upper Limit";
			this.ColumnHeaderUpperLimit.Width = 80;
			// 
			// ColumnHeaderPassFail
			// 
			this.ColumnHeaderPassFail.Text = "Pass/Fail";
			this.ColumnHeaderPassFail.Width = 78;
			// 
			// ColumnHeaderLessThan
			// 
			this.ColumnHeaderLessThan.Text = "";
			this.ColumnHeaderLessThan.Width = 25;
			// 
			// ColumnHeaderGreaterThan
			// 
			this.ColumnHeaderGreaterThan.Text = "";
			this.ColumnHeaderGreaterThan.Width = 25;
			// 
			// ColumnHeaderActual
			// 
			this.ColumnHeaderActual.Text = "Actual Measurement";
			this.ColumnHeaderActual.Width = 226;
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.DefaultExt = "approj";
			this.OpenFileDialog1.Filter = "APx500 Project Files(*.approj,*.approjx)|*.approj;*.approjx";
			this.OpenFileDialog1.Title = "Open File";
			// 
			// RichTextBoxInstructions
			// 
			this.RichTextBoxInstructions.Location = new System.Drawing.Point(15, 132);
			this.RichTextBoxInstructions.Name = "RichTextBoxInstructions";
			this.RichTextBoxInstructions.ReadOnly = true;
			this.RichTextBoxInstructions.Size = new System.Drawing.Size(764, 146);
			this.RichTextBoxInstructions.TabIndex = 32;
			this.RichTextBoxInstructions.Text = "";
			// 
			// TextBoxSerialNumber
			// 
			this.TextBoxSerialNumber.Location = new System.Drawing.Point(322, 11);
			this.TextBoxSerialNumber.Name = "TextBoxSerialNumber";
			this.TextBoxSerialNumber.Size = new System.Drawing.Size(113, 20);
			this.TextBoxSerialNumber.TabIndex = 31;
			// 
			// ButtonOpenFile
			// 
			this.ButtonOpenFile.Location = new System.Drawing.Point(442, 38);
			this.ButtonOpenFile.Name = "ButtonOpenFile";
			this.ButtonOpenFile.Size = new System.Drawing.Size(75, 23);
			this.ButtonOpenFile.TabIndex = 30;
			this.ButtonOpenFile.Text = "Browse...";
			this.ButtonOpenFile.UseVisualStyleBackColor = true;
			this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
			// 
			// ButtonStop
			// 
			this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonStop.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ButtonStop.Location = new System.Drawing.Point(705, 533);
			this.ButtonStop.Name = "ButtonStop";
			this.ButtonStop.Size = new System.Drawing.Size(75, 23);
			this.ButtonStop.TabIndex = 28;
			this.ButtonStop.Text = "Stop";
			this.ButtonStop.UseVisualStyleBackColor = true;
			this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// ButtonNext
			// 
			this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ButtonNext.Location = new System.Drawing.Point(623, 533);
			this.ButtonNext.Name = "ButtonNext";
			this.ButtonNext.Size = new System.Drawing.Size(75, 23);
			this.ButtonNext.TabIndex = 29;
			this.ButtonNext.Text = "Next";
			this.ButtonNext.UseVisualStyleBackColor = true;
			this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// ButtonStart
			// 
			this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonStart.Location = new System.Drawing.Point(542, 533);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(75, 23);
			this.ButtonStart.TabIndex = 27;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// ComboBoxJump
			// 
			this.ComboBoxJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ComboBoxJump.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxJump.FormattingEnabled = true;
			this.ComboBoxJump.Location = new System.Drawing.Point(92, 533);
			this.ComboBoxJump.Name = "ComboBoxJump";
			this.ComboBoxJump.Size = new System.Drawing.Size(279, 21);
			this.ComboBoxJump.TabIndex = 26;
			// 
			// ButtonJump
			// 
			this.ButtonJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonJump.Location = new System.Drawing.Point(11, 531);
			this.ButtonJump.Name = "ButtonJump";
			this.ButtonJump.Size = new System.Drawing.Size(75, 23);
			this.ButtonJump.TabIndex = 25;
			this.ButtonJump.Text = "Jump";
			this.ButtonJump.UseVisualStyleBackColor = true;
			this.ButtonJump.Click += new System.EventHandler(this.ButtonJump_Click);
			// 
			// LabelPassFailValue
			// 
			this.LabelPassFailValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.LabelPassFailValue.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelPassFailValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelPassFailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPassFailValue.Location = new System.Drawing.Point(672, 294);
			this.LabelPassFailValue.Name = "LabelPassFailValue";
			this.LabelPassFailValue.Size = new System.Drawing.Size(107, 33);
			this.LabelPassFailValue.TabIndex = 21;
			this.LabelPassFailValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelPassFail
			// 
			this.LabelPassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPassFail.Location = new System.Drawing.Point(565, 294);
			this.LabelPassFail.Name = "LabelPassFail";
			this.LabelPassFail.Size = new System.Drawing.Size(101, 33);
			this.LabelPassFail.TabIndex = 23;
			this.LabelPassFail.Text = "Pass/Fail:";
			this.LabelPassFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ColumnHeaderLowerLimit
			// 
			this.ColumnHeaderLowerLimit.Text = "Lower Limit";
			this.ColumnHeaderLowerLimit.Width = 80;
			// 
			// LabelStepCount
			// 
			this.LabelStepCount.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelStepCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelStepCount.Location = new System.Drawing.Point(748, 9);
			this.LabelStepCount.Name = "LabelStepCount";
			this.LabelStepCount.Size = new System.Drawing.Size(31, 20);
			this.LabelStepCount.TabIndex = 22;
			this.LabelStepCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelStepNumber
			// 
			this.LabelStepNumber.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelStepNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelStepNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelStepNumber.Location = new System.Drawing.Point(687, 9);
			this.LabelStepNumber.Name = "LabelStepNumber";
			this.LabelStepNumber.Size = new System.Drawing.Size(31, 20);
			this.LabelStepNumber.TabIndex = 12;
			this.LabelStepNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelStepOf
			// 
			this.LabelStepOf.Location = new System.Drawing.Point(724, 9);
			this.LabelStepOf.Name = "LabelStepOf";
			this.LabelStepOf.Size = new System.Drawing.Size(18, 20);
			this.LabelStepOf.TabIndex = 13;
			this.LabelStepOf.Text = " / ";
			this.LabelStepOf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelStep
			// 
			this.LabelStep.Location = new System.Drawing.Point(640, 9);
			this.LabelStep.Name = "LabelStep";
			this.LabelStep.Size = new System.Drawing.Size(41, 20);
			this.LabelStep.TabIndex = 14;
			this.LabelStep.Text = "Step:";
			this.LabelStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelSerialNumber
			// 
			this.LabelSerialNumber.Location = new System.Drawing.Point(275, 9);
			this.LabelSerialNumber.Name = "LabelSerialNumber";
			this.LabelSerialNumber.Size = new System.Drawing.Size(51, 20);
			this.LabelSerialNumber.TabIndex = 9;
			this.LabelSerialNumber.Text = "Serial #:";
			this.LabelSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelTestFile
			// 
			this.LabelTestFile.Location = new System.Drawing.Point(12, 38);
			this.LabelTestFile.Name = "LabelTestFile";
			this.LabelTestFile.Size = new System.Drawing.Size(114, 20);
			this.LabelTestFile.TabIndex = 10;
			this.LabelTestFile.Text = "Test Condition File:";
			this.LabelTestFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelModelNameValue
			// 
			this.LabelModelNameValue.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelModelNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelModelNameValue.Location = new System.Drawing.Point(131, 9);
			this.LabelModelNameValue.Name = "LabelModelNameValue";
			this.LabelModelNameValue.Size = new System.Drawing.Size(136, 20);
			this.LabelModelNameValue.TabIndex = 11;
			this.LabelModelNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelModelName
			// 
			this.LabelModelName.Location = new System.Drawing.Point(11, 9);
			this.LabelModelName.Name = "LabelModelName";
			this.LabelModelName.Size = new System.Drawing.Size(114, 20);
			this.LabelModelName.TabIndex = 18;
			this.LabelModelName.Text = "Model Name:";
			this.LabelModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ColumnHeaderDutInput
			// 
			this.ColumnHeaderDutInput.Text = "DUT Input";
			this.ColumnHeaderDutInput.Width = 125;
			// 
			// ListViewResults
			// 
			this.ListViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ListViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderDutInput,
            this.ColumnHeaderDutOutput,
            this.ColumnHeaderLowerLimit,
            this.ColumnHeaderGreaterThan,
            this.ColumnHeaderActual,
            this.ColumnHeaderLessThan,
            this.ColumnHeaderUpperLimit,
            this.ColumnHeaderPassFail});
			this.ListViewResults.GridLines = true;
			this.ListViewResults.Location = new System.Drawing.Point(11, 342);
			this.ListViewResults.Name = "ListViewResults";
			this.ListViewResults.Size = new System.Drawing.Size(768, 183);
			this.ListViewResults.TabIndex = 24;
			this.ListViewResults.UseCompatibleStateImageBehavior = false;
			this.ListViewResults.View = System.Windows.Forms.View.Details;
			// 
			// ColumnHeaderDutOutput
			// 
			this.ColumnHeaderDutOutput.Text = "DUT Output";
			this.ColumnHeaderDutOutput.Width = 125;
			// 
			// LabelTestFileDate
			// 
			this.LabelTestFileDate.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelTestFileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelTestFileDate.Location = new System.Drawing.Point(323, 38);
			this.LabelTestFileDate.Name = "LabelTestFileDate";
			this.LabelTestFileDate.Size = new System.Drawing.Size(113, 20);
			this.LabelTestFileDate.TabIndex = 19;
			this.LabelTestFileDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelTestFileName
			// 
			this.LabelTestFileName.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelTestFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelTestFileName.Location = new System.Drawing.Point(132, 38);
			this.LabelTestFileName.Name = "LabelTestFileName";
			this.LabelTestFileName.Size = new System.Drawing.Size(184, 20);
			this.LabelTestFileName.TabIndex = 20;
			this.LabelTestFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelInstructions
			// 
			this.LabelInstructions.Location = new System.Drawing.Point(12, 106);
			this.LabelInstructions.Name = "LabelInstructions";
			this.LabelInstructions.Size = new System.Drawing.Size(114, 23);
			this.LabelInstructions.TabIndex = 15;
			this.LabelInstructions.Text = "Operating Instructions:";
			this.LabelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelTestValue
			// 
			this.LabelTestValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.LabelTestValue.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelTestValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelTestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTestValue.Location = new System.Drawing.Point(98, 64);
			this.LabelTestValue.Name = "LabelTestValue";
			this.LabelTestValue.Size = new System.Drawing.Size(681, 33);
			this.LabelTestValue.TabIndex = 16;
			this.LabelTestValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelTest
			// 
			this.LabelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTest.Location = new System.Drawing.Point(11, 64);
			this.LabelTest.Name = "LabelTest";
			this.LabelTest.Size = new System.Drawing.Size(81, 33);
			this.LabelTest.TabIndex = 17;
			this.LabelTest.Text = "Test:";
			this.LabelTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ManufacturingAudioTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 564);
			this.Controls.Add(this.RichTextBoxInstructions);
			this.Controls.Add(this.TextBoxSerialNumber);
			this.Controls.Add(this.ButtonOpenFile);
			this.Controls.Add(this.ButtonStop);
			this.Controls.Add(this.ButtonNext);
			this.Controls.Add(this.ButtonStart);
			this.Controls.Add(this.ComboBoxJump);
			this.Controls.Add(this.ButtonJump);
			this.Controls.Add(this.LabelPassFailValue);
			this.Controls.Add(this.LabelPassFail);
			this.Controls.Add(this.LabelStepCount);
			this.Controls.Add(this.LabelStepNumber);
			this.Controls.Add(this.LabelStepOf);
			this.Controls.Add(this.LabelStep);
			this.Controls.Add(this.LabelSerialNumber);
			this.Controls.Add(this.LabelTestFile);
			this.Controls.Add(this.LabelModelNameValue);
			this.Controls.Add(this.LabelModelName);
			this.Controls.Add(this.ListViewResults);
			this.Controls.Add(this.LabelTestFileDate);
			this.Controls.Add(this.LabelTestFileName);
			this.Controls.Add(this.LabelInstructions);
			this.Controls.Add(this.LabelTestValue);
			this.Controls.Add(this.LabelTest);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ManufacturingAudioTestForm";
			this.Text = "Manufacturing Audio Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.ColumnHeader ColumnHeaderUpperLimit;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderPassFail;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderLessThan;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderGreaterThan;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderActual;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.RichTextBox RichTextBoxInstructions;
		internal System.Windows.Forms.TextBox TextBoxSerialNumber;
		internal System.Windows.Forms.Button ButtonOpenFile;
		internal System.Windows.Forms.Button ButtonStop;
		internal System.Windows.Forms.Button ButtonNext;
		internal System.Windows.Forms.Button ButtonStart;
		internal System.Windows.Forms.ComboBox ComboBoxJump;
		internal System.Windows.Forms.Button ButtonJump;
		internal System.Windows.Forms.Label LabelPassFailValue;
		internal System.Windows.Forms.Label LabelPassFail;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderLowerLimit;
		internal System.Windows.Forms.Label LabelStepCount;
		internal System.Windows.Forms.Label LabelStepNumber;
		internal System.Windows.Forms.Label LabelStepOf;
		internal System.Windows.Forms.Label LabelStep;
		internal System.Windows.Forms.Label LabelSerialNumber;
		internal System.Windows.Forms.Label LabelTestFile;
		internal System.Windows.Forms.Label LabelModelNameValue;
		internal System.Windows.Forms.Label LabelModelName;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderDutInput;
		internal System.Windows.Forms.ListView ListViewResults;
		internal System.Windows.Forms.ColumnHeader ColumnHeaderDutOutput;
		internal System.Windows.Forms.Label LabelTestFileDate;
		internal System.Windows.Forms.Label LabelTestFileName;
		internal System.Windows.Forms.Label LabelInstructions;
		internal System.Windows.Forms.Label LabelTestValue;
		internal System.Windows.Forms.Label LabelTest;
	}
}

