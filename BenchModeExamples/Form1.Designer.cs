namespace BenchModeExamples
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
            this.components = new System.ComponentModel.Container();
            this.buttonGetSettledReadings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLevelCh1 = new System.Windows.Forms.TextBox();
            this.textBoxLevelCh2 = new System.Windows.Forms.TextBox();
            this.textBoxThdNCh1 = new System.Windows.Forms.TextBox();
            this.textBoxThdNCh2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStartFft = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetSettledReadings
            // 
            this.buttonGetSettledReadings.AutoSize = true;
            this.buttonGetSettledReadings.Location = new System.Drawing.Point(193, 108);
            this.buttonGetSettledReadings.Name = "buttonGetSettledReadings";
            this.buttonGetSettledReadings.Size = new System.Drawing.Size(82, 23);
            this.buttonGetSettledReadings.TabIndex = 1;
            this.buttonGetSettledReadings.Text = "Get Readings";
            this.buttonGetSettledReadings.UseVisualStyleBackColor = true;
            this.buttonGetSettledReadings.Click += new System.EventHandler(this.buttonGetSettledReadings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLevelCh1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLevelCh2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxThdNCh1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxThdNCh2, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonGetSettledReadings, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonStartFft, 2, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 478);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RMS Level (Vrms)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 5);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Settled Meter Readings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(281, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "THD+N Ratio (dB)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ch1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ch2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(281, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ch1:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(281, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ch2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLevelCh1
            // 
            this.textBoxLevelCh1.BackColor = System.Drawing.Color.Black;
            this.textBoxLevelCh1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxLevelCh1.Location = new System.Drawing.Point(38, 56);
            this.textBoxLevelCh1.Name = "textBoxLevelCh1";
            this.textBoxLevelCh1.ReadOnly = true;
            this.textBoxLevelCh1.Size = new System.Drawing.Size(149, 20);
            this.textBoxLevelCh1.TabIndex = 4;
            // 
            // textBoxLevelCh2
            // 
            this.textBoxLevelCh2.BackColor = System.Drawing.Color.Black;
            this.textBoxLevelCh2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxLevelCh2.Location = new System.Drawing.Point(38, 82);
            this.textBoxLevelCh2.Name = "textBoxLevelCh2";
            this.textBoxLevelCh2.ReadOnly = true;
            this.textBoxLevelCh2.Size = new System.Drawing.Size(149, 20);
            this.textBoxLevelCh2.TabIndex = 4;
            // 
            // textBoxThdNCh1
            // 
            this.textBoxThdNCh1.BackColor = System.Drawing.Color.Black;
            this.textBoxThdNCh1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxThdNCh1.Location = new System.Drawing.Point(316, 56);
            this.textBoxThdNCh1.Name = "textBoxThdNCh1";
            this.textBoxThdNCh1.ReadOnly = true;
            this.textBoxThdNCh1.Size = new System.Drawing.Size(149, 20);
            this.textBoxThdNCh1.TabIndex = 4;
            // 
            // textBoxThdNCh2
            // 
            this.textBoxThdNCh2.BackColor = System.Drawing.Color.Black;
            this.textBoxThdNCh2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxThdNCh2.Location = new System.Drawing.Point(316, 82);
            this.textBoxThdNCh2.Name = "textBoxThdNCh2";
            this.textBoxThdNCh2.ReadOnly = true;
            this.textBoxThdNCh2.Size = new System.Drawing.Size(149, 20);
            this.textBoxThdNCh2.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 5);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Get FFT Values";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView1, 6);
            this.DataGridView1.Location = new System.Drawing.Point(3, 177);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(535, 269);
            this.DataGridView1.TabIndex = 3;
            // 
            // buttonStartFft
            // 
            this.buttonStartFft.AutoSize = true;
            this.buttonStartFft.Location = new System.Drawing.Point(193, 452);
            this.buttonStartFft.Name = "buttonStartFft";
            this.buttonStartFft.Size = new System.Drawing.Size(82, 23);
            this.buttonStartFft.TabIndex = 1;
            this.buttonStartFft.Text = "Start FFT";
            this.buttonStartFft.UseVisualStyleBackColor = true;
            this.buttonStartFft.Click += new System.EventHandler(this.buttonStartFft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Bench Mode Examples";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetSettledReadings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLevelCh1;
        private System.Windows.Forms.TextBox textBoxLevelCh2;
        private System.Windows.Forms.TextBox textBoxThdNCh1;
        private System.Windows.Forms.TextBox textBoxThdNCh2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button buttonStartFft;
    }
}

