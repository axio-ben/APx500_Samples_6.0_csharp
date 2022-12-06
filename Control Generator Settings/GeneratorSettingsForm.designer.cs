namespace APx500_Samples
{
    partial class GeneratorSettings 
    { 
        
        // Form overrides dispose to clean up the component list.
        protected override void Dispose( bool disposing ) 
        { 
            try 
            { 
                if ( disposing && components != null ) 
                { 
                    components.Dispose(); 
                } 
            } 
            finally 
            { 
                base.Dispose( disposing ); 
            } 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components = null; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
		private void InitializeComponent()
		{
			this.ButtonLevelAndGain1 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBoxLevelAndGainLevel = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBoxLevelAndGainFrequency = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.TextBoxSnrLevel = new System.Windows.Forms.TextBox();
			this.ButtonSnr1 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBoxSnrFrequency = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBoxFrequencyResponse = new System.Windows.Forms.GroupBox();
			this.TextBoxFrequencyResponseLevel = new System.Windows.Forms.TextBox();
			this.ButtonFrequencyResponse1 = new System.Windows.Forms.Button();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBoxFrequencyResponseStopFrequency = new System.Windows.Forms.TextBox();
			this.TextBoxFrequencyResponseStartFrequency = new System.Windows.Forms.TextBox();
			this.GroupBoxSteppedFrequencySweep = new System.Windows.Forms.GroupBox();
			this.NumericUpDownSteeppedFrequencySwepPoints = new System.Windows.Forms.NumericUpDown();
			this.TextBoxSteppedFrequencySweepLevel = new System.Windows.Forms.TextBox();
			this.ButtonSteppedFrequency1 = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBoxSteppedFrequencySweepStartFrequency = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBoxSteppedFrequencySweepStopFrequency = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBoxFrequencyResponse.SuspendLayout();
			this.GroupBoxSteppedFrequencySweep.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSteeppedFrequencySwepPoints)).BeginInit();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonLevelAndGain1
			// 
			this.ButtonLevelAndGain1.Location = new System.Drawing.Point(72, 68);
			this.ButtonLevelAndGain1.Name = "ButtonLevelAndGain1";
			this.ButtonLevelAndGain1.Size = new System.Drawing.Size(100, 23);
			this.ButtonLevelAndGain1.TabIndex = 4;
			this.ButtonLevelAndGain1.Text = "Set Generator";
			this.ButtonLevelAndGain1.UseVisualStyleBackColor = true;
			this.ButtonLevelAndGain1.Click += new System.EventHandler(this.ButtonLevelAndGain1_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.TextBoxLevelAndGainLevel);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBoxLevelAndGainFrequency);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.ButtonLevelAndGain1);
			this.GroupBox1.Location = new System.Drawing.Point(6, 14);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(186, 100);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Level and Gain";
			// 
			// TextBoxLevelAndGainLevel
			// 
			this.TextBoxLevelAndGainLevel.Location = new System.Drawing.Point(72, 42);
			this.TextBoxLevelAndGainLevel.Name = "TextBoxLevelAndGainLevel";
			this.TextBoxLevelAndGainLevel.Size = new System.Drawing.Size(100, 20);
			this.TextBoxLevelAndGainLevel.TabIndex = 3;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 45);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(36, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Level:";
			// 
			// TextBoxLevelAndGainFrequency
			// 
			this.TextBoxLevelAndGainFrequency.Location = new System.Drawing.Point(72, 19);
			this.TextBoxLevelAndGainFrequency.Name = "TextBoxLevelAndGainFrequency";
			this.TextBoxLevelAndGainFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxLevelAndGainFrequency.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(60, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Frequency:";
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.TextBoxSnrLevel);
			this.GroupBox2.Controls.Add(this.ButtonSnr1);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.TextBoxSnrFrequency);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Location = new System.Drawing.Point(210, 14);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(186, 100);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Signal To Noise Ratio";
			// 
			// TextBoxSnrLevel
			// 
			this.TextBoxSnrLevel.Location = new System.Drawing.Point(72, 42);
			this.TextBoxSnrLevel.Name = "TextBoxSnrLevel";
			this.TextBoxSnrLevel.Size = new System.Drawing.Size(100, 20);
			this.TextBoxSnrLevel.TabIndex = 3;
			// 
			// ButtonSnr1
			// 
			this.ButtonSnr1.Location = new System.Drawing.Point(72, 68);
			this.ButtonSnr1.Name = "ButtonSnr1";
			this.ButtonSnr1.Size = new System.Drawing.Size(100, 23);
			this.ButtonSnr1.TabIndex = 4;
			this.ButtonSnr1.Text = "Set Generator";
			this.ButtonSnr1.UseVisualStyleBackColor = true;
			this.ButtonSnr1.Click += new System.EventHandler(this.ButtonSnr1_Click);
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 45);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(36, 13);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Level:";
			// 
			// TextBoxSnrFrequency
			// 
			this.TextBoxSnrFrequency.Location = new System.Drawing.Point(72, 19);
			this.TextBoxSnrFrequency.Name = "TextBoxSnrFrequency";
			this.TextBoxSnrFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxSnrFrequency.TabIndex = 1;
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(60, 13);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Frequency:";
			// 
			// GroupBoxFrequencyResponse
			// 
			this.GroupBoxFrequencyResponse.Controls.Add(this.TextBoxFrequencyResponseLevel);
			this.GroupBoxFrequencyResponse.Controls.Add(this.ButtonFrequencyResponse1);
			this.GroupBoxFrequencyResponse.Controls.Add(this.Label9);
			this.GroupBoxFrequencyResponse.Controls.Add(this.Label5);
			this.GroupBoxFrequencyResponse.Controls.Add(this.Label6);
			this.GroupBoxFrequencyResponse.Controls.Add(this.TextBoxFrequencyResponseStopFrequency);
			this.GroupBoxFrequencyResponse.Controls.Add(this.TextBoxFrequencyResponseStartFrequency);
			this.GroupBoxFrequencyResponse.Location = new System.Drawing.Point(6, 14);
			this.GroupBoxFrequencyResponse.Name = "GroupBoxFrequencyResponse";
			this.GroupBoxFrequencyResponse.Size = new System.Drawing.Size(228, 130);
			this.GroupBoxFrequencyResponse.TabIndex = 0;
			this.GroupBoxFrequencyResponse.TabStop = false;
			this.GroupBoxFrequencyResponse.Text = "Frequency Response";
			// 
			// TextBoxFrequencyResponseLevel
			// 
			this.TextBoxFrequencyResponseLevel.Location = new System.Drawing.Point(112, 71);
			this.TextBoxFrequencyResponseLevel.Name = "TextBoxFrequencyResponseLevel";
			this.TextBoxFrequencyResponseLevel.Size = new System.Drawing.Size(100, 20);
			this.TextBoxFrequencyResponseLevel.TabIndex = 5;
			// 
			// ButtonFrequencyResponse1
			// 
			this.ButtonFrequencyResponse1.Location = new System.Drawing.Point(112, 96);
			this.ButtonFrequencyResponse1.Name = "ButtonFrequencyResponse1";
			this.ButtonFrequencyResponse1.Size = new System.Drawing.Size(101, 23);
			this.ButtonFrequencyResponse1.TabIndex = 6;
			this.ButtonFrequencyResponse1.Text = "Set Generator";
			this.ButtonFrequencyResponse1.UseVisualStyleBackColor = true;
			this.ButtonFrequencyResponse1.Click += new System.EventHandler(this.ButtonFrequencyResponse1_Click);
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(6, 49);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(85, 13);
			this.Label9.TabIndex = 2;
			this.Label9.Text = "Stop Frequency:";
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 23);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(85, 13);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Start Frequency:";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(6, 75);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(36, 13);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Level:";
			// 
			// TextBoxFrequencyResponseStopFrequency
			// 
			this.TextBoxFrequencyResponseStopFrequency.Location = new System.Drawing.Point(112, 45);
			this.TextBoxFrequencyResponseStopFrequency.Name = "TextBoxFrequencyResponseStopFrequency";
			this.TextBoxFrequencyResponseStopFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxFrequencyResponseStopFrequency.TabIndex = 3;
			// 
			// TextBoxFrequencyResponseStartFrequency
			// 
			this.TextBoxFrequencyResponseStartFrequency.Location = new System.Drawing.Point(112, 19);
			this.TextBoxFrequencyResponseStartFrequency.Name = "TextBoxFrequencyResponseStartFrequency";
			this.TextBoxFrequencyResponseStartFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxFrequencyResponseStartFrequency.TabIndex = 1;
			// 
			// GroupBoxSteppedFrequencySweep
			// 
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.NumericUpDownSteeppedFrequencySwepPoints);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.TextBoxSteppedFrequencySweepLevel);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.ButtonSteppedFrequency1);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.Label7);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.TextBoxSteppedFrequencySweepStartFrequency);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.Label8);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.TextBoxSteppedFrequencySweepStopFrequency);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.Label11);
			this.GroupBoxSteppedFrequencySweep.Controls.Add(this.Label10);
			this.GroupBoxSteppedFrequencySweep.Location = new System.Drawing.Point(252, 14);
			this.GroupBoxSteppedFrequencySweep.Name = "GroupBoxSteppedFrequencySweep";
			this.GroupBoxSteppedFrequencySweep.Size = new System.Drawing.Size(228, 152);
			this.GroupBoxSteppedFrequencySweep.TabIndex = 1;
			this.GroupBoxSteppedFrequencySweep.TabStop = false;
			this.GroupBoxSteppedFrequencySweep.Text = "Stepped Frequency Sweep";
			// 
			// NumericUpDownSteeppedFrequencySwepPoints
			// 
			this.NumericUpDownSteeppedFrequencySwepPoints.Location = new System.Drawing.Point(112, 97);
			this.NumericUpDownSteeppedFrequencySwepPoints.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NumericUpDownSteeppedFrequencySwepPoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.NumericUpDownSteeppedFrequencySwepPoints.Name = "NumericUpDownSteeppedFrequencySwepPoints";
			this.NumericUpDownSteeppedFrequencySwepPoints.Size = new System.Drawing.Size(100, 20);
			this.NumericUpDownSteeppedFrequencySwepPoints.TabIndex = 7;
			this.NumericUpDownSteeppedFrequencySwepPoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// TextBoxSteppedFrequencySweepLevel
			// 
			this.TextBoxSteppedFrequencySweepLevel.Location = new System.Drawing.Point(112, 71);
			this.TextBoxSteppedFrequencySweepLevel.Name = "TextBoxSteppedFrequencySweepLevel";
			this.TextBoxSteppedFrequencySweepLevel.Size = new System.Drawing.Size(100, 20);
			this.TextBoxSteppedFrequencySweepLevel.TabIndex = 5;
			// 
			// ButtonSteppedFrequency1
			// 
			this.ButtonSteppedFrequency1.Location = new System.Drawing.Point(112, 123);
			this.ButtonSteppedFrequency1.Name = "ButtonSteppedFrequency1";
			this.ButtonSteppedFrequency1.Size = new System.Drawing.Size(100, 23);
			this.ButtonSteppedFrequency1.TabIndex = 8;
			this.ButtonSteppedFrequency1.Text = "Set Generator";
			this.ButtonSteppedFrequency1.UseVisualStyleBackColor = true;
			this.ButtonSteppedFrequency1.Click += new System.EventHandler(this.ButtonSteppedFrequency1_Click);
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(6, 49);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(85, 13);
			this.Label7.TabIndex = 2;
			this.Label7.Text = "Stop Frequency:";
			// 
			// TextBoxSteppedFrequencySweepStartFrequency
			// 
			this.TextBoxSteppedFrequencySweepStartFrequency.Location = new System.Drawing.Point(112, 19);
			this.TextBoxSteppedFrequencySweepStartFrequency.Name = "TextBoxSteppedFrequencySweepStartFrequency";
			this.TextBoxSteppedFrequencySweepStartFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxSteppedFrequencySweepStartFrequency.TabIndex = 1;
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(6, 23);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(85, 13);
			this.Label8.TabIndex = 0;
			this.Label8.Text = "Start Frequency:";
			// 
			// TextBoxSteppedFrequencySweepStopFrequency
			// 
			this.TextBoxSteppedFrequencySweepStopFrequency.Location = new System.Drawing.Point(112, 45);
			this.TextBoxSteppedFrequencySweepStopFrequency.Name = "TextBoxSteppedFrequencySweepStopFrequency";
			this.TextBoxSteppedFrequencySweepStopFrequency.Size = new System.Drawing.Size(100, 20);
			this.TextBoxSteppedFrequencySweepStopFrequency.TabIndex = 3;
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(6, 101);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(39, 13);
			this.Label11.TabIndex = 6;
			this.Label11.Text = "Points:";
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(6, 75);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(36, 13);
			this.Label10.TabIndex = 4;
			this.Label10.Text = "Level:";
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(12, 12);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(507, 220);
			this.TabControl1.TabIndex = 3;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.GroupBox1);
			this.TabPage1.Controls.Add(this.GroupBox2);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(499, 194);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Meter Measurements";
			this.TabPage1.UseVisualStyleBackColor = true;
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.Add(this.GroupBoxFrequencyResponse);
			this.TabPage2.Controls.Add(this.GroupBoxSteppedFrequencySweep);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(499, 194);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Sweep Measurements";
			this.TabPage2.UseVisualStyleBackColor = true;
			// 
			// GeneratorSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 242);
			this.Controls.Add(this.TabControl1);
			this.Name = "GeneratorSettings";
			this.Text = "Control Generator Settings";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBoxFrequencyResponse.ResumeLayout(false);
			this.GroupBoxFrequencyResponse.PerformLayout();
			this.GroupBoxSteppedFrequencySweep.ResumeLayout(false);
			this.GroupBoxSteppedFrequencySweep.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSteeppedFrequencySwepPoints)).EndInit();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		} 

        internal System.Windows.Forms.Button ButtonLevelAndGain1; 
        internal System.Windows.Forms.GroupBox GroupBox1; 
        internal System.Windows.Forms.GroupBox GroupBox2; 
        internal System.Windows.Forms.Button ButtonSnr1; 
        internal System.Windows.Forms.GroupBox GroupBoxFrequencyResponse; 
        internal System.Windows.Forms.Button ButtonFrequencyResponse1; 
        internal System.Windows.Forms.GroupBox GroupBoxSteppedFrequencySweep; 
        internal System.Windows.Forms.Button ButtonSteppedFrequency1; 
        internal System.Windows.Forms.TextBox TextBoxLevelAndGainLevel; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.TextBox TextBoxLevelAndGainFrequency; 
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.TextBox TextBoxSnrLevel; 
        internal System.Windows.Forms.Label Label4; 
        internal System.Windows.Forms.TextBox TextBoxSnrFrequency; 
        internal System.Windows.Forms.Label Label3; 
        internal System.Windows.Forms.TextBox TextBoxFrequencyResponseLevel; 
        internal System.Windows.Forms.Label Label9; 
        internal System.Windows.Forms.Label Label5; 
        internal System.Windows.Forms.Label Label6; 
        internal System.Windows.Forms.TextBox TextBoxFrequencyResponseStopFrequency; 
        internal System.Windows.Forms.TextBox TextBoxFrequencyResponseStartFrequency; 
        internal System.Windows.Forms.NumericUpDown NumericUpDownSteeppedFrequencySwepPoints; 
        internal System.Windows.Forms.TextBox TextBoxSteppedFrequencySweepLevel; 
        internal System.Windows.Forms.Label Label7; 
        internal System.Windows.Forms.TextBox TextBoxSteppedFrequencySweepStartFrequency; 
        internal System.Windows.Forms.Label Label8; 
        internal System.Windows.Forms.TextBox TextBoxSteppedFrequencySweepStopFrequency; 
        internal System.Windows.Forms.Label Label11; 
        internal System.Windows.Forms.Label Label10; 
        internal System.Windows.Forms.TabControl TabControl1; 
        internal System.Windows.Forms.TabPage TabPage1; 
        internal System.Windows.Forms.TabPage TabPage2; 
    } 
} 
