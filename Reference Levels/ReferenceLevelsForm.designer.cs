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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ButtonSetdBrGToGeneratorValue = new System.Windows.Forms.Button();
			this.ButtonSetdBrGValue = new System.Windows.Forms.Button();
			this.TextBoxdBrGValue = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.ButtonSetdBrBToMeterValue = new System.Windows.Forms.Button();
			this.ButtonSetdBrAToMeterValue = new System.Windows.Forms.Button();
			this.ButtonSetdBrB = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.ButtonSetdBrA = new System.Windows.Forms.Button();
			this.TextBoxdBrBValue = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBoxdBrAValue = new System.Windows.Forms.TextBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.ButtonGetdBrValues = new System.Windows.Forms.Button();
			this.LabeldBrB = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.LabeldBrA = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.ButtonSetdBrGToGeneratorValue);
			this.GroupBox1.Controls.Add(this.ButtonSetdBrGValue);
			this.GroupBox1.Controls.Add(this.TextBoxdBrGValue);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(273, 90);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Set dBrG";
			// 
			// ButtonSetdBrGToGeneratorValue
			// 
			this.ButtonSetdBrGToGeneratorValue.Location = new System.Drawing.Point(6, 54);
			this.ButtonSetdBrGToGeneratorValue.Name = "ButtonSetdBrGToGeneratorValue";
			this.ButtonSetdBrGToGeneratorValue.Size = new System.Drawing.Size(251, 23);
			this.ButtonSetdBrGToGeneratorValue.TabIndex = 3;
			this.ButtonSetdBrGToGeneratorValue.Text = "Set dBrG to Level Generator Ch1";
			this.ButtonSetdBrGToGeneratorValue.UseVisualStyleBackColor = true;
			this.ButtonSetdBrGToGeneratorValue.Click += new System.EventHandler(this.ButtonSetdBrGToGeneratorValue_Click);
			// 
			// ButtonSetdBrGValue
			// 
			this.ButtonSetdBrGValue.Location = new System.Drawing.Point(182, 19);
			this.ButtonSetdBrGValue.Name = "ButtonSetdBrGValue";
			this.ButtonSetdBrGValue.Size = new System.Drawing.Size(75, 20);
			this.ButtonSetdBrGValue.TabIndex = 2;
			this.ButtonSetdBrGValue.Text = "Set dBrG";
			this.ButtonSetdBrGValue.UseVisualStyleBackColor = true;
			this.ButtonSetdBrGValue.Click += new System.EventHandler(this.ButtonSetdBrGValue_Click);
			// 
			// TextBoxdBrGValue
			// 
			this.TextBoxdBrGValue.Location = new System.Drawing.Point(76, 19);
			this.TextBoxdBrGValue.Name = "TextBoxdBrGValue";
			this.TextBoxdBrGValue.Size = new System.Drawing.Size(100, 20);
			this.TextBoxdBrGValue.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "dBrG Value:";
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.ButtonSetdBrBToMeterValue);
			this.GroupBox2.Controls.Add(this.ButtonSetdBrAToMeterValue);
			this.GroupBox2.Controls.Add(this.ButtonSetdBrB);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.ButtonSetdBrA);
			this.GroupBox2.Controls.Add(this.TextBoxdBrBValue);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.TextBoxdBrAValue);
			this.GroupBox2.Location = new System.Drawing.Point(12, 127);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(273, 153);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Set dBrA / dBrB";
			// 
			// ButtonSetdBrBToMeterValue
			// 
			this.ButtonSetdBrBToMeterValue.Location = new System.Drawing.Point(6, 115);
			this.ButtonSetdBrBToMeterValue.Name = "ButtonSetdBrBToMeterValue";
			this.ButtonSetdBrBToMeterValue.Size = new System.Drawing.Size(251, 23);
			this.ButtonSetdBrBToMeterValue.TabIndex = 3;
			this.ButtonSetdBrBToMeterValue.Text = "Set dBrB to Rms Level Ch1";
			this.ButtonSetdBrBToMeterValue.UseVisualStyleBackColor = true;
			this.ButtonSetdBrBToMeterValue.Click += new System.EventHandler(this.ButtonSetdBrBToMeterValue_Click);
			// 
			// ButtonSetdBrAToMeterValue
			// 
			this.ButtonSetdBrAToMeterValue.Location = new System.Drawing.Point(6, 45);
			this.ButtonSetdBrAToMeterValue.Name = "ButtonSetdBrAToMeterValue";
			this.ButtonSetdBrAToMeterValue.Size = new System.Drawing.Size(251, 23);
			this.ButtonSetdBrAToMeterValue.TabIndex = 3;
			this.ButtonSetdBrAToMeterValue.Text = "Set dBrA to Rms Level Ch1";
			this.ButtonSetdBrAToMeterValue.UseVisualStyleBackColor = true;
			this.ButtonSetdBrAToMeterValue.Click += new System.EventHandler(this.ButtonSetdBrAToMeterValue_Click);
			// 
			// ButtonSetdBrB
			// 
			this.ButtonSetdBrB.Location = new System.Drawing.Point(182, 89);
			this.ButtonSetdBrB.Name = "ButtonSetdBrB";
			this.ButtonSetdBrB.Size = new System.Drawing.Size(75, 20);
			this.ButtonSetdBrB.TabIndex = 2;
			this.ButtonSetdBrB.Text = "Set dBrB";
			this.ButtonSetdBrB.UseVisualStyleBackColor = true;
			this.ButtonSetdBrB.Click += new System.EventHandler(this.ButtonSetdBrB_Click);
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 92);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(63, 13);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "dBrB Value:";
			// 
			// ButtonSetdBrA
			// 
			this.ButtonSetdBrA.Location = new System.Drawing.Point(182, 19);
			this.ButtonSetdBrA.Name = "ButtonSetdBrA";
			this.ButtonSetdBrA.Size = new System.Drawing.Size(75, 20);
			this.ButtonSetdBrA.TabIndex = 2;
			this.ButtonSetdBrA.Text = "Set dBrA";
			this.ButtonSetdBrA.UseVisualStyleBackColor = true;
			this.ButtonSetdBrA.Click += new System.EventHandler(this.ButtonSetdBrA_Click);
			// 
			// TextBoxdBrBValue
			// 
			this.TextBoxdBrBValue.Location = new System.Drawing.Point(76, 89);
			this.TextBoxdBrBValue.Name = "TextBoxdBrBValue";
			this.TextBoxdBrBValue.Size = new System.Drawing.Size(100, 20);
			this.TextBoxdBrBValue.TabIndex = 1;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(63, 13);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "dBrA Value:";
			// 
			// TextBoxdBrAValue
			// 
			this.TextBoxdBrAValue.Location = new System.Drawing.Point(76, 19);
			this.TextBoxdBrAValue.Name = "TextBoxdBrAValue";
			this.TextBoxdBrAValue.Size = new System.Drawing.Size(100, 20);
			this.TextBoxdBrAValue.TabIndex = 1;
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.ButtonGetdBrValues);
			this.GroupBox3.Controls.Add(this.LabeldBrB);
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.LabeldBrA);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Location = new System.Drawing.Point(12, 305);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(273, 120);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Get dBrA / dBrB Values";
			// 
			// ButtonGetdBrValues
			// 
			this.ButtonGetdBrValues.Location = new System.Drawing.Point(45, 91);
			this.ButtonGetdBrValues.Name = "ButtonGetdBrValues";
			this.ButtonGetdBrValues.Size = new System.Drawing.Size(122, 23);
			this.ButtonGetdBrValues.TabIndex = 2;
			this.ButtonGetdBrValues.Text = "Get dBr Values";
			this.ButtonGetdBrValues.UseVisualStyleBackColor = true;
			this.ButtonGetdBrValues.Click += new System.EventHandler(this.ButtonGetdBrValues_Click);
			// 
			// LabeldBrB
			// 
			this.LabeldBrB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabeldBrB.Location = new System.Drawing.Point(45, 56);
			this.LabeldBrB.Name = "LabeldBrB";
			this.LabeldBrB.Size = new System.Drawing.Size(122, 20);
			this.LabeldBrB.TabIndex = 1;
			this.LabeldBrB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 60);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(33, 13);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "dBrB:";
			// 
			// LabeldBrA
			// 
			this.LabeldBrA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabeldBrA.Location = new System.Drawing.Point(45, 26);
			this.LabeldBrA.Name = "LabeldBrA";
			this.LabeldBrA.Size = new System.Drawing.Size(122, 20);
			this.LabeldBrA.TabIndex = 1;
			this.LabeldBrA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 30);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(33, 13);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "dBrA:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 442);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Name = "Form1";
			this.Text = "Reference Levels";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);

        } 
        
        internal System.Windows.Forms.GroupBox GroupBox1; 
        internal System.Windows.Forms.Button ButtonSetdBrGToGeneratorValue; 
        internal System.Windows.Forms.Button ButtonSetdBrGValue; 
        internal System.Windows.Forms.TextBox TextBoxdBrGValue; 
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.GroupBox GroupBox2; 
        internal System.Windows.Forms.Button ButtonSetdBrB; 
        internal System.Windows.Forms.Label Label3; 
        internal System.Windows.Forms.Button ButtonSetdBrA; 
        internal System.Windows.Forms.TextBox TextBoxdBrBValue; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.TextBox TextBoxdBrAValue; 
        internal System.Windows.Forms.Button ButtonSetdBrAToMeterValue; 
        internal System.Windows.Forms.Button ButtonSetdBrBToMeterValue; 
        internal System.Windows.Forms.GroupBox GroupBox3; 
        internal System.Windows.Forms.Button ButtonGetdBrValues; 
        internal System.Windows.Forms.Label LabeldBrB; 
        internal System.Windows.Forms.Label Label5; 
        internal System.Windows.Forms.Label LabeldBrA; 
        internal System.Windows.Forms.Label Label4; 
        
    } 
    
    
} 
