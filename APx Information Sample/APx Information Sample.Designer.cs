namespace APx_Information_Sample
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
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.ListBoxOptions = new System.Windows.Forms.ListBox();
			this.HardwareVersionTextBox = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.SoftwareVersionTextBox = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GetInfoButton = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.ListBoxOptions);
			this.GroupBox3.Location = new System.Drawing.Point(11, 125);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(200, 86);
			this.GroupBox3.TabIndex = 9;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Installed Options";
			// 
			// ListBoxOptions
			// 
			this.ListBoxOptions.FormattingEnabled = true;
			this.ListBoxOptions.Location = new System.Drawing.Point(6, 20);
			this.ListBoxOptions.Name = "ListBoxOptions";
			this.ListBoxOptions.Size = new System.Drawing.Size(188, 56);
			this.ListBoxOptions.TabIndex = 0;
			// 
			// HardwareVersionTextBox
			// 
			this.HardwareVersionTextBox.Location = new System.Drawing.Point(6, 19);
			this.HardwareVersionTextBox.Name = "HardwareVersionTextBox";
			this.HardwareVersionTextBox.ReadOnly = true;
			this.HardwareVersionTextBox.Size = new System.Drawing.Size(180, 20);
			this.HardwareVersionTextBox.TabIndex = 0;
			this.HardwareVersionTextBox.Text = "...";
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.HardwareVersionTextBox);
			this.GroupBox2.Location = new System.Drawing.Point(11, 69);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(195, 50);
			this.GroupBox2.TabIndex = 8;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Analyzer Hardware Serial Number";
			// 
			// SoftwareVersionTextBox
			// 
			this.SoftwareVersionTextBox.Location = new System.Drawing.Point(6, 19);
			this.SoftwareVersionTextBox.Name = "SoftwareVersionTextBox";
			this.SoftwareVersionTextBox.ReadOnly = true;
			this.SoftwareVersionTextBox.Size = new System.Drawing.Size(180, 20);
			this.SoftwareVersionTextBox.TabIndex = 0;
			this.SoftwareVersionTextBox.Text = "...";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.SoftwareVersionTextBox);
			this.GroupBox1.Location = new System.Drawing.Point(11, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(195, 50);
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "APx500 Software Version";
			// 
			// GetInfoButton
			// 
			this.GetInfoButton.Location = new System.Drawing.Point(73, 217);
			this.GetInfoButton.Name = "GetInfoButton";
			this.GetInfoButton.Size = new System.Drawing.Size(75, 23);
			this.GetInfoButton.TabIndex = 6;
			this.GetInfoButton.Text = "Get APx Info";
			this.GetInfoButton.UseVisualStyleBackColor = true;
			this.GetInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 252);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GetInfoButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "APx Information Sample";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.ListBox ListBoxOptions;
		internal System.Windows.Forms.TextBox HardwareVersionTextBox;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.TextBox SoftwareVersionTextBox;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button GetInfoButton;
	}
}

