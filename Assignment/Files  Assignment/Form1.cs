using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files__Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadingotherFuction_Click(object sender, EventArgs e)
        {

            {
                // Declare StreamWriter
                StreamWriter Output_file;

                // Create a new file
                Output_file = File.CreateText("readFile.txt");

                // Write text into the file
                Output_file.WriteLine("Welcome to CA242");
                Output_file.WriteLine("Welcome to CA244");
                Output_file.WriteLine("Data Structure is very hard");

                // Close the file
                Output_file.Close();

                MessageBox.Show("File created successfully!");

                //// Declare StreamReader
                //StreamReader Input_file;

                //// Open the file
                //Input_file = File.OpenText("readFile.txt");

                //// Read the file line by line
                //string line;

                //while ((line = Input_file.ReadLine()) != null)
                //{
                //    lstDisplay.Items.Add(line);
                //}
            }
        }
    }
}
