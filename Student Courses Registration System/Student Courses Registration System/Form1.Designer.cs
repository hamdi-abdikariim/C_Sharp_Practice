namespace Student_Courses_Registration_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.TxtStudentAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtCoursePrise = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlRegisteredCourse = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lstRegisteredCourses = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstresult = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberOfCourses = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlRegisteredCourse.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Age:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtStudentAge);
            this.panel1.Controls.Add(this.txtStudentId);
            this.panel1.Controls.Add(this.TxtStudentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 235);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(194, 91);
            this.TxtStudentName.Multiline = true;
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(265, 28);
            this.TxtStudentName.TabIndex = 3;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(194, 185);
            this.txtStudentId.Multiline = true;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(265, 28);
            this.txtStudentId.TabIndex = 4;
            // 
            // TxtStudentAge
            // 
            this.TxtStudentAge.Location = new System.Drawing.Point(194, 138);
            this.TxtStudentAge.Multiline = true;
            this.TxtStudentAge.Name = "TxtStudentAge";
            this.TxtStudentAge.Size = new System.Drawing.Size(265, 28);
            this.TxtStudentAge.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.txtNumberOfCourses);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnRemoveCourse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.txtCoursePrise);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(22, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 337);
            this.panel2.TabIndex = 11;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.Location = new System.Drawing.Point(308, 259);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(262, 38);
            this.btnRemoveCourse.TabIndex = 3;
            this.btnRemoveCourse.Text = "&Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Information";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(10, 259);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(262, 38);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txtCoursePrise
            // 
            this.txtCoursePrise.Location = new System.Drawing.Point(194, 138);
            this.txtCoursePrise.Multiline = true;
            this.txtCoursePrise.Name = "txtCoursePrise";
            this.txtCoursePrise.Size = new System.Drawing.Size(265, 28);
            this.txtCoursePrise.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(194, 91);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(265, 28);
            this.txtCourseName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Course Prise:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PnlRegisteredCourse
            // 
            this.PnlRegisteredCourse.BackColor = System.Drawing.SystemColors.Info;
            this.PnlRegisteredCourse.Controls.Add(this.lstRegisteredCourses);
            this.PnlRegisteredCourse.Controls.Add(this.label9);
            this.PnlRegisteredCourse.Location = new System.Drawing.Point(22, 668);
            this.PnlRegisteredCourse.Name = "PnlRegisteredCourse";
            this.PnlRegisteredCourse.Size = new System.Drawing.Size(507, 308);
            this.PnlRegisteredCourse.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 39);
            this.label9.TabIndex = 13;
            this.label9.Text = "Registered Course";
            // 
            // lstRegisteredCourses
            // 
            this.lstRegisteredCourses.HideSelection = false;
            this.lstRegisteredCourses.Location = new System.Drawing.Point(26, 81);
            this.lstRegisteredCourses.Name = "lstRegisteredCourses";
            this.lstRegisteredCourses.Size = new System.Drawing.Size(340, 192);
            this.lstRegisteredCourses.TabIndex = 14;
            this.lstRegisteredCourses.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lstresult);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(687, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 581);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lstresult
            // 
            this.lstresult.HideSelection = false;
            this.lstresult.Location = new System.Drawing.Point(26, 81);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(506, 465);
            this.lstresult.TabIndex = 14;
            this.lstresult.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 39);
            this.label10.TabIndex = 13;
            this.label10.Text = "Regidtration Result";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(85, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "Student Registration Result";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCalculate.Location = new System.Drawing.Point(687, 638);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 96);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(1037, 638);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 96);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(868, 638);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 96);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number Of Courses";
            // 
            // txtNumberOfCourses
            // 
            this.txtNumberOfCourses.Location = new System.Drawing.Point(194, 190);
            this.txtNumberOfCourses.Multiline = true;
            this.txtNumberOfCourses.Name = "txtNumberOfCourses";
            this.txtNumberOfCourses.Size = new System.Drawing.Size(265, 28);
            this.txtNumberOfCourses.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 988);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlRegisteredCourse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlRegisteredCourse.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStudentAge;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtCoursePrise;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PnlRegisteredCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstresult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lstRegisteredCourses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNumberOfCourses;
        private System.Windows.Forms.Label label7;
    }
}

