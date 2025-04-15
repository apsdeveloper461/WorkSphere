using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace UI_DESIGNS
{
    public partial class User : UserControl
    {
        private ServiceReference1.User adminData;
        public User(ServiceReference1.User admin)
        {
            InitializeComponent();
            this.adminData = admin;
        }
        public List<ServiceReference1.User> usersData=new List<ServiceReference1.User>();
        private void LoadUsers()
        {
            if (adminData == null)
            {
                MessageBox.Show("Admin data is null");
                return;
            }
            else
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                ServiceReference1.User[] users = client.displayUsers(adminData);
                if (users != null)
                {
                    usersData= users.ToList();
                }
                else
                {
                    MessageBox.Show("No users found");
                }

            }
        }
        private void LoadedUsersInToDataSet(string s)
        {
            List<ServiceReference1.User> users = new List<ServiceReference1.User>();
            for (int i = 0; i < usersData.Count; i++)
            {
                if (s.ToLower() == "all")
                {
                    users.Add(usersData[i]);
                }
                else if (s.ToLower() == "active")
                {
                    if (usersData[i].ActivationStatus == true)
                    {
                        users.Add(usersData[i]);
                    }
                }
                else if (s.ToLower() == "inactive")
                {
                    if (usersData[i].ActivationStatus == false)
                    {
                        users.Add(usersData[i]);
                    }
                }
            }
            if (users.Count > 0)
            {
                if(s.ToLower()=="all")
                    dgvUsers.DataSource = users;
                else if(s.ToLower() == "active")
                    dataGridView_for_active.DataSource = users;
                else if (s.ToLower() == "inactive")
                    dataGridView_for_inactive.DataSource = users;
                //"Total Users: " + users.Count.ToString();
            }
            else
            {
                MessageBox.Show("No users found");
            }
        }


        private void User_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadedUsersInToDataSet("all");


        }

        




     


        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Adduser dashboard = new Adduser();
            dashboard.Show();
            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadedUsersInToDataSet("Inactive");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            LoadedUsersInToDataSet("all");
        }

       

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void DeleteUser(int userId)
        {
           
            MessageBox.Show($"User with ID {userId} deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Users_Load(object sender, EventArgs e)
        //{
        //    LoadUsers(); 
        //}

       


        private void lblTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                string selectedTab = tabControl1.SelectedTab.Text;

                if (selectedTab == "All Users")
                {
                    LoadedUsersInToDataSet("All");
                }
                else if (selectedTab == "Active Users")
                {
                    LoadedUsersInToDataSet("Active"); 
                }
                else if (selectedTab == "Inactive Users")
                {
                    LoadedUsersInToDataSet("Inactive"); 
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadedUsersInToDataSet("Active");
        }
    }
}
