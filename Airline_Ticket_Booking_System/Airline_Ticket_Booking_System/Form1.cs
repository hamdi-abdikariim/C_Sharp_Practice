using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listDisplayOutput.Items.Clear();

            // Get input values
            string passengerName = txtpassengerName.Text;
            if (string.IsNullOrEmpty(passengerName))
            {
                MessageBox.Show("Please Enter Your Name");
                return;
            }

            // Validate passenger age
            if (!int.TryParse(txtpassengerAge.Text, out int passengerAge) || passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Your Age must Between 1 to 100");
                return;
            }

            // Validate number of tickets
            if (!int.TryParse(txtnumberTickets.Text, out int numberOfTickets) || numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must between 1 to 5");
                return;
            }

            // Validate baggage weight
            if (!double.TryParse(txtbaggageWeight.Text, out double baggageWeight) || baggageWeight < 0 || baggageWeight > (50 * numberOfTickets))
            {
                MessageBox.Show("Baggage weight can not be negative and can not exceed 50 per passenger");
                return;
            }

            // Check if passenger under 12 selects First Class
            bool isFirstClass = radiofirstClass.Checked;
            if (isFirstClass && passengerAge < 12)
            {
                MessageBox.Show("Passenger below 12 years can not book First Class");

                // Display rejection output
                listDisplayOutput.Items.Add("======== AIRLINE BOOKING DETAILS ========");
                listDisplayOutput.Items.Add($"Passenger Name: {passengerName}");
                listDisplayOutput.Items.Add($"Passenger Age: {passengerAge}");
                listDisplayOutput.Items.Add("Booking Status: REJECTED (Underage for First Class)");
                listDisplayOutput.Items.Add("=========================================");
                return;
            }

            // Calculate base ticket cost
            double ticketPrice = 300.0;
            double basicTicketCost = ticketPrice * numberOfTickets;

            // Calculate ticket volume discount
            double discountPercentage = 0.0;
            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                // 5% discount
                discountPercentage = 0.05; 
            }
            else if (numberOfTickets == 5)
            {
                // 10% discount
                discountPercentage = 0.10; 
            }
            double ticketDiscount = basicTicketCost * discountPercentage;

            // Calculate age-based discount
            double ageDiscount = 0.0;
            if (passengerAge < 12)
            {
                // 20% child discount
                ageDiscount = basicTicketCost * 0.20; 
            }
            else if (passengerAge >= 60)
            {
                // 10% senior discount
                ageDiscount = basicTicketCost * 0.10; 
            }

            // Travel insurance fee
            double insuranceCost = 0.0;
            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25.0 * numberOfTickets;
            }

            // Excess baggage calculation ,20kg free allowance per ticket
            double excessBaggageCost = 0.0;
            double freeBaggageAllowance = 20.0 * numberOfTickets;
            if (baggageWeight > freeBaggageAllowance)
            {
                double excessWeight = baggageWeight - freeBaggageAllowance;
                excessBaggageCost = excessWeight * 5.0;
            }

            // Total cost calculation
            double finalTicketCost = basicTicketCost - (ticketDiscount + ageDiscount) + insuranceCost + excessBaggageCost;

            // Display total summary to ListBox
            listDisplayOutput.Items.Add("======== AIRLINE BOOKING DETAILS ========");
            listDisplayOutput.Items.Add($"Passenger Name: {passengerName}");
            listDisplayOutput.Items.Add($"Passenger Age: {passengerAge}");
            listDisplayOutput.Items.Add($"Travel Class: {(isFirstClass ? "First Class" : "Normal Class")}");
            listDisplayOutput.Items.Add($"Number of Tickets: {numberOfTickets}");
            listDisplayOutput.Items.Add($"Baggage Weight: {baggageWeight} kg");
            listDisplayOutput.Items.Add("-----------------------------------------");
            listDisplayOutput.Items.Add($"Ticket Price: ${ticketPrice:N2}");
            listDisplayOutput.Items.Add($"Basic Ticket Cost: ${basicTicketCost:N2}");
            listDisplayOutput.Items.Add($"Ticket Discount: ${ticketDiscount:N2}");
            listDisplayOutput.Items.Add($"Age Discount: ${ageDiscount:N2}");
            listDisplayOutput.Items.Add($"Insurance Cost: ${insuranceCost:N2}");
            listDisplayOutput.Items.Add($"Excess Baggage Cost: ${excessBaggageCost:N2}");
            listDisplayOutput.Items.Add("-----------------------------------------");
            listDisplayOutput.Items.Add($"Final Ticket Cost: ${finalTicketCost:N2}");
            listDisplayOutput.Items.Add("Booking Status: APPROVED");
            listDisplayOutput.Items.Add("=========================================");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listDisplayOutput.Items.Clear();
            txtpassengerName.Text = string.Empty;
            txtpassengerAge.Text = string.Empty;
            txtnumberTickets.Text = string.Empty;
            txtbaggageWeight.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
