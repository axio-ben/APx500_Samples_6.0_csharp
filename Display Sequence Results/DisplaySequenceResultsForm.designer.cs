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
			this.ButtonRunSequence = new System.Windows.Forms.Button();
			this.ButtonCustomSequence = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Splitter1 = new System.Windows.Forms.Splitter();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBoxProjectFile = new System.Windows.Forms.TextBox();
			this.ButtonOpenProject = new System.Windows.Forms.Button();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonRunSequence
			// 
			this.ButtonRunSequence.Location = new System.Drawing.Point(12, 43);
			this.ButtonRunSequence.Name = "ButtonRunSequence";
			this.ButtonRunSequence.Size = new System.Drawing.Size(144, 23);
			this.ButtonRunSequence.TabIndex = 0;
			this.ButtonRunSequence.Text = "Run Sequence";
			this.ButtonRunSequence.UseVisualStyleBackColor = true;
			this.ButtonRunSequence.Click += new System.EventHandler(this.ButtonRunSequence_Click);
			// 
			// ButtonCustomSequence
			// 
			this.ButtonCustomSequence.Location = new System.Drawing.Point(162, 43);
			this.ButtonCustomSequence.Name = "ButtonCustomSequence";
			this.ButtonCustomSequence.Size = new System.Drawing.Size(144, 23);
			this.ButtonCustomSequence.TabIndex = 0;
			this.ButtonCustomSequence.Text = "Custom Sequence";
			this.ButtonCustomSequence.UseVisualStyleBackColor = true;
			this.ButtonCustomSequence.Click += new System.EventHandler(this.ButtonCustomSequence_Click);
			// 
			// DataGridView1
			// 
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new System.Drawing.Point(210, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(502, 465);
			this.DataGridView1.TabIndex = 1;
			// 
			// TreeView1
			// 
			this.TreeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.TreeView1.Location = new System.Drawing.Point(0, 0);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new System.Drawing.Size(210, 465);
			this.TreeView1.TabIndex = 2;
			this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.Splitter1);
			this.Panel1.Controls.Add(this.DataGridView1);
			this.Panel1.Controls.Add(this.TreeView1);
			this.Panel1.Location = new System.Drawing.Point(12, 72);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(716, 469);
			this.Panel1.TabIndex = 3;
			// 
			// Splitter1
			// 
			this.Splitter1.Location = new System.Drawing.Point(210, 0);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new System.Drawing.Size(3, 465);
			this.Splitter1.TabIndex = 3;
			this.Splitter1.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(62, 13);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Project File:";
			// 
			// TextBoxProjectFile
			// 
			this.TextBoxProjectFile.Location = new System.Drawing.Point(80, 10);
			this.TextBoxProjectFile.Name = "TextBoxProjectFile";
			this.TextBoxProjectFile.ReadOnly = true;
			this.TextBoxProjectFile.Size = new System.Drawing.Size(521, 20);
			this.TextBoxProjectFile.TabIndex = 5;
			// 
			// ButtonOpenProject
			// 
			this.ButtonOpenProject.Location = new System.Drawing.Point(607, 10);
			this.ButtonOpenProject.Name = "ButtonOpenProject";
			this.ButtonOpenProject.Size = new System.Drawing.Size(75, 20);
			this.ButtonOpenProject.TabIndex = 6;
			this.ButtonOpenProject.Text = "Browse...";
			this.ButtonOpenProject.UseVisualStyleBackColor = true;
			this.ButtonOpenProject.Click += new System.EventHandler(this.ButtonOpenProject_Click);
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.DefaultExt = "approj";
			this.OpenFileDialog1.Filter = "APx500 Project Files(*.approj,*.approjx)|*.approj;*.approjx";
			this.OpenFileDialog1.Title = "Open APx Project File";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 553);
			this.Controls.Add(this.ButtonOpenProject);
			this.Controls.Add(this.TextBoxProjectFile);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ButtonCustomSequence);
			this.Controls.Add(this.ButtonRunSequence);
			this.Name = "Form1";
			this.Text = "Sequence Results API Example";
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal System.Windows.Forms.Button ButtonRunSequence;
		internal System.Windows.Forms.Button ButtonCustomSequence;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TreeView TreeView1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Splitter Splitter1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBoxProjectFile;
		internal System.Windows.Forms.Button ButtonOpenProject;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;

	}
} 
