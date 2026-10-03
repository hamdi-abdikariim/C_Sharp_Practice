namespace Range_Checker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDecisionTitle = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.lblDecision);
            this.groupBox1.Controls.Add(this.lblDecisionTitle);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.lblInstruction);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range Checker Application";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(28, 52);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(733, 75);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter an integer in the range of 1 through 10";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Location = new System.Drawing.Point(141, 109);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(292, 60);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // lblDecisionTitle
            // 
            this.lblDecisionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisionTitle.Location = new System.Drawing.Point(161, 184);
            this.lblDecisionTitle.Name = "lblDecisionTitle";
            this.lblDecisionTitle.Size = new System.Drawing.Size(427, 73);
            this.lblDecisionTitle.TabIndex = 3;
            this.lblDecisionTitle.Text = "Range Decision";
            // 
            // lblDecision
            // 
            this.lblDecision.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecision.Location = new System.Drawing.Point(55, 245);
            this.lblDecision.Multiline = true;
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(533, 79);
            this.lblDecision.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCheck.Location = new System.Drawing.Point(141, 392);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(262, 157);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "&Check Qualification";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClear.Location = new System.Drawing.Point(483, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 66);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExit.Location = new System.Drawing.Point(483, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 75);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 733);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Range_Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblDecisionTitle;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox lblDecision;
    }
}

