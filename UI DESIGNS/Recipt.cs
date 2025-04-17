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
    public partial class Recipt : UserControl
    {

        private ServiceReference1.User adminData;
        public Recipt(ServiceReference1.User adminData)
        {
            InitializeComponent();
            this.adminData = adminData;
        }
        private void LoadedRecipt()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Finance[] receipts = client.getFinance(adminData);

            dataGridView1.DataSource = receipts;
        }
        private void Recipt_Load(object sender, EventArgs e)
        {
            comboBox1.Controls.Clear();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.displayProject(adminData);
            if (projects != null)
            {
                foreach (ServiceReference1.Project project in projects)
                {
                    comboBox1.Items.Add("(" + project.Id + ")" + project.Title);

                }
            }
            LoadedRecipt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate that a project is selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that hourly rate is a valid float
            if (string.IsNullOrWhiteSpace(hourlyRate_txtbx.Text) || !float.TryParse(hourlyRate_txtbx.Text, out float hourlyRate))
            {
                MessageBox.Show("Please enter a valid hourly rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that management cost is a valid float
            if (string.IsNullOrWhiteSpace(managementCost_txtbx.Text) || !float.TryParse(managementCost_txtbx.Text, out float managementCost))
            {
                MessageBox.Show("Please enter a valid management cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Extract the selected project ID
            string selectedProject = comboBox1.SelectedItem.ToString();
            selectedProject = selectedProject.Substring(1, selectedProject.IndexOf(')') - 1); // Extract the project ID from the selected item
            if (!int.TryParse(selectedProject, out int projectId))
            {
                MessageBox.Show("Invalid project ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform the desired action (e.g., save the receipt or display a confirmation)

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string result = client.addFinance(adminData, projectId, hourlyRate, managementCost);
            MessageBox.Show(result,"Generating Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBox1.SelectedIndex = -1; // Reset the combo box selection
            hourlyRate_txtbx.Clear(); // Clear the hourly rate text box
            managementCost_txtbx.Clear(); // Clear the management cost text box
            LoadedRecipt(); // Reload the receipts

            // You can replace the above message box with the actual logic to save the receipt
        }

    }
}
