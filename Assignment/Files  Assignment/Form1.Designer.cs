namespace Files__Assignment
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
            this.btnReadingotherFuction = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDeleteItemOftheFile = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReadingotherFuction
            // 
            this.btnReadingotherFuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingotherFuction.Location = new System.Drawing.Point(64, 322);
            this.btnReadingotherFuction.Name = "btnReadingotherFuction";
            this.btnReadingotherFuction.Size = new System.Drawing.Size(174, 81);
            this.btnReadingotherFuction.TabIndex = 0;
            this.btnReadingotherFuction.Text = "Reading other fuction";
            this.btnReadingotherFuction.UseVisualStyleBackColor = true;
            this.btnReadingotherFuction.Click += new System.EventHandler(this.btnReadingotherFuction_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(291, 322);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(174, 81);
            this.btnDeleteFile.TabIndex = 1;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItemOftheFile
            // 
            this.btnDeleteItemOftheFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItemOftheFile.Location = new System.Drawing.Point(527, 322);
            this.btnDeleteItemOftheFile.Name = "btnDeleteItemOftheFile";
            this.btnDeleteItemOftheFile.Size = new System.Drawing.Size(174, 81);
            this.btnDeleteItemOftheFile.TabIndex = 2;
            this.btnDeleteItemOftheFile.Text = "Delete Item Of the File";
            this.btnDeleteItemOftheFile.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 20;
            this.lstDisplay.Location = new System.Drawing.Point(755, 98);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(293, 304);
            this.lstDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 566);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDeleteItemOftheFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnReadingotherFuction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadingotherFuction;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDeleteItemOftheFile;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}

