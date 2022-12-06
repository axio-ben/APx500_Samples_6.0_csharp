namespace Export_Sample
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
			this.ExportCustomTextButton = new System.Windows.Forms.Button();
			this.ExportPdfButton = new System.Windows.Forms.Button();
			this.ExportCsvButton = new System.Windows.Forms.Button();
			this.RunTestButton = new System.Windows.Forms.Button();
			this.LoadProjectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ExportCustomTextButton
			// 
			this.ExportCustomTextButton.Location = new System.Drawing.Point(12, 130);
			this.ExportCustomTextButton.Name = "ExportCustomTextButton";
			this.ExportCustomTextButton.Size = new System.Drawing.Size(168, 23);
			this.ExportCustomTextButton.TabIndex = 9;
			this.ExportCustomTextButton.Text = "Export Custom Text";
			this.ExportCustomTextButton.UseVisualStyleBackColor = true;
			this.ExportCustomTextButton.Click += new System.EventHandler(this.ExportCustomTextButton_Click);
			// 
			// ExportPdfButton
			// 
			this.ExportPdfButton.Location = new System.Drawing.Point(12, 101);
			this.ExportPdfButton.Name = "ExportPdfButton";
			this.ExportPdfButton.Size = new System.Drawing.Size(168, 23);
			this.ExportPdfButton.TabIndex = 8;
			this.ExportPdfButton.Text = "Export Report in PDF Format";
			this.ExportPdfButton.UseVisualStyleBackColor = true;
			this.ExportPdfButton.Click += new System.EventHandler(this.ExportPdfButton_Click);
			// 
			// ExportCsvButton
			// 
			this.ExportCsvButton.Location = new System.Drawing.Point(12, 72);
			this.ExportCsvButton.Name = "ExportCsvButton";
			this.ExportCsvButton.Size = new System.Drawing.Size(168, 23);
			this.ExportCsvButton.TabIndex = 7;
			this.ExportCsvButton.Text = "Export Report in CSV Format";
			this.ExportCsvButton.UseVisualStyleBackColor = true;
			this.ExportCsvButton.Click += new System.EventHandler(this.ExportCsvButton_Click);
			// 
			// RunTestButton
			// 
			this.RunTestButton.Location = new System.Drawing.Point(12, 43);
			this.RunTestButton.Name = "RunTestButton";
			this.RunTestButton.Size = new System.Drawing.Size(168, 23);
			this.RunTestButton.TabIndex = 6;
			this.RunTestButton.Text = "Run Test Sequence";
			this.RunTestButton.UseVisualStyleBackColor = true;
			this.RunTestButton.Click += new System.EventHandler(this.RunTestButton_Click);
			// 
			// LoadProjectButton
			// 
			this.LoadProjectButton.Location = new System.Drawing.Point(12, 14);
			this.LoadProjectButton.Name = "LoadProjectButton";
			this.LoadProjectButton.Size = new System.Drawing.Size(168, 23);
			this.LoadProjectButton.TabIndex = 5;
			this.LoadProjectButton.Text = "Load Project File";
			this.LoadProjectButton.UseVisualStyleBackColor = true;
			this.LoadProjectButton.Click += new System.EventHandler(this.LoadProjectButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(192, 166);
			this.Controls.Add(this.ExportCustomTextButton);
			this.Controls.Add(this.ExportPdfButton);
			this.Controls.Add(this.ExportCsvButton);
			this.Controls.Add(this.RunTestButton);
			this.Controls.Add(this.LoadProjectButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Export Sample";
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button ExportCustomTextButton;
		internal System.Windows.Forms.Button ExportPdfButton;
		internal System.Windows.Forms.Button ExportCsvButton;
		internal System.Windows.Forms.Button RunTestButton;
		internal System.Windows.Forms.Button LoadProjectButton;
	}
}

