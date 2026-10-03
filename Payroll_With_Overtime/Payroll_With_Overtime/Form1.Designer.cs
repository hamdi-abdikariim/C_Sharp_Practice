namespace Payroll_With_Overtime
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.lblgrosspayoutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.Location = new System.Drawing.Point(100, 35);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(254, 42);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours worked:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayLabel.Location = new System.Drawing.Point(141, 164);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(131, 101);
            this.grossPayLabel.TabIndex = 1;
            this.grossPayLabel.Text = "Gross pay:";
            // 
            // hourlyPayRateLabel
            // 
            this.hourlyPayRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayRateLabel.Location = new System.Drawing.Point(100, 92);
            this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
            this.hourlyPayRateLabel.Size = new System.Drawing.Size(254, 42);
            this.hourlyPayRateLabel.TabIndex = 2;
            this.hourlyPayRateLabel.Text = "Hourly pay rate:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(369, 33);
            this.hoursWorkedTextBox.Multiline = true;
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(310, 44);
            this.hoursWorkedTextBox.TabIndex = 3;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(369, 92);
            this.hourlyPayRateTextBox.Multiline = true;
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(310, 42);
            this.hourlyPayRateTextBox.TabIndex = 4;
            this.hourlyPayRateTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblgrosspayoutput
            // 
            this.lblgrosspayoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspayoutput.Location = new System.Drawing.Point(369, 164);
            this.lblgrosspayoutput.Name = "lblgrosspayoutput";
            this.lblgrosspayoutput.Size = new System.Drawing.Size(322, 46);
            this.lblgrosspayoutput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(53, 317);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(202, 89);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(322, 317);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(202, 89);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(571, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(202, 89);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lblgrosspayoutput);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRateLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label hourlyPayRateLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label lblgrosspayoutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

