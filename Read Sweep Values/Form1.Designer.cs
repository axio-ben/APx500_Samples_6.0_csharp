namespace Read_Sweep_Values
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
			this.buttonOpenProject = new System.Windows.Forms.Button();
			this.textBoxProjectFile = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.buttonFrequencyResponse = new System.Windows.Forms.Button();
			this.buttonSteppedFrequencySweep = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// buttonOpenProject
			// 
			this.buttonOpenProject.Location = new System.Drawing.Point(607, 6);
			this.buttonOpenProject.Name = "buttonOpenProject";
			this.buttonOpenProject.Size = new System.Drawing.Size(75, 20);
			this.buttonOpenProject.TabIndex = 12;
			this.buttonOpenProject.Text = "Browse...";
			this.buttonOpenProject.UseVisualStyleBackColor = true;
			this.buttonOpenProject.Click += new System.EventHandler(this.ButtonOpenProject_Click);
			// 
			// textBoxProjectFile
			// 
			this.textBoxProjectFile.Location = new System.Drawing.Point(80, 6);
			this.textBoxProjectFile.Name = "textBoxProjectFile";
			this.textBoxProjectFile.ReadOnly = true;
			this.textBoxProjectFile.Size = new System.Drawing.Size(521, 20);
			this.textBoxProjectFile.TabIndex = 11;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(62, 13);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Project File:";
			// 
			// buttonFrequencyResponse
			// 
			this.buttonFrequencyResponse.Location = new System.Drawing.Point(348, 45);
			this.buttonFrequencyResponse.Name = "buttonFrequencyResponse";
			this.buttonFrequencyResponse.Size = new System.Drawing.Size(186, 23);
			this.buttonFrequencyResponse.TabIndex = 14;
			this.buttonFrequencyResponse.Text = "Run Frequency Response";
			this.buttonFrequencyResponse.UseVisualStyleBackColor = true;
			this.buttonFrequencyResponse.Click += new System.EventHandler(this.buttonFrequencyResponse_Click);
			// 
			// buttonSteppedFrequencySweep
			// 
			this.buttonSteppedFrequencySweep.Location = new System.Drawing.Point(156, 45);
			this.buttonSteppedFrequencySweep.Name = "buttonSteppedFrequencySweep";
			this.buttonSteppedFrequencySweep.Size = new System.Drawing.Size(186, 23);
			this.buttonSteppedFrequencySweep.TabIndex = 13;
			this.buttonSteppedFrequencySweep.Text = "Run Stepped Frequency Sweep";
			this.buttonSteppedFrequencySweep.UseVisualStyleBackColor = true;
			this.buttonSteppedFrequencySweep.Click += new System.EventHandler(this.buttonSteppedFrequencySweep_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "APx500 Project Files(*.approj,*.approjx)|*.approj;*.approjx";
			this.openFileDialog1.Title = "Open Project File";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 80);
			this.Controls.Add(this.buttonFrequencyResponse);
			this.Controls.Add(this.buttonSteppedFrequencySweep);
			this.Controls.Add(this.buttonOpenProject);
			this.Controls.Add(this.textBoxProjectFile);
			this.Controls.Add(this.Label1);
			this.Name = "Form1";
			this.Text = "Read Sweep Values";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button buttonOpenProject;
		internal System.Windows.Forms.TextBox textBoxProjectFile;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button buttonFrequencyResponse;
		internal System.Windows.Forms.Button buttonSteppedFrequencySweep;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

