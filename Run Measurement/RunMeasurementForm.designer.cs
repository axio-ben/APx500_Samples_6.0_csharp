namespace APx500_Samples
{
    partial class RunMeasurementForm
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
			this.LabelResult = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ButtonLevelAndGain = new System.Windows.Forms.Button();
			this.ButtonFrequencyResponse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LabelResult
			// 
			this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelResult.Location = new System.Drawing.Point(119, 76);
			this.LabelResult.Name = "LabelResult";
			this.LabelResult.Size = new System.Drawing.Size(100, 20);
			this.LabelResult.TabIndex = 11;
			this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(74, 80);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 13);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Result:";
			// 
			// ButtonLevelAndGain
			// 
			this.ButtonLevelAndGain.Location = new System.Drawing.Point(42, 12);
			this.ButtonLevelAndGain.Name = "ButtonLevelAndGain";
			this.ButtonLevelAndGain.Size = new System.Drawing.Size(219, 23);
			this.ButtonLevelAndGain.TabIndex = 9;
			this.ButtonLevelAndGain.Text = "Run Level and Gain Measurement";
			this.ButtonLevelAndGain.UseVisualStyleBackColor = true;
			this.ButtonLevelAndGain.Click += new System.EventHandler(this.ButtonLevelAndGain_Click);
			// 
			// ButtonFrequencyResponse
			// 
			this.ButtonFrequencyResponse.Location = new System.Drawing.Point(42, 41);
			this.ButtonFrequencyResponse.Name = "ButtonFrequencyResponse";
			this.ButtonFrequencyResponse.Size = new System.Drawing.Size(219, 23);
			this.ButtonFrequencyResponse.TabIndex = 9;
			this.ButtonFrequencyResponse.Text = "Run Frequency Response Measurement";
			this.ButtonFrequencyResponse.UseVisualStyleBackColor = true;
			this.ButtonFrequencyResponse.Click += new System.EventHandler(this.ButtonFrequencyResponse_Click);
			// 
			// RunMeasurementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 105);
			this.Controls.Add(this.LabelResult);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.ButtonFrequencyResponse);
			this.Controls.Add(this.ButtonLevelAndGain);
			this.Name = "RunMeasurementForm";
			this.Text = "Run Measurement";
			this.ResumeLayout(false);
			this.PerformLayout();

        } 
        
        internal System.Windows.Forms.Label LabelResult; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.Button ButtonLevelAndGain; 
        internal System.Windows.Forms.Button ButtonFrequencyResponse; 
        
    } 
    
    
} 
