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
    public partial class AddTimeLog : UserControl
    {
        private ServiceReference1.User developer;
        public AddTimeLog(ServiceReference1.User developer)
        {
            InitializeComponent();
            this.developer = developer;
        }
        
        private void AddTimeLog_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.projectCurrentlyOnWhichWork(developer);
            if (projects != null)
            {
                foreach (ServiceReference1.Project project in projects)
                {
                    comboBox1.Items.Add(project.Title);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate that all required fields are filled
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(description_txtbx.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(hours_txtbx.Text))
            {
                MessageBox.Show("Please enter the time spent.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that hours are a valid float
            if (!float.TryParse(hours_txtbx.Text, out float hours))
            {
                MessageBox.Show("Please enter a valid number for hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate that hours are not greater than 8
            if (hours > 8)
            {
                MessageBox.Show("Hours cannot be greater than 8.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If all fields are valid, proceed with the desired action
            string selectedProject = comboBox1.SelectedItem.ToString();
            string description = description_txtbx.Text;

            // Example action: Display a message box with the entered information
            MessageBox.Show($"Project: {selectedProject}\nTime Spent: {hours}\nDescription: {description}", "Time Log Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // You can replace the above message box with the actual logic to save the time log
        }

    }
}
