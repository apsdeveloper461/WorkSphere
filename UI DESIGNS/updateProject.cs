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
    public partial class UpdateProject : Form
    {
        public UpdateProject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updatedID = textBox1.Text.Trim();
            string updatedTitle = textBox2.Text.Trim();
            string updatedDescription = textBox3.Text.Trim();
            string updatedAssignedTo = textBox4.Text.Trim();
            string updatedStatus = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(updatedTitle) || string.IsNullOrEmpty(updatedDescription) ||
                string.IsNullOrEmpty(updatedAssignedTo) || string.IsNullOrEmpty(updatedStatus))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProject_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Active");
            comboBox1.Items.Add("Completed");
        }
    }
}
