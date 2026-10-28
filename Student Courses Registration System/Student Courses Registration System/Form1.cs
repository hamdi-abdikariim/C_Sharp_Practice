using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Courses_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string course;
            int numberOfCourse;
            decimal price, validate;

            try
            {
                course = txtCourseName.Text.Trim();

                // Validate course name
                if (course == "")
                {
                    MessageBox.Show("Please enter course name");
                    return;
                }

                // Validate course price
                if (!decimal.TryParse(txtCoursePrise.Text, out validate))
                {
                    MessageBox.Show("Please enter a valid course price");
                    return;
                }

                price = validate;

                if (price <= 0)
                {
                    MessageBox.Show("Course price must be greater than zero");
                    return;
                }

                // Validate number of courses
                if (!int.TryParse(txtNumberOfCourses.Text, out numberOfCourse))
                {
                    MessageBox.Show("Please enter a valid number of courses");
                    return;
                }

                if (numberOfCourse < 1 || numberOfCourse > 5)
                {
                    MessageBox.Show("Number of courses must be between 1 and 5");
                    return;
                }

                // Check the number of registered courses
                if (lstRegisteredCourses.Items.Count >= 5)
                {
                    MessageBox.Show("You can register a maximum of 5 courses");
                    return;
                }

                // Add one course as one item
                lstRegisteredCourses.Items.Add(course + " - $" + price.ToString("0.00"));

                // Clear course inputs
                txtCourseName.Clear();
                txtCoursePrise.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {

            String selectedItem = lstRegisteredCourses.SelectedItems.ToString();
            //if (lstRegisteredCourses.SelectedIndexChanged==-1)
            //{

            //    lstRegisteredCourses.Items.Remove(selectedItem);
            //}
            //else
            //{
            //    MessageBox.Show("please select item to remove");
            //}

        }


        private void btnCalculate_Click(object sender, EventArgs e) {
            string studentName;
            string studentID;
            int age;
            int numberOfCourses;
            double basicFee = 0;
            double courseDiscount = 0;
            double scholarshipDiscount = 0; // Checkbox iskada
            double total;

            try
            {
                // Validate Student Age using int.TryParse
                if (!int.TryParse(TxtStudentAge.Text, out age))
                {
                    MessageBox.Show("Please enter a valid age");
                    return;
                }

                // Student Age must be between 16 and 60
                if (age < 16 || age > 60)
                {
                    MessageBox.Show("Age must be between 16 and 60");
                    return;
                }

                // Validate Student Name and ID cannot be empty
                studentName = TxtStudentName.Text.Trim();
                studentID = txtStudentId.Text.Trim();

                if (studentName == "" || studentID == "")
                {
                    MessageBox.Show("Student name and ID cannot be empty");
                    return;
                }

                // At least one course must be registered
                numberOfCourses = lstRegisteredCourses.Items.Count;

                if (numberOfCourses == 0)
                {
                    MessageBox.Show("Please register at least one course");
                    return;
                }

                // Use a while loop to calculate the total price of all registered courses from lstRegisteredCourses
                int i = 0;
                while (i < numberOfCourses)
                {
                    string course = lstRegisteredCourses.Items[i].ToString();

                    string[] parts = course.Split('$');
                    double price;

                    if (parts.Length < 2 || !double.TryParse(parts[1].Trim(), out price))
                    {
                        MessageBox.Show("Invalid course price: " + course);
                        return;
                    }

                    basicFee = basicFee + price;
                    i++;
                }

                // Use if-else-if statements to determine the course discount
                if (numberOfCourses == 1)
                {
                    courseDiscount = basicFee * 0;
                }
                else if (numberOfCourses == 2)
                {
                    courseDiscount = basicFee * 0.05;
                }
                else if (numberOfCourses == 3 || numberOfCourses == 4)
                {
                    courseDiscount = basicFee * 0.10;
                }
                else if (numberOfCourses == 5)
                {
                    courseDiscount = basicFee * 0.15;
                }

                // Calculate final registration fee
                total = basicFee - courseDiscount - scholarshipDiscount;

                // Display results in the main lstresult Box
                lstresult.Items.Clear(); // Nadiifi wixii hore ugu jiray haddii la celiyaa
                lstresult.Items.Add("------------------------------");
                lstresult.Items.Add("Student Name: " + studentName);
                lstresult.Items.Add("Student ID: " + studentID);
                lstresult.Items.Add("Number of Courses: " + numberOfCourses);
                lstresult.Items.Add("--------------------------");
                lstresult.Items.Add("Basic Registration Fee: $" + basicFee.ToString("0.00"));
                lstresult.Items.Add("Course Discount: $" + courseDiscount.ToString("0.00"));
                lstresult.Items.Add("--------------------------");
                lstresult.Items.Add("Scholarship Discount: $" + scholarshipDiscount.ToString("0.00"));
                lstresult.Items.Add("Final Registration Fee: $" + total.ToString("0.00"));
                lstresult.Items.Add("Registration Status: Approved");
                lstresult.Items.Add(" ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data: " + ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtStudentName.Clear();
            TxtStudentAge.Clear();
            txtStudentId.Clear();
            txtNumberOfCourses.Clear();
            txtCoursePrise.Clear();

            lstresult.Items.Clear();
        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
