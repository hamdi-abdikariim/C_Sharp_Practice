using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Declaring variables
            string food1, food2;
            double foodPrice1, foodPrice2;
            double tax, totalAmount;

            // 2. Initialisation value
            food1 = txtfood1.Text;
            food2 = txtfood2.Text;

            foodPrice1 = double.Parse(txtfoodprice1.Text); 
            foodPrice2 = double.Parse(txtfoodprice2.Text); 

           
            //calculation 
            double subtotal = foodPrice1 + foodPrice2;

            //tax
             tax = subtotal * 0.07; 

            //total amount 
              totalAmount = subtotal + tax;

            // Display Total salary
            lblsalary.Text = tax.ToString("F2");
            
            // Display Total Amount
            lbltotal.Text = totalAmount.ToString("F2");


        }
    }
}
