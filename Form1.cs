namespace OncorVariableAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            // Check if any required fields are empty
            if (comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null ||
                comboBox4.SelectedItem == null)
            {
                // Show a message to the user
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding
            }

            // If all fields are filled, create and show Form2
            Form2 Form2 = new Form2();
            Form2.Show();

            // Pass the selected item text from comboBox1 to Form2's method
            Form2.UpdatePanelVisibility(station: comboBox4.SelectedItem.ToString());

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
