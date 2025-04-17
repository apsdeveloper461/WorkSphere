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

        private void LoadedTimeLog(string s)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.TimeLog[] timeLogs = client.getTimeLogsByUserId(developer);
            if (s.ToLower() == "all")
            {
                timeLogs = timeLogs.ToArray();
            }
            else if (s.ToLower() == "pending")
            {
                timeLogs = timeLogs.Where(t => t.Status.ToLower() == "pending").ToArray();
            }
            else if (s.ToLower() == "approved")
            {
                timeLogs = timeLogs.Where(t => t.Status.ToLower() == "approved").ToArray();
            }
            else if (s.ToLower() == "reject")
            {
                timeLogs = timeLogs.Where(t => t.Status.ToLower() == "rejected").ToArray();
            }

            var timeLogDisplayList = timeLogs.Select(t => new TimeLogDisplay
            {
                Id = t.Id,
                status = t.Status,
                ProjectName = t.Project.Title,
                DeveloperEmail = t.Developer.Email,
                Hours = t.WorkedHours,
                Description = t.Description,
                Date = t.Date
            }).ToList();
            if (s.StartsWith("all"))
            {
                dataGridView1.DataSource = timeLogDisplayList;
            }
            else if (s.StartsWith("pending"))
            {
                dataGridView2.DataSource = timeLogDisplayList;
            }
            else if (s.StartsWith("approved"))
            {
                dataGridView3.DataSource = timeLogDisplayList;
            }
            else if (s.StartsWith("reject"))
            {
                dataGridView4.DataSource = timeLogDisplayList;
            }
        }

        private void AddTimeLog_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.projectCurrentlyOnWhichWork(developer);
            if (projects != null)
            {
                foreach (ServiceReference1.Project project in projects)
                {
                    comboBox1.Items.Add("(" + project.Id + ")" + project.Title);

                }
            }
            LoadedTimeLog("all");
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
            DateTime selectedDate = date_picker.Value;
            // If all fields are valid, proceed with the desired action
            string selectedProject = comboBox1.SelectedItem.ToString();
            // Convert the project ID to an integer
            selectedProject = selectedProject.Substring(1, selectedProject.IndexOf(')') - 1); // Extract the project ID from the selected item
            if (!int.TryParse(selectedProject, out int projectId))
            {

                MessageBox.Show("Invalid project ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = description_txtbx.Text;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string result = client.addTimeLog(developer, projectId, description, hours, "pending", selectedDate);
            MessageBox.Show(result, "Time Log Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadedTimeLog("all");
            LoadedTimeLog("pending");
            // Example action: Display a message box with the entered information
            MessageBox.Show($"Project: {selectedProject}\nTime Spent: {hours}\nDescription: {selectedDate}", "Time Log Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // You can replace the above message box with the actual logic to save the time log
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            LoadedTimeLog("all");
        }

        private void tabControl2_Click(object sender, EventArgs e)
        {
            LoadedTimeLog("all");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadedTimeLog("pending");
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadedTimeLog("approved");
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            LoadedTimeLog("reject");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                string selectedTab = tabControl1.SelectedTab.Text;

                if (selectedTab.ToLower() == "all")
                {
                    LoadedTimeLog("all");
                }
                else if (selectedTab.ToLower() == "pending")
                {
                    LoadedTimeLog("pending");
                }
                else if (selectedTab.ToLower() == "approved")
                {
                    LoadedTimeLog("approved");
                }
                else if (selectedTab.ToLower() == "reject")
                {
                    LoadedTimeLog("reject");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}