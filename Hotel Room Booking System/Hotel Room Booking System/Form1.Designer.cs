namespace Hotel_Room_Booking_System
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
            this.lblpersonal = new System.Windows.Forms.Label();
            this.lblnumerofguests = new System.Windows.Forms.Label();
            this.lblguestName = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblnumberofNights = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtNigts = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.grproomType = new System.Windows.Forms.GroupBox();
            this.grpadditionalOppetion = new System.Windows.Forms.GroupBox();
            this.rdostandard = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdohight = new System.Windows.Forms.RadioButton();
            this.chkbreakfast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grproomType.SuspendLayout();
            this.grpadditionalOppetion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpersonal
            // 
            this.lblpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonal.Location = new System.Drawing.Point(39, 9);
            this.lblpersonal.Name = "lblpersonal";
            this.lblpersonal.Size = new System.Drawing.Size(344, 39);
            this.lblpersonal.TabIndex = 0;
            this.lblpersonal.Text = "Personal In formation";
            this.lblpersonal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumerofguests
            // 
            this.lblnumerofguests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerofguests.Location = new System.Drawing.Point(12, 257);
            this.lblnumerofguests.Name = "lblnumerofguests";
            this.lblnumerofguests.Size = new System.Drawing.Size(265, 36);
            this.lblnumerofguests.TabIndex = 1;
            this.lblnumerofguests.Text = "Number of Guests:";
            // 
            // lblguestName
            // 
            this.lblguestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestName.Location = new System.Drawing.Point(60, 102);
            this.lblguestName.Name = "lblguestName";
            this.lblguestName.Size = new System.Drawing.Size(172, 46);
            this.lblguestName.TabIndex = 2;
            this.lblguestName.Text = "Guest Name:";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(95, 155);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(201, 31);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Guest Age:";
            // 
            // lblnumberofNights
            // 
            this.lblnumberofNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofNights.Location = new System.Drawing.Point(22, 208);
            this.lblnumberofNights.Name = "lblnumberofNights";
            this.lblnumberofNights.Size = new System.Drawing.Size(274, 26);
            this.lblnumberofNights.TabIndex = 4;
            this.lblnumberofNights.Text = "Number of Nights:";
            this.lblnumberofNights.Click += new System.EventHandler(this.lblnumberofNights_Click);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtname.Location = new System.Drawing.Point(302, 102);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 35);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtage.Location = new System.Drawing.Point(302, 159);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(239, 26);
            this.txtage.TabIndex = 6;
            // 
            // txtNigts
            // 
            this.txtNigts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNigts.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtNigts.Location = new System.Drawing.Point(302, 212);
            this.txtNigts.Multiline = true;
            this.txtNigts.Name = "txtNigts";
            this.txtNigts.Size = new System.Drawing.Size(239, 26);
            this.txtNigts.TabIndex = 7;
            // 
            // txtGuests
            // 
            this.txtGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuests.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtGuests.Location = new System.Drawing.Point(302, 265);
            this.txtGuests.Multiline = true;
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(239, 26);
            this.txtGuests.TabIndex = 8;
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(751, 92);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(533, 524);
            this.lstBookingDetails.TabIndex = 9;
            // 
            // grproomType
            // 
            this.grproomType.Controls.Add(this.rdohight);
            this.grproomType.Controls.Add(this.rdonormal);
            this.grproomType.Controls.Add(this.rdostandard);
            this.grproomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grproomType.Location = new System.Drawing.Point(75, 379);
            this.grproomType.Name = "grproomType";
            this.grproomType.Size = new System.Drawing.Size(560, 140);
            this.grproomType.TabIndex = 10;
            this.grproomType.TabStop = false;
            this.grproomType.Text = "Room Type";
            // 
            // grpadditionalOppetion
            // 
            this.grpadditionalOppetion.Controls.Add(this.chkbreakfast);
            this.grpadditionalOppetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpadditionalOppetion.Location = new System.Drawing.Point(75, 556);
            this.grpadditionalOppetion.Name = "grpadditionalOppetion";
            this.grpadditionalOppetion.Size = new System.Drawing.Size(560, 140);
            this.grpadditionalOppetion.TabIndex = 11;
            this.grpadditionalOppetion.TabStop = false;
            this.grpadditionalOppetion.Text = "Additional Opptions";
            // 
            // rdostandard
            // 
            this.rdostandard.AutoSize = true;
            this.rdostandard.Location = new System.Drawing.Point(30, 62);
            this.rdostandard.Name = "rdostandard";
            this.rdostandard.Size = new System.Drawing.Size(133, 30);
            this.rdostandard.TabIndex = 0;
            this.rdostandard.TabStop = true;
            this.rdostandard.Text = "Standard";
            this.rdostandard.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(227, 62);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(114, 30);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdohight
            // 
            this.rdohight.AutoSize = true;
            this.rdohight.Location = new System.Drawing.Point(401, 62);
            this.rdohight.Name = "rdohight";
            this.rdohight.Size = new System.Drawing.Size(93, 30);
            this.rdohight.TabIndex = 2;
            this.rdohight.TabStop = true;
            this.rdohight.Text = "Hight";
            this.rdohight.UseVisualStyleBackColor = true;
            // 
            // chkbreakfast
            // 
            this.chkbreakfast.AutoSize = true;
            this.chkbreakfast.Location = new System.Drawing.Point(48, 64);
            this.chkbreakfast.Name = "chkbreakfast";
            this.chkbreakfast.Size = new System.Drawing.Size(414, 30);
            this.chkbreakfast.TabIndex = 0;
            this.chkbreakfast.Text = "Breakfast (10 Per Guest per nights)";
            this.chkbreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(378, 767);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(191, 85);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(637, 767);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 85);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(933, 767);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(191, 85);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1391, 883);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpadditionalOppetion);
            this.Controls.Add(this.grproomType);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.txtNigts);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblnumberofNights);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblguestName);
            this.Controls.Add(this.lblnumerofguests);
            this.Controls.Add(this.lblpersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.grproomType.ResumeLayout(false);
            this.grproomType.PerformLayout();
            this.grpadditionalOppetion.ResumeLayout(false);
            this.grpadditionalOppetion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpersonal;
        private System.Windows.Forms.Label lblnumerofguests;
        private System.Windows.Forms.Label lblguestName;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnumberofNights;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtNigts;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.ListBox lstBookingDetails;
        private System.Windows.Forms.GroupBox grproomType;
        private System.Windows.Forms.GroupBox grpadditionalOppetion;
        private System.Windows.Forms.RadioButton rdohight;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdostandard;
        private System.Windows.Forms.CheckBox chkbreakfast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnexit;
    }
}

