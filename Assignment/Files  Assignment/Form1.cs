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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
                


                // Declare StreamReader
                StreamReader Input_file;

                // Open the file
                Input_file = File.OpenText("readFile.txt");

                // Read the file line by line
                string line;

                while ((line = Input_file.ReadLine()) != null)
                {
                    lstDisplay.Items.Add(line);
                }
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (File.Exists("readFile.txt"))
            {
                // Delete the file
                File.Delete("readFile.txt");

                // Display a message
                MessageBox.Show("File deleted successfully!");
            }
        }

        private void btnDeleteItemOftheFile_Click(object sender, EventArgs e)
        {
            // Read the file
            StreamReader Input_file = File.OpenText("readFile.txt");

            string content = "";
            string line;

            // Read each line
            while ((line = Input_file.ReadLine()) != null)
            {
                // Skip the item to delete
                if (line != "Welcome to CA242")
                {
                    content += line + Environment.NewLine;
                }
            }

            // Close the file
            Input_file.Close();

            // Write the remaining content
            StreamWriter Output_file = File.CreateText("readFile.txt");
            Output_file.Write(content);
            Output_file.Close();

            // Display message
            MessageBox.Show("Item deleted successfully!");

        }
    }
}
