using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncorVariableAutomation
{
    public partial class Form2 : Form
    {

        // Public properties to expose the panels
        public Panel Panel1 { get { return panel1; } }
        public Panel Panel2 { get { return panel2; } }
        public Panel Panel3 { get { return panel3; } }
        public Panel Panel4 { get { return panel4; } }

        public Form2()
        {
            InitializeComponent();
        }

        // Method to update the visibility of panels based on the selected station
        public void UpdatePanelVisibility(string station)
        {
            // Check the station value and set the visibility of the panels accordingly
            if (station == "1")
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
            }
            else if (station == "2")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = false;
                Panel4.Visible = false;
            }
            else if (station == "3")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = false;
            }
            else if (station == "4")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change if statement to work by making it required to fill out only
            //the visible fields - add method
            if (comboBox1.SelectedItem == null ||
               comboBox2.SelectedItem == null ||
               comboBox3.SelectedItem == null ||
               comboBox4.SelectedItem == null ||
               textBox1.Text == null ||
               textBox2.Text == null ||
               textBox3.Text == null ||
               textBox4.Text == null ||
               textBox5.Text == null ||
               textBox6.Text == null ||
               textBox7.Text == null ||
               textBox8.Text == null)
            {
                // Show a message to the user
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding
            }

            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void panel1_Paint(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
