namespace Airline_Ticket_Booking_System
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
            this.txtpassengerAge = new System.Windows.Forms.TextBox();
            this.txtbaggageWeight = new System.Windows.Forms.TextBox();
            this.txtnumberTickets = new System.Windows.Forms.TextBox();
            this.txtpassengerName = new System.Windows.Forms.TextBox();
            this.lblbaggageWeight = new System.Windows.Forms.Label();
            this.lblnumberTickets = new System.Windows.Forms.Label();
            this.lblpasengerAge = new System.Windows.Forms.Label();
            this.llblpassengerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBussinessClass = new System.Windows.Forms.RadioButton();
            this.radioNormalClass = new System.Windows.Forms.RadioButton();
            this.radiofirstClass = new System.Windows.Forms.RadioButton();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listDisplayOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtpassengerAge);
            this.groupBox1.Controls.Add(this.txtbaggageWeight);
            this.groupBox1.Controls.Add(this.txtnumberTickets);
            this.groupBox1.Controls.Add(this.txtpassengerName);
            this.groupBox1.Controls.Add(this.lblbaggageWeight);
            this.groupBox1.Controls.Add(this.lblnumberTickets);
            this.groupBox1.Controls.Add(this.lblpasengerAge);
            this.groupBox1.Controls.Add(this.llblpassengerName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtpassengerAge
            // 
            this.txtpassengerAge.Location = new System.Drawing.Point(314, 124);
            this.txtpassengerAge.Multiline = true;
            this.txtpassengerAge.Name = "txtpassengerAge";
            this.txtpassengerAge.Size = new System.Drawing.Size(295, 30);
            this.txtpassengerAge.TabIndex = 7;
            // 
            // txtbaggageWeight
            // 
            this.txtbaggageWeight.Location = new System.Drawing.Point(314, 228);
            this.txtbaggageWeight.Multiline = true;
            this.txtbaggageWeight.Name = "txtbaggageWeight";
            this.txtbaggageWeight.Size = new System.Drawing.Size(295, 30);
            this.txtbaggageWeight.TabIndex = 6;
            // 
            // txtnumberTickets
            // 
            this.txtnumberTickets.Location = new System.Drawing.Point(314, 173);
            this.txtnumberTickets.Multiline = true;
            this.txtnumberTickets.Name = "txtnumberTickets";
            this.txtnumberTickets.Size = new System.Drawing.Size(295, 30);
            this.txtnumberTickets.TabIndex = 5;
            // 
            // txtpassengerName
            // 
            this.txtpassengerName.Location = new System.Drawing.Point(314, 59);
            this.txtpassengerName.Multiline = true;
            this.txtpassengerName.Name = "txtpassengerName";
            this.txtpassengerName.Size = new System.Drawing.Size(295, 30);
            this.txtpassengerName.TabIndex = 4;
            // 
            // lblbaggageWeight
            // 
            this.lblbaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaggageWeight.Location = new System.Drawing.Point(6, 216);
            this.lblbaggageWeight.Name = "lblbaggageWeight";
            this.lblbaggageWeight.Size = new System.Drawing.Size(244, 32);
            this.lblbaggageWeight.TabIndex = 3;
            this.lblbaggageWeight.Text = "Paggage weight(kg) :";
            // 
            // lblnumberTickets
            // 
            this.lblnumberTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberTickets.Location = new System.Drawing.Point(26, 171);
            this.lblnumberTickets.Name = "lblnumberTickets";
            this.lblnumberTickets.Size = new System.Drawing.Size(222, 32);
            this.lblnumberTickets.TabIndex = 2;
            this.lblnumberTickets.Text = "Number of Tickets :";
            // 
            // lblpasengerAge
            // 
            this.lblpasengerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasengerAge.Location = new System.Drawing.Point(58, 124);
            this.lblpasengerAge.Name = "lblpasengerAge";
            this.lblpasengerAge.Size = new System.Drawing.Size(190, 32);
            this.lblpasengerAge.TabIndex = 1;
            this.lblpasengerAge.Text = "Passenger Age :";
            // 
            // llblpassengerName
            // 
            this.llblpassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblpassengerName.Location = new System.Drawing.Point(22, 59);
            this.llblpassengerName.Name = "llblpassengerName";
            this.llblpassengerName.Size = new System.Drawing.Size(306, 38);
            this.llblpassengerName.TabIndex = 0;
            this.llblpassengerName.Text = "Passenger Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBussinessClass);
            this.groupBox2.Controls.Add(this.radioNormalClass);
            this.groupBox2.Controls.Add(this.radiofirstClass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(86, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // radioBussinessClass
            // 
            this.radioBussinessClass.AutoSize = true;
            this.radioBussinessClass.Location = new System.Drawing.Point(450, 38);
            this.radioBussinessClass.Name = "radioBussinessClass";
            this.radioBussinessClass.Size = new System.Drawing.Size(201, 30);
            this.radioBussinessClass.TabIndex = 2;
            this.radioBussinessClass.TabStop = true;
            this.radioBussinessClass.Text = "Business Class";
            this.radioBussinessClass.UseVisualStyleBackColor = true;
            // 
            // radioNormalClass
            // 
            this.radioNormalClass.AutoSize = true;
            this.radioNormalClass.Location = new System.Drawing.Point(212, 38);
            this.radioNormalClass.Name = "radioNormalClass";
            this.radioNormalClass.Size = new System.Drawing.Size(181, 30);
            this.radioNormalClass.TabIndex = 1;
            this.radioNormalClass.TabStop = true;
            this.radioNormalClass.Text = "Normal Class";
            this.radioNormalClass.UseVisualStyleBackColor = true;
            // 
            // radiofirstClass
            // 
            this.radiofirstClass.AutoSize = true;
            this.radiofirstClass.Location = new System.Drawing.Point(34, 38);
            this.radiofirstClass.Name = "radiofirstClass";
            this.radiofirstClass.Size = new System.Drawing.Size(144, 30);
            this.radiofirstClass.TabIndex = 0;
            this.radiofirstClass.TabStop = true;
            this.radiofirstClass.Text = "first Class";
            this.radiofirstClass.UseVisualStyleBackColor = true;
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.chkTravelInsurance);
            this.gr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr1.Location = new System.Drawing.Point(86, 586);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(583, 108);
            this.gr1.TabIndex = 3;
            this.gr1.TabStop = false;
            this.gr1.Text = "Addition Options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(27, 35);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(432, 30);
            this.chkTravelInsurance.TabIndex = 0;
            this.chkTravelInsurance.Text = "Add Travel insurence ($25 Per ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(273, 846);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(233, 76);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calaculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(793, 846);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(233, 76);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(536, 846);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(233, 76);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listDisplayOutput
            // 
            this.listDisplayOutput.FormattingEnabled = true;
            this.listDisplayOutput.ItemHeight = 20;
            this.listDisplayOutput.Location = new System.Drawing.Point(819, 45);
            this.listDisplayOutput.Name = "listDisplayOutput";
            this.listDisplayOutput.Size = new System.Drawing.Size(390, 484);
            this.listDisplayOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 1050);
            this.Controls.Add(this.listDisplayOutput);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblbaggageWeight;
        private System.Windows.Forms.Label lblnumberTickets;
        private System.Windows.Forms.Label lblpasengerAge;
        private System.Windows.Forms.Label llblpassengerName;
        private System.Windows.Forms.TextBox txtpassengerAge;
        private System.Windows.Forms.TextBox txtbaggageWeight;
        private System.Windows.Forms.TextBox txtnumberTickets;
        private System.Windows.Forms.TextBox txtpassengerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNormalClass;
        private System.Windows.Forms.RadioButton radiofirstClass;
        private System.Windows.Forms.RadioButton radioBussinessClass;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listDisplayOutput;
    }
}

