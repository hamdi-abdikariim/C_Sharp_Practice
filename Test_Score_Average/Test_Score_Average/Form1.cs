using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTest3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
       
            // Declare variables
            double score1;
            double score2;
            double score3;

            // Check the first score
            if (!double.TryParse(txtScore1.Text, out score1))
            {
                MessageBox.Show("Please enter a valid Score 1.");
            }

            // Check the second score
            else if (!double.TryParse(txtScore2.Text, out score2))
            {
                MessageBox.Show("Please enter a valid Score 2.");
            }

            // Check the third score
            else if (!double.TryParse(txtScore3.Text, out score3))
            {
                MessageBox.Show("Please enter a valid Score 3.");
            }

            // If all three scores are valid
            else
            {
                // Calculate the average
                double average = (score1 + score2 + score3) / 3;

                // Display the average
                lbloutput.Text = average.ToString("0.0");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        
            // Clear all TextBoxes
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lbloutput.Text="";

           
        
    }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    }

