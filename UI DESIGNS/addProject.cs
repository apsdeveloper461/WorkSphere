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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Active");
            comboBox1.Items.Add("Completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text.Trim();
            string title = textBox2.Text.Trim();
            string description = textBox3.Text.Trim();
            string assignedTo = textBox4.Text.Trim();
            string status = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(assignedTo) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Project added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
