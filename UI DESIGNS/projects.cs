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
    public partial class projects : UserControl
    {
        private ServiceReference1.User adminData;
        private List<ServiceReference1.Project> projectData = new List<ServiceReference1.Project>();
        public projects(ServiceReference1.User admin)
        {
            InitializeComponent();
            this.adminData = admin;
        }
        private void LoadUsers()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.User[] users = client.displayUsers(adminData);
            if (users != null)
            {
                // Clear existing items
                listBox1.Items.Clear();
                checkedListBox1.Items.Clear();
                //loaded users into list box

                foreach (ServiceReference1.User user in users)
                {
                    if (user.WorkingStatus == false && user.ActivationStatus == true)
                    {
                        if (user.Role == "product manager")
                            listBox1.Items.Add(user.Email);
                        else if (user.Role == "developer")
                            checkedListBox1.Items.Add(user.Email);

                    }
                }
            }
            else
            {

                MessageBox.Show("No users found");
            }
           
        }
        private void LoadProjects()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.displayProject(adminData);
            projectData = projects.ToList();
        }

        private void LoadedIntoDataSetProjects(string s)
        {
            List<ServiceReference1.Project> projects = new List<ServiceReference1.Project>();
            for (int i = 0; i < projectData.Count; i++)
            {
                if (s.ToLower() == "all")
                {
                    projects.Add(projectData[i]);
                }else if (s.ToLower() == "active")
                {
                    if (projectData[i].Status == true)
                    {
                        projects.Add(projectData[i]);
                    }
                }
                else if (s.ToLower() == "completed")
                {
                    if (projectData[i].Status == false)
                    {
                        projects.Add(projectData[i]);
                    }
                }
            }
            if(projects.Count > 0)
            {
                if(s.ToLower() == "all")
                {
                    dataGridView_for_all.DataSource = projects;
                }
                else if (s.ToLower() == "active")
                {
                    dataGridView_for_active.DataSource = projects;
                }
                else if (s.ToLower() == "completed")
                {
                    dataGridView_for_complete.DataSource = projects;
                }
            }
            //else
            //{
            //    MessageBox.Show("No projects found");
            //}
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void projects_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadProjects();
            LoadedIntoDataSetProjects("all");

        }
       

    

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Text;

            if (selectedTab == "All Projects")
                LoadedIntoDataSetProjects("all");
            else if(selectedTab == "Selected Projects")
            {
                LoadedIntoDataSetProjects("active");
            }
            else if (selectedTab == "Completed Projects")
            {
                LoadedIntoDataSetProjects("completed");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addForm = new AddProject();
            addForm.ShowDialog();
        }

        private void dataGridView_for_active_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_for_active.Columns["viewUsers_active"].Index)
            {
                int projectId = Convert.ToInt32(dataGridView_for_active.Rows[e.RowIndex].Cells["id_active"].Value);
                MessageBox.Show(projectId.ToString());
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                List<ServiceReference1.User> users = new List<ServiceReference1.User>();
                // Get the users assigned to the project
                foreach (var item in projectData)
                {
                    if (item.Id == projectId)
                    {
                        users = item.AssignedTo.ToList();
                        break;
                    }

                }

                dataGridView_for_users.DataSource = users;
            }
        }

        private void dataGridView_for_all_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_for_all.Columns["viewUsers"].Index)
            {
                int projectId = Convert.ToInt32(dataGridView_for_all.Rows[e.RowIndex].Cells["id"].Value);
                MessageBox.Show(projectId.ToString());
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                List<ServiceReference1.User> users = new List<ServiceReference1.User>();
                // Get the users assigned to the project
                foreach (var item in projectData)
                {
                    if (item.Id == projectId)
                    {
                        users = item.AssignedTo.ToList();
                        break;
                    }

                }

                dataGridView_for_users.DataSource = users;
            }
        }

        private void dataGridView_for_complete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_for_complete.Columns["viewUsers_complete"].Index)
            {
                int projectId = Convert.ToInt32(dataGridView_for_complete.Rows[e.RowIndex].Cells["id_complete"].Value);
                MessageBox.Show(projectId.ToString());
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                List<ServiceReference1.User> users = new List<ServiceReference1.User>();
                // Get the users assigned to the project
                foreach (var item in projectData)
                {
                    if (item.Id == projectId)
                    {
                        users = item.AssignedTo.ToList();
                        break;
                    }

                }

                dataGridView_for_users.DataSource = users;
            }
        }
    }
}
