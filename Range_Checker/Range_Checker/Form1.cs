using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int number;

            // Try to convert the TextBox value to an integer
            if (int.TryParse(txtNumber.Text, out number))
            {
                // Check if number is between 1 and 10
                if (number >= 1 && number <= 10)
                {
                    lblDecision.Text = "The number is in the range.";
                }
                else
                {
                    lblDecision.Text = "The number is outside the range.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear
            txtNumber.Clear();
            lblDecision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
