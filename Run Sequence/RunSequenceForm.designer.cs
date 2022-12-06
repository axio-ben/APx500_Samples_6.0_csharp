namespace APx500_Samples
{
    partial class RunSequenceForm 
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
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBoxProjectFile = new System.Windows.Forms.TextBox();
			this.ButtonBrowse = new System.Windows.Forms.Button();
			this.ButtonRunSequence = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.LabelResult = new System.Windows.Forms.Label();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(62, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Project File:";
			// 
			// TextBoxProjectFile
			// 
			this.TextBoxProjectFile.Location = new System.Drawing.Point(80, 9);
			this.TextBoxProjectFile.Name = "TextBoxProjectFile";
			this.TextBoxProjectFile.ReadOnly = true;
			this.TextBoxProjectFile.Size = new System.Drawing.Size(329, 20);
			this.TextBoxProjectFile.TabIndex = 1;
			// 
			// ButtonBrowse
			// 
			this.ButtonBrowse.Location = new System.Drawing.Point(415, 9);
			this.ButtonBrowse.Name = "ButtonBrowse";
			this.ButtonBrowse.Size = new System.Drawing.Size(75, 20);
			this.ButtonBrowse.TabIndex = 2;
			this.ButtonBrowse.Text = "Browse...";
			this.ButtonBrowse.UseVisualStyleBackColor = true;
			this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// ButtonRunSequence
			// 
			this.ButtonRunSequence.Location = new System.Drawing.Point(80, 35);
			this.ButtonRunSequence.Name = "ButtonRunSequence";
			this.ButtonRunSequence.Size = new System.Drawing.Size(142, 23);
			this.ButtonRunSequence.TabIndex = 3;
			this.ButtonRunSequence.Text = "Run Sequence";
			this.ButtonRunSequence.UseVisualStyleBackColor = true;
			this.ButtonRunSequence.Click += new System.EventHandler(this.ButtonRunSequence_Click);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(35, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Result:";
			// 
			// LabelResult
			// 
			this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelResult.Location = new System.Drawing.Point(80, 69);
			this.LabelResult.Name = "LabelResult";
			this.LabelResult.Size = new System.Drawing.Size(100, 20);
			this.LabelResult.TabIndex = 5;
			this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.DefaultExt = "approj";
			this.OpenFileDialog1.Filter = "APx500 Project Files(*.approj,*.approjx)|*.approj;*.approjx";
			this.OpenFileDialog1.Title = "Open Project File";
			// 
			// RunSequenceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 98);
			this.Controls.Add(this.LabelResult);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.ButtonRunSequence);
			this.Controls.Add(this.ButtonBrowse);
			this.Controls.Add(this.TextBoxProjectFile);
			this.Controls.Add(this.Label1);
			this.Name = "RunSequenceForm";
			this.Text = "Run Sequence";
			this.ResumeLayout(false);
			this.PerformLayout();

        } 
        
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.TextBox TextBoxProjectFile; 
        internal System.Windows.Forms.Button ButtonBrowse; 
        internal System.Windows.Forms.Button ButtonRunSequence; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.Label LabelResult; 
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1; 
        
    } 
    
    
} 
