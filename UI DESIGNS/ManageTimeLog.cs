using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_DESIGNS.ServiceReference1;

namespace UI_DESIGNS
{
    public partial class ManageTimeLog : UserControl
    {
        private int activeProject;
        private ServiceReference1.User productManager;
        public ManageTimeLog(ServiceReference1.User productManager)
        {
            InitializeComponent();
            this.productManager = productManager;
        }
        private void LoadedProjectIntoComboBox()
        {
            comboBox1.Items.Clear();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            List<ServiceReference1.Project> projects = client.projectOnWhichWork(productManager).ToList();
            foreach (ServiceReference1.Project project in projects)
            {
                comboBox1.Items.Add("(" + project.Id + ")" + project.Title);
            }
        }

        private void LoadedTimeLogs()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.TimeLog[] timeLogs = client.getTimeLogsByProjectId(productManager, activeProject);
            List<ServiceReference1.TimeLog> pendingtimeLogList =new List<ServiceReference1.TimeLog>();
            List<ServiceReference1.TimeLog> OthertimeLogList = new List<ServiceReference1.TimeLog>();
            for (int i = 0; i < timeLogs.Length; i++)
            {
                if (timeLogs[i].Status.ToLower() == "pending")
                {
                    pendingtimeLogList.Add(timeLogs[i]);
                }
                else
                {
                    OthertimeLogList.Add(timeLogs[i]);
                }
            }
            var pendingtimeLogDisplayList = pendingtimeLogList.Select(t => new TimeLogDisplay
            {
                Id = t.Id,
                status = t.Status,
                ProjectName = t.Project.Title,
                DeveloperEmail = t.Developer.Email,
                Hours = t.WorkedHours,
                Description = t.Description,
                Date = t.Date
            }).ToList();
            var OthertimeLogDisplayList = OthertimeLogList.Select(t => new TimeLogDisplay
            {
                Id = t.Id,
                status = t.Status,
                ProjectName = t.Project.Title,
                DeveloperEmail = t.Developer.Email,
                Hours = t.WorkedHours,
                Description = t.Description,
                Date = t.Date
            }).ToList();
            dataGridView1.DataSource = pendingtimeLogDisplayList;
            dataGridView2.DataSource = OthertimeLogDisplayList; 
        }
        private void ManageTimeLog_Load(object sender, EventArgs e)
        {
            LoadedProjectIntoComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate that all required fields are filled
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string selectedProject = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedProject);
            //return;
            // Convert the project ID to an integer
            selectedProject = selectedProject.Substring(1, selectedProject.IndexOf(')') - 1); // Extract the project ID from the selected item
            if (!int.TryParse(selectedProject, out int projectId))
            {

                MessageBox.Show("Invalid project ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            activeProject = projectId;
            
            LoadedTimeLogs();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["approve"].Index)
            {
                string message = "Are you sure you want to approve this time log?";
                string title = "Approve Time Log";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    // Perform the action to approve the time log
                    // You can add your logic here to update the status in the database
                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    string res=client.updateTimeLogStatus(productManager, (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value, "approved");

                    MessageBox.Show(res, "Result of Approved Time Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadedTimeLogs();
                }
            }
            else if(e.ColumnIndex == dataGridView1.Columns["reject"].Index)
            {
                string message = "Are you sure you want to reject this time log?";
                string title = "Reject Time Log";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Perform the action to reject the time log
                    // You can add your logic here to update the status in the database
                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    string res = client.updateTimeLogStatus(productManager, (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value, "reject");
                    MessageBox.Show(res, "Result of Rejected Time Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadedTimeLogs();
                }

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
