namespace APx500_Samples
{
    partial class ConfigureSwitchersForm 
    { 
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ButtonSaveOutput = new System.Windows.Forms.Button();
			this.ButtonOpenOutput = new System.Windows.Forms.Button();
			this.ButtonOutputSwitcher = new System.Windows.Forms.Button();
			this.ComboBoxOutputChannelB = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.ComboBoxOutputChannelA = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.NumericUpDownOutputChannel = new System.Windows.Forms.NumericUpDown();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.ButtonSaveInput = new System.Windows.Forms.Button();
			this.ButtonOpenInput = new System.Windows.Forms.Button();
			this.ButtonInputSwitcher = new System.Windows.Forms.Button();
			this.ComboBoxInputChannelB = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ComboBoxInputChannelA = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.NumericUpDownInputChannel = new System.Windows.Forms.NumericUpDown();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOutputChannel)).BeginInit();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputChannel)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.ButtonSaveOutput);
			this.GroupBox1.Controls.Add(this.ButtonOpenOutput);
			this.GroupBox1.Controls.Add(this.ButtonOutputSwitcher);
			this.GroupBox1.Controls.Add(this.ComboBoxOutputChannelB);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.ComboBoxOutputChannelA);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.NumericUpDownOutputChannel);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(235, 175);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Output Switcher";
			// 
			// ButtonSaveOutput
			// 
			this.ButtonSaveOutput.Location = new System.Drawing.Point(96, 143);
			this.ButtonSaveOutput.Name = "ButtonSaveOutput";
			this.ButtonSaveOutput.Size = new System.Drawing.Size(75, 23);
			this.ButtonSaveOutput.TabIndex = 5;
			this.ButtonSaveOutput.Text = "Save";
			this.ButtonSaveOutput.UseVisualStyleBackColor = true;
			this.ButtonSaveOutput.Click += new System.EventHandler(this.ButtonSaveOutput_Click);
			// 
			// ButtonOpenOutput
			// 
			this.ButtonOpenOutput.Location = new System.Drawing.Point(9, 143);
			this.ButtonOpenOutput.Name = "ButtonOpenOutput";
			this.ButtonOpenOutput.Size = new System.Drawing.Size(75, 23);
			this.ButtonOpenOutput.TabIndex = 4;
			this.ButtonOpenOutput.Text = "Open";
			this.ButtonOpenOutput.UseVisualStyleBackColor = true;
			this.ButtonOpenOutput.Click += new System.EventHandler(this.ButtonOpenOutput_Click);
			// 
			// ButtonOutputSwitcher
			// 
			this.ButtonOutputSwitcher.Location = new System.Drawing.Point(9, 103);
			this.ButtonOutputSwitcher.Name = "ButtonOutputSwitcher";
			this.ButtonOutputSwitcher.Size = new System.Drawing.Size(211, 23);
			this.ButtonOutputSwitcher.TabIndex = 3;
			this.ButtonOutputSwitcher.Text = "Set Switcher Configuration";
			this.ButtonOutputSwitcher.UseVisualStyleBackColor = true;
			this.ButtonOutputSwitcher.Click += new System.EventHandler(this.ButtonOutputSwitcher_Click);
			// 
			// ComboBoxOutputChannelB
			// 
			this.ComboBoxOutputChannelB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxOutputChannelB.FormattingEnabled = true;
			this.ComboBoxOutputChannelB.Location = new System.Drawing.Point(119, 76);
			this.ComboBoxOutputChannelB.Name = "ComboBoxOutputChannelB";
			this.ComboBoxOutputChannelB.Size = new System.Drawing.Size(101, 21);
			this.ComboBoxOutputChannelB.TabIndex = 2;
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 79);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(59, 13);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Channel B:";
			// 
			// ComboBoxOutputChannelA
			// 
			this.ComboBoxOutputChannelA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxOutputChannelA.FormattingEnabled = true;
			this.ComboBoxOutputChannelA.Location = new System.Drawing.Point(119, 49);
			this.ComboBoxOutputChannelA.Name = "ComboBoxOutputChannelA";
			this.ComboBoxOutputChannelA.Size = new System.Drawing.Size(101, 21);
			this.ComboBoxOutputChannelA.TabIndex = 2;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 52);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(59, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Channel A:";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 27);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(92, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Switcher Address:";
			// 
			// NumericUpDownOutputChannel
			// 
			this.NumericUpDownOutputChannel.Location = new System.Drawing.Point(119, 23);
			this.NumericUpDownOutputChannel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.NumericUpDownOutputChannel.Name = "NumericUpDownOutputChannel";
			this.NumericUpDownOutputChannel.Size = new System.Drawing.Size(52, 20);
			this.NumericUpDownOutputChannel.TabIndex = 0;
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.ButtonSaveInput);
			this.GroupBox2.Controls.Add(this.ButtonOpenInput);
			this.GroupBox2.Controls.Add(this.ButtonInputSwitcher);
			this.GroupBox2.Controls.Add(this.ComboBoxInputChannelB);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.ComboBoxInputChannelA);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.NumericUpDownInputChannel);
			this.GroupBox2.Location = new System.Drawing.Point(267, 12);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(235, 175);
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Input Switcher";
			// 
			// ButtonSaveInput
			// 
			this.ButtonSaveInput.Location = new System.Drawing.Point(96, 143);
			this.ButtonSaveInput.Name = "ButtonSaveInput";
			this.ButtonSaveInput.Size = new System.Drawing.Size(75, 23);
			this.ButtonSaveInput.TabIndex = 5;
			this.ButtonSaveInput.Text = "Save";
			this.ButtonSaveInput.UseVisualStyleBackColor = true;
			this.ButtonSaveInput.Click += new System.EventHandler(this.ButtonSaveInput_Click);
			// 
			// ButtonOpenInput
			// 
			this.ButtonOpenInput.Location = new System.Drawing.Point(9, 143);
			this.ButtonOpenInput.Name = "ButtonOpenInput";
			this.ButtonOpenInput.Size = new System.Drawing.Size(75, 23);
			this.ButtonOpenInput.TabIndex = 4;
			this.ButtonOpenInput.Text = "Open";
			this.ButtonOpenInput.UseVisualStyleBackColor = true;
			this.ButtonOpenInput.Click += new System.EventHandler(this.ButtonOpenInput_Click);
			// 
			// ButtonInputSwitcher
			// 
			this.ButtonInputSwitcher.Location = new System.Drawing.Point(9, 103);
			this.ButtonInputSwitcher.Name = "ButtonInputSwitcher";
			this.ButtonInputSwitcher.Size = new System.Drawing.Size(211, 23);
			this.ButtonInputSwitcher.TabIndex = 3;
			this.ButtonInputSwitcher.Text = "Set Switcher Configuration";
			this.ButtonInputSwitcher.UseVisualStyleBackColor = true;
			this.ButtonInputSwitcher.Click += new System.EventHandler(this.ButtonInputSwitcher_Click);
			// 
			// ComboBoxInputChannelB
			// 
			this.ComboBoxInputChannelB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxInputChannelB.FormattingEnabled = true;
			this.ComboBoxInputChannelB.Location = new System.Drawing.Point(119, 76);
			this.ComboBoxInputChannelB.Name = "ComboBoxInputChannelB";
			this.ComboBoxInputChannelB.Size = new System.Drawing.Size(101, 21);
			this.ComboBoxInputChannelB.TabIndex = 2;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 79);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(59, 13);
			this.Label4.TabIndex = 1;
			this.Label4.Text = "Channel B:";
			// 
			// ComboBoxInputChannelA
			// 
			this.ComboBoxInputChannelA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxInputChannelA.FormattingEnabled = true;
			this.ComboBoxInputChannelA.Location = new System.Drawing.Point(119, 49);
			this.ComboBoxInputChannelA.Name = "ComboBoxInputChannelA";
			this.ComboBoxInputChannelA.Size = new System.Drawing.Size(101, 21);
			this.ComboBoxInputChannelA.TabIndex = 2;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 52);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(59, 13);
			this.Label5.TabIndex = 1;
			this.Label5.Text = "Channel A:";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(6, 27);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(92, 13);
			this.Label6.TabIndex = 1;
			this.Label6.Text = "Switcher Address:";
			// 
			// NumericUpDownInputChannel
			// 
			this.NumericUpDownInputChannel.Location = new System.Drawing.Point(119, 23);
			this.NumericUpDownInputChannel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.NumericUpDownInputChannel.Name = "NumericUpDownInputChannel";
			this.NumericUpDownInputChannel.Size = new System.Drawing.Size(52, 20);
			this.NumericUpDownInputChannel.TabIndex = 0;
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.Filter = "APx500 Project Files(*.approj,*.approjx)|*.approj;*.approjx";
			this.OpenFileDialog1.Multiselect = true;
			this.OpenFileDialog1.Title = "Import Switcher Configuration";
			// 
			// SaveFileDialog1
			// 
			this.SaveFileDialog1.Title = "Export Switcher Configuration";
			// 
			// ConfigureSwitchersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 203);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Name = "ConfigureSwitchersForm";
			this.Text = "Configure Switchers";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOutputChannel)).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputChannel)).EndInit();
			this.ResumeLayout(false);

        } 
        
        internal System.Windows.Forms.GroupBox GroupBox1; 
        internal System.Windows.Forms.Button ButtonOutputSwitcher; 
        internal System.Windows.Forms.ComboBox ComboBoxOutputChannelB; 
        internal System.Windows.Forms.Label Label3; 
        internal System.Windows.Forms.ComboBox ComboBoxOutputChannelA; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.NumericUpDown NumericUpDownOutputChannel; 
        internal System.Windows.Forms.GroupBox GroupBox2; 
        internal System.Windows.Forms.Button ButtonInputSwitcher; 
        internal System.Windows.Forms.ComboBox ComboBoxInputChannelB; 
        internal System.Windows.Forms.Label Label4; 
        internal System.Windows.Forms.ComboBox ComboBoxInputChannelA; 
        internal System.Windows.Forms.Label Label5; 
        internal System.Windows.Forms.Label Label6; 
        internal System.Windows.Forms.NumericUpDown NumericUpDownInputChannel; 
        internal System.Windows.Forms.Button ButtonSaveOutput; 
        internal System.Windows.Forms.Button ButtonOpenOutput; 
        internal System.Windows.Forms.Button ButtonSaveInput; 
        internal System.Windows.Forms.Button ButtonOpenInput; 
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1; 
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1; 
    } 
} 
