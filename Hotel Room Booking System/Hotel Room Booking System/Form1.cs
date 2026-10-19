using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblnumberofNights_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // 1. Validation: Guest Name
            string guestName = txtname.Text.Trim();
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }

            // 2. Validation using int.TryParse
            if (!int.TryParse(txtage.Text, out int age) || age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            if (!int.TryParse(txtNigts.Text, out int nights) || nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }

            if (!int.TryParse(txtGuests.Text, out int guests) || guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            // 3. Room Type Selection & Capacity Validation
            string roomType = "";
            int maxCapacity = 0;
            double ratePerNight = 0;

            if (rdostandard.Checked)
            {
                roomType = "Standard";
                maxCapacity = 2;
            }
            else if (rdonormal.Checked)
            {
                roomType = "Normal";
                maxCapacity = 4;
            }
            else if (rdohight.Checked)
            {
                roomType = "Hight";
                maxCapacity = 6;
            }
            else
            {
                MessageBox.Show("Please select room type.");
                return;
            }

            // Bool flag to determine whether approved or rejected
            bool isApproved = true;

            if (guests > maxCapacity)
            {
                isApproved = false;
            }

            if (!isApproved)
            {
                MessageBox.Show($"Booking rejected! {roomType} room can only take max {maxCapacity} guests.");
                lstBookingDetails.Items.Add("STATUS: REJECTED");
                lstBookingDetails.Items.Add($"Reason: Exceeded capacity limit of {maxCapacity} guests for {roomType} room.");
                return;
            }

            // 4. Room Rates using switch statement
            switch (roomType)
            {
                case "Standard":
                    ratePerNight = 50;
                    break;
                case "Normal":
                    ratePerNight = 80;
                    break;
                case "Hight":
                    ratePerNight = 130;
                    break;
            }

            // 5. Cost Calculations
            double baseCost = ratePerNight * nights;

            // Nights Discount
            double nightDiscountRate = 0;
            if (nights >= 5 && nights <= 9)
            {
                // 5% discount
                nightDiscountRate = 0.05;
            }
            else if (nights >= 10)
            {
                // 12% discount
                nightDiscountRate = 0.12;
            }

            double nightDiscountAmount = baseCost * nightDiscountRate;
            double costAfterNightDiscount = baseCost - nightDiscountAmount;

            // Senior Discount ,Aged 60 or above: additional 5,
            double seniorDiscountAmount = 0;
            if (age >= 60)
            {
                seniorDiscountAmount = costAfterNightDiscount * 0.05;
            }

            double totalAfterDiscounts = costAfterNightDiscount - seniorDiscountAmount;

            // Breakfast Option ($10 per guest per night)
            double breakfastCost = 0;
            if (chkbreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // Service Surcharge (More than 4 guests: add 5%)
            double surchargeAmount = 0;
            if (guests > 4)
            {
                surchargeAmount = totalAfterDiscounts * 0.05;
            }

            // Final Total Cost
            double totalCost = totalAfterDiscounts + breakfastCost + surchargeAmount;

            // 6. Display Output in ListBox
            lstBookingDetails.Items.Add("======== BOOKING DETAILS ========");
            lstBookingDetails.Items.Add($"Status: APPROVED");
            lstBookingDetails.Items.Add($"Guest Name: {guestName}");
            lstBookingDetails.Items.Add($"Age: {age}");
            lstBookingDetails.Items.Add($"Nights: {nights}");
            lstBookingDetails.Items.Add($"Guests: {guests}");
            lstBookingDetails.Items.Add($"Room Type: {roomType} (${ratePerNight}/night)");
            lstBookingDetails.Items.Add("---------------------------------");
            lstBookingDetails.Items.Add($"Base Room Cost: ${baseCost:F2}");
            if (nightDiscountAmount > 0)
                lstBookingDetails.Items.Add($"Night Discount: -${nightDiscountAmount:F2}");
            if (seniorDiscountAmount > 0)
                lstBookingDetails.Items.Add($"Senior Discount (60+): -${seniorDiscountAmount:F2}");
            if (breakfastCost > 0)
                lstBookingDetails.Items.Add($"Breakfast Fee: +${breakfastCost:F2}");
            if (surchargeAmount > 0)
                lstBookingDetails.Items.Add($"Service Surcharge (5%): +${surchargeAmount:F2}");
            lstBookingDetails.Items.Add("---------------------------------");
            lstBookingDetails.Items.Add($"TOTAL COST: ${totalCost:F2}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtNigts.Clear();
            txtGuests.Clear();

            rdostandard.Checked =false;
            rdonormal.Checked = false;
            rdohight.Checked = false;

            chkbreakfast.Checked = false;

            lstBookingDetails.Items.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
