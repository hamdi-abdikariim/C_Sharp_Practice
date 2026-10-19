namespace Vehicle_Rental_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtrentaldays = new System.Windows.Forms.TextBox();
            this.txtdrivingexperiance = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblrentaldays = new System.Windows.Forms.Label();
            this.lblexperiance = new System.Windows.Forms.Label();
            this.lblcustomerage = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.lblvahicle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAddInsurence = new System.Windows.Forms.CheckBox();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.grpPersonalInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(800, 499);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(202, 106);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(625, 932);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(202, 106);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(890, 932);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(202, 106);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpPersonalInfo.Controls.Add(this.txtage);
            this.grpPersonalInfo.Controls.Add(this.txtrentaldays);
            this.grpPersonalInfo.Controls.Add(this.txtdrivingexperiance);
            this.grpPersonalInfo.Controls.Add(this.txtname);
            this.grpPersonalInfo.Controls.Add(this.lblrentaldays);
            this.grpPersonalInfo.Controls.Add(this.lblexperiance);
            this.grpPersonalInfo.Controls.Add(this.lblcustomerage);
            this.grpPersonalInfo.Controls.Add(this.lblcustomer);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grpPersonalInfo.Location = new System.Drawing.Point(29, 70);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(892, 400);
            this.grpPersonalInfo.TabIndex = 15;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Location = new System.Drawing.Point(476, 102);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(342, 44);
            this.txtage.TabIndex = 17;
            // 
            // txtrentaldays
            // 
            this.txtrentaldays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrentaldays.Location = new System.Drawing.Point(476, 158);
            this.txtrentaldays.Multiline = true;
            this.txtrentaldays.Name = "txtrentaldays";
            this.txtrentaldays.Size = new System.Drawing.Size(342, 44);
            this.txtrentaldays.TabIndex = 16;
            // 
            // txtdrivingexperiance
            // 
            this.txtdrivingexperiance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdrivingexperiance.Location = new System.Drawing.Point(476, 209);
            this.txtdrivingexperiance.Multiline = true;
            this.txtdrivingexperiance.Name = "txtdrivingexperiance";
            this.txtdrivingexperiance.Size = new System.Drawing.Size(342, 44);
            this.txtdrivingexperiance.TabIndex = 15;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(476, 45);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(342, 44);
            this.txtname.TabIndex = 14;
            // 
            // lblrentaldays
            // 
            this.lblrentaldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentaldays.Location = new System.Drawing.Point(72, 158);
            this.lblrentaldays.Name = "lblrentaldays";
            this.lblrentaldays.Size = new System.Drawing.Size(336, 37);
            this.lblrentaldays.TabIndex = 13;
            this.lblrentaldays.Text = "Enter Number of Rental Days:";
            // 
            // lblexperiance
            // 
            this.lblexperiance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperiance.Location = new System.Drawing.Point(72, 209);
            this.lblexperiance.Name = "lblexperiance";
            this.lblexperiance.Size = new System.Drawing.Size(419, 34);
            this.lblexperiance.TabIndex = 12;
            this.lblexperiance.Text = "Enter Years Of Driving Experience:";
            // 
            // lblcustomerage
            // 
            this.lblcustomerage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerage.Location = new System.Drawing.Point(72, 102);
            this.lblcustomerage.Name = "lblcustomerage";
            this.lblcustomerage.Size = new System.Drawing.Size(298, 34);
            this.lblcustomerage.TabIndex = 11;
            this.lblcustomerage.Text = "Enter Customer Age:";
            this.lblcustomerage.Click += new System.EventHandler(this.lblcustomerage_Click);
            // 
            // lblcustomer
            // 
            this.lblcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer.Location = new System.Drawing.Point(72, 52);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(270, 37);
            this.lblcustomer.TabIndex = 10;
            this.lblcustomer.Text = "Enter Customer Name:";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rdoluxury);
            this.panel1.Controls.Add(this.rdosuv);
            this.panel1.Controls.Add(this.rdoeconomy);
            this.panel1.Controls.Add(this.lblvahicle);
            this.panel1.Location = new System.Drawing.Point(86, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 282);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(379, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.Location = new System.Drawing.Point(46, 100);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(102, 29);
            this.rdoluxury.TabIndex = 3;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            this.rdoluxury.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.Location = new System.Drawing.Point(231, 100);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(82, 29);
            this.rdosuv.TabIndex = 2;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            this.rdosuv.CheckedChanged += new System.EventHandler(this.rdosuv_CheckedChanged);
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.Location = new System.Drawing.Point(379, 100);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(126, 29);
            this.rdoeconomy.TabIndex = 1;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // lblvahicle
            // 
            this.lblvahicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvahicle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblvahicle.Location = new System.Drawing.Point(14, 13);
            this.lblvahicle.Name = "lblvahicle";
            this.lblvahicle.Size = new System.Drawing.Size(230, 39);
            this.lblvahicle.TabIndex = 0;
            this.lblvahicle.Text = "Vahicle Type";
            this.lblvahicle.Click += new System.EventHandler(this.lblvahicle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAddInsurence);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(141, 774);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insurence Option";
            // 
            // chkAddInsurence
            // 
            this.chkAddInsurence.AutoSize = true;
            this.chkAddInsurence.Location = new System.Drawing.Point(24, 71);
            this.chkAddInsurence.Name = "chkAddInsurence";
            this.chkAddInsurence.Size = new System.Drawing.Size(367, 33);
            this.chkAddInsurence.TabIndex = 0;
            this.chkAddInsurence.Text = "Add insurence ($15 per day)";
            this.chkAddInsurence.UseVisualStyleBackColor = true;
            // 
            // lstresults
            // 
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 20;
            this.lstresults.Location = new System.Drawing.Point(1191, 116);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(604, 504);
            this.lstresults.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 1050);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtrentaldays;
        private System.Windows.Forms.TextBox txtdrivingexperiance;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblrentaldays;
        private System.Windows.Forms.Label lblexperiance;
        private System.Windows.Forms.Label lblcustomerage;
        private System.Windows.Forms.Label lblcustomer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvahicle;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAddInsurence;
        private System.Windows.Forms.ListBox lstresults;
    }
}

