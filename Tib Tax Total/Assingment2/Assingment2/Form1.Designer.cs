namespace Assingment2
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtfoodprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtfoodprice2 = new System.Windows.Forms.TextBox();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblfoodprice1 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblfoodprice2 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lbldisplaysalary = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood1.Location = new System.Drawing.Point(594, 53);
            this.txtfood1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfood1.Multiline = true;
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(297, 45);
            this.txtfood1.TabIndex = 1;
            // 
            // txtfoodprice1
            // 
            this.txtfoodprice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfoodprice1.Location = new System.Drawing.Point(594, 104);
            this.txtfoodprice1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfoodprice1.Multiline = true;
            this.txtfoodprice1.Name = "txtfoodprice1";
            this.txtfoodprice1.Size = new System.Drawing.Size(297, 40);
            this.txtfoodprice1.TabIndex = 2;
            this.txtfoodprice1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood2.Location = new System.Drawing.Point(594, 154);
            this.txtfood2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(297, 52);
            this.txtfood2.TabIndex = 3;
            // 
            // txtfoodprice2
            // 
            this.txtfoodprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfoodprice2.Location = new System.Drawing.Point(594, 213);
            this.txtfoodprice2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfoodprice2.Multiline = true;
            this.txtfoodprice2.Name = "txtfoodprice2";
            this.txtfoodprice2.Size = new System.Drawing.Size(297, 51);
            this.txtfoodprice2.TabIndex = 4;
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(368, 60);
            this.lblfood1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(132, 25);
            this.lblfood1.TabIndex = 5;
            this.lblfood1.Text = "Enter Food 1:";
            // 
            // lblfoodprice1
            // 
            this.lblfoodprice1.AutoSize = true;
            this.lblfoodprice1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodprice1.Location = new System.Drawing.Point(325, 104);
            this.lblfoodprice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfoodprice1.Name = "lblfoodprice1";
            this.lblfoodprice1.Size = new System.Drawing.Size(177, 25);
            this.lblfoodprice1.TabIndex = 7;
            this.lblfoodprice1.Text = "Enter Food Price1:";
            this.lblfoodprice1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood2.Location = new System.Drawing.Point(368, 162);
            this.lblfood2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(132, 25);
            this.lblfood2.TabIndex = 8;
            this.lblfood2.Text = "Enter Food 2:";
            // 
            // lblfoodprice2
            // 
            this.lblfoodprice2.AutoSize = true;
            this.lblfoodprice2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodprice2.Location = new System.Drawing.Point(325, 221);
            this.lblfoodprice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfoodprice2.Name = "lblfoodprice2";
            this.lblfoodprice2.Size = new System.Drawing.Size(177, 25);
            this.lblfoodprice2.TabIndex = 9;
            this.lblfoodprice2.Text = "Enter Food Price2:";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(547, 315);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(297, 88);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(562, 567);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(424, 80);
            this.lbltotal.TabIndex = 11;
            // 
            // lblsalary
            // 
            this.lblsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(562, 468);
            this.lblsalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(424, 72);
            this.lblsalary.TabIndex = 12;
            // 
            // lbldisplaysalary
            // 
            this.lbldisplaysalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaysalary.Location = new System.Drawing.Point(281, 483);
            this.lbldisplaysalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisplaysalary.Name = "lbldisplaysalary";
            this.lbldisplaysalary.Size = new System.Drawing.Size(253, 57);
            this.lbldisplaysalary.TabIndex = 13;
            this.lbldisplaysalary.Text = "Salary Tax is:";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(297, 584);
            this.lbltotalamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(235, 34);
            this.lbltotalamount.TabIndex = 14;
            this.lbltotalamount.Text = "Total Amount";
            this.lbltotalamount.Click += new System.EventHandler(this.lbltotalamount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 701);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbldisplaysalary);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblfoodprice2);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblfoodprice1);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.txtfoodprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfoodprice1);
            this.Controls.Add(this.txtfood1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtfoodprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtfoodprice2;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblfoodprice1;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblfoodprice2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lbldisplaysalary;
        private System.Windows.Forms.Label lbltotalamount;
    }
}

