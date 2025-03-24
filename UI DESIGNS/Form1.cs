using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_DESIGNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text.Trim();
            string password = textBox1.Text.Trim();

            // Check agar koi field khali ho
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Function exit kar do
            }

            // Sab kuch theek hai toh dusra form open karo
            AdminForm dashboard = new AdminForm(); // New Form ka object
            dashboard.Show(); // Dusra form dikhana
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
