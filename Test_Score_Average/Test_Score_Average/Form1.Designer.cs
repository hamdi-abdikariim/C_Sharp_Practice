namespace Test_Score_Average
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTest1.Location = new System.Drawing.Point(66, 90);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(231, 57);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test Score #1:";
            // 
            // lblTest3
            // 
            this.lblTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTest3.Location = new System.Drawing.Point(66, 215);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(231, 57);
            this.lblTest3.TabIndex = 1;
            this.lblTest3.Text = "Test Score #3:";
            this.lblTest3.Click += new System.EventHandler(this.lblTest3_Click);
            // 
            // lblTest2
            // 
            this.lblTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTest2.Location = new System.Drawing.Point(66, 149);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(231, 57);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "Test Score #2:";
            this.lblTest2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAverage.Location = new System.Drawing.Point(66, 289);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(231, 57);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            this.lblAverage.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(369, 81);
            this.txtScore1.Multiline = true;
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(220, 43);
            this.txtScore1.TabIndex = 4;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(369, 153);
            this.txtScore2.Multiline = true;
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(220, 37);
            this.txtScore2.TabIndex = 5;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(369, 215);
            this.txtScore3.Multiline = true;
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(220, 43);
            this.txtScore3.TabIndex = 6;
            this.txtScore3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(234, 470);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 117);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(540, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(219, 65);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(540, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 65);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.ForeColor = System.Drawing.Color.Black;
            this.lbloutput.Location = new System.Drawing.Point(369, 288);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(231, 57);
            this.lbloutput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTest2);
            this.groupBox1.Controls.Add(this.lbloutput);
            this.groupBox1.Controls.Add(this.lblTest1);
            this.groupBox1.Controls.Add(this.lblTest3);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.txtScore1);
            this.groupBox1.Controls.Add(this.txtScore3);
            this.groupBox1.Controls.Add(this.txtScore2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(147, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 385);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Three Test Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

