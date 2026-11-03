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

namespace Assignment_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveDailog_Click(object sender, EventArgs e)
        {

            // Declare StreamWriter to write data into the file
            StreamWriter Writes;

            // Declare DialogResult to store the user's choice
            DialogResult result;

            // Clear the previous file name

            // Display the Save File Dialog window
            result = saveFileDialog1.ShowDialog();

            // Check if the user clicks the Save button
            if (result == DialogResult.OK)
            {
                Writes = File.AppendText(saveFileDialog1.FileName);

                Writes.WriteLine(txtUserInput.Text);

                // Close the file 
                Writes.Close();
            }
            else
            {
                // Display a message if the user cancels saving
                MessageBox.Show("File was not saved");
            }


        }
    }
}
