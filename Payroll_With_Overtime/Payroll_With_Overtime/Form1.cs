using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Declare variables
                double hoursWorked;
                double hourlyPayRate;

                // Convert TextBox values to double
                hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);
                hourlyPayRate = Convert.ToDouble(hourlyPayRateTextBox.Text);

                // Check if hours worked are valid
                if (hoursWorked >= 0)
                {
                    // Check if hourly pay rate is valid
                    if (hourlyPayRate >= 0)
                    {
                        double grossPay;

                        // Check if the employee worked overtime
                        if (hoursWorked <= 40)
                        {
                            // Regular pay
                            grossPay = hoursWorked * hourlyPayRate;
                        }
                        else
                        {
                            // Calculate overtime hours
                            double overtimeHours = hoursWorked - 40;

                            // Regular pay + overtime pay
                            grossPay = (40 * hourlyPayRate) +
                                       (overtimeHours * hourlyPayRate * 1.5);
                        }

                        // Display gross pay
                        lblgrosspayoutput.Text = grossPay.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Hourly pay rate cannot be negative.");
                    }
                }
                else
                {
                    MessageBox.Show("Hours worked cannot be negative.");
                }
            }
            catch
            {
                // This runs when the user enters invalid text
                MessageBox.Show("Please enter valid numbers.");
            }

        }
    }
}
