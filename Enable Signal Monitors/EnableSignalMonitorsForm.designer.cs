namespace APx500_Samples
{
    partial class Form1 
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
			this.ButtonEnableSignalMonitors = new System.Windows.Forms.Button();
			this.ButtonDisableSignalMonitors = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonEnableSignalMonitors
			// 
			this.ButtonEnableSignalMonitors.Location = new System.Drawing.Point(77, 12);
			this.ButtonEnableSignalMonitors.Name = "ButtonEnableSignalMonitors";
			this.ButtonEnableSignalMonitors.Size = new System.Drawing.Size(183, 23);
			this.ButtonEnableSignalMonitors.TabIndex = 0;
			this.ButtonEnableSignalMonitors.Text = "Enable Signal Monitors";
			this.ButtonEnableSignalMonitors.UseVisualStyleBackColor = true;
			this.ButtonEnableSignalMonitors.Click += new System.EventHandler(this.ButtonEnableSignalMonitors_Click);
			// 
			// ButtonDisableSignalMonitors
			// 
			this.ButtonDisableSignalMonitors.Location = new System.Drawing.Point(77, 41);
			this.ButtonDisableSignalMonitors.Name = "ButtonDisableSignalMonitors";
			this.ButtonDisableSignalMonitors.Size = new System.Drawing.Size(183, 23);
			this.ButtonDisableSignalMonitors.TabIndex = 0;
			this.ButtonDisableSignalMonitors.Text = "Disable Signal Monitors";
			this.ButtonDisableSignalMonitors.UseVisualStyleBackColor = true;
			this.ButtonDisableSignalMonitors.Click += new System.EventHandler(this.ButtonDisableSignalMonitors_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 73);
			this.Controls.Add(this.ButtonDisableSignalMonitors);
			this.Controls.Add(this.ButtonEnableSignalMonitors);
			this.Name = "Form1";
			this.Text = "Enable/Disable Signal Monitors";
			this.ResumeLayout(false);

        } 
        
        internal System.Windows.Forms.Button ButtonEnableSignalMonitors; 
        internal System.Windows.Forms.Button ButtonDisableSignalMonitors; 
        
    } 
    
    
} 
