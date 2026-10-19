using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

       






        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blBasicRentalCost_Click(object sender, EventArgs e)
        {

        }

        private void lblcustomerage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblvahicle_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdosuv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



      
            

        private void btncalculate_Click_1(object sender, EventArgs e)
        {


            // 1. Validate Customer Name
            string name = txtname.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the customer name.");
                return;
            }

            // 2. Validate Age using TryParse
            if (!int.TryParse(txtage.Text, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            // 3. Validate Rental Days using TryParse
            if (!int.TryParse(txtrentaldays.Text, out int days))
            {
                MessageBox.Show("Please enter a valid numeric value for rental days.");
                return;
            }

            // 4. Validate Driving Experience using TryParse
            if (!int.TryParse(txtdrivingexperiance.Text, out int experience))
            {
                MessageBox.Show("Please enter a valid numeric value for driving experience.");
                return;
            }

            // --- Validation Rules ---
            // Customer age must be between 18 and 80 years
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80 years.");
                return;
            }

            // Customers below 21 years are not eligible
            if (age < 21)
            {
                MessageBox.Show("Customers below 21 years are not eligible to rent a vehicle.";
                return;
            }

            // Rental days must be between 1 and 30 days
            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30 days.");
                return;
            }

            // Driving experience cannot be negative
            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // Customers must have at least 1 year of driving experience
            if (experience < 1)
            {
                MessageBox.Show("Customers must have at least 1 year of driving experience.");
                return;
            }

            // Determine Vehicle Type & Daily Rate
            string vehicleType = "";
            double dailyRate = 0;

            if (rdoeconomy.Checked)
            {
                vehicleType = "Economy";
                dailyRate = 35;
            }
            else if (rdosuv.Checked)
            {
                vehicleType = "SUV";
                dailyRate = 60;
            }
            else if (rdoluxury.Checked)
            {
                // Luxury vehicles require at least 25 years of age and 3 years of driving experience
                if (age < 25 || experience < 3)
                {
                    MessageBox.Show("Luxury vehicles require at least 25 years of age and 3 years of driving experience.", "Eligibility Error");
                    return;
                }
                vehicleType = "Luxury";
                dailyRate = 100;
            }
            else
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }

            // --- Calculations ---
            // 1. Basic Rental Cost
            double basicCost = dailyRate * days;

            // 2. Discount Rule
            double discountRate = 0;
            if (days >= 14)
            {
                discountRate = 0.10; // 10%
            }
            else if (days >= 7)
            {
                discountRate = 0.05; // 5%
            }
            double discountAmount = basicCost * discountRate;

            // 3. Insurance Option ($15 per day)
            double insuranceCost = 0;
            if (chkAddInsurence.Checked)
            {
                insuranceCost = 15 * days;
            }

            // 4. Young-Driver Surcharge (Age 21-24: Add 10% surcharge on basic cost)
            double youngDriverSurcharge = 0;
            if (age >= 21 && age <= 24)
            {
                youngDriverSurcharge = basicCost * 0.10;
            }

            // 5. Final Rental Cost
            double finalCost = (basicCost - discountAmount) + insuranceCost + youngDriverSurcharge;

            // --- Display Results in ListBox ---
            lstresults.Items.Add("Rental Details");
            lstresults.Items.Add("--------------------------------------------------");
            lstresults.Items.Add($"Customer Name       : {name}");
            lstresults.Items.Add($"Customer Age        : {age}");
            lstresults.Items.Add($"Driving Experience  : {experience} years");
            lstresults.Items.Add($"Vehicle Type        : {vehicleType}");
            lstresults.Items.Add($"Daily Rate          : {dailyRate:C}");
            lstresults.Items.Add($"Rental Days         : {days}");
            lstresults.Items.Add($"Basic Rental Cost   : {basicCost:C}");
            lstresults.Items.Add($"Discount            : {discountAmount:C}");
            lstresults.Items.Add($"Insurance Cost      : {insuranceCost:C}");
            lstresults.Items.Add($"Young Driver Charge : {youngDriverSurcharge:C}");
            lstresults.Items.Add($"Final Rental Cost   : {finalCost:C}");
            lstresults.Items.Add("--------------------------------------------------");
            lstresults.Items.Add("Rental Status       : APPROVED");
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            // clear all the textboxes
            txtname.Clear();
            txtage.Clear();
            txtrentaldays.Clear();
            txtdrivingexperiance.Clear();



            // clear all the output labels
            lstresults.Items.Clear();
        }
    }
}
