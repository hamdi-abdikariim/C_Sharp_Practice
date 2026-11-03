namespace Assignment_SaveFileDialog
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
            this.btnSaveDailog = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSaveDailog
            // 
            this.btnSaveDailog.Location = new System.Drawing.Point(284, 229);
            this.btnSaveDailog.Name = "btnSaveDailog";
            this.btnSaveDailog.Size = new System.Drawing.Size(184, 91);
            this.btnSaveDailog.TabIndex = 0;
            this.btnSaveDailog.Text = "Save Dialog";
            this.btnSaveDailog.UseVisualStyleBackColor = true;
            this.btnSaveDailog.Click += new System.EventHandler(this.btnSaveDailog_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(249, 102);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(293, 84);
            this.txtUserInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnSaveDailog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDailog;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

