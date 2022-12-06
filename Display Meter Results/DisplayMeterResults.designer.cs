namespace APx500_Samples
{
    partial class DisplayMeterResults
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
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridView1
			// 
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Channel,
            this.Value});
			this.DataGridView1.Location = new System.Drawing.Point(12, 71);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(253, 224);
			this.DataGridView1.TabIndex = 0;
			// 
			// Channel
			// 
			this.Channel.HeaderText = "Channel";
			this.Channel.Name = "Channel";
			this.Channel.ReadOnly = true;
			// 
			// Value
			// 
			this.Value.HeaderText = "Value";
			this.Value.Name = "Value";
			this.Value.ReadOnly = true;
			// 
			// ComboBox1
			// 
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {
            "RMS Level",
            "Signal to Noise Ratio"});
			this.ComboBox1.Location = new System.Drawing.Point(93, 13);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 21);
			this.ComboBox1.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(13, 17);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(74, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Measurement:";
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(12, 40);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(253, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Display Results";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// DisplayMeterResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 307);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.DataGridView1);
			this.Name = "DisplayMeterResults";
			this.Text = "Display Meter Results";
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        } 
        
        internal System.Windows.Forms.DataGridView DataGridView1; 
        internal System.Windows.Forms.DataGridViewTextBoxColumn Channel; 
        internal System.Windows.Forms.DataGridViewTextBoxColumn Value; 
        internal System.Windows.Forms.ComboBox ComboBox1; 
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.Button Button1; 
        
    } 
    
    
} 
