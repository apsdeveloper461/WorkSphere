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
using System.Runtime.Remoting.Lifetime;

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
            if (e.ColumnIndex == dgvUsers.Columns["Update"].Index)
            {
                const string message = "Are you sure you want to update this user?";
                const string caption = "Update User";
                var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    // Update user logic
                    int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["id"].Value);
                    string userName = dgvUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    string userEmail = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    string userRole = dgvUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                    string password = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    bool isActive = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["activationStatus"].Value);
                    if (userName.Trim().Length > 5 && userEmail.Contains("@") && userEmail.Contains(".com") && userRole != "" && password.Length > 5)
                    {
                        if (userRole == "developer" || userRole == "product manager")
                        {

                            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                            string result = client.updateUser(adminData, userId, userRole, userName, userEmail, password, isActive);
                            MessageBox.Show(result);
                        }
                        else
                        {
                            MessageBox.Show("You can only update role to developer or product manager.", "Limitation of Role Updation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("1. Name must me greater than 5 character.\n2. Email must contains @ and .com.\n3.Password also greater than 5 characters", "Please fill all the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LoadUsers();
                LoadedUsersInToDataSet("all");
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text + textBox2.Text + comboBox1.Text);
            if (textBox1.Text.Trim().Length > 5 && textBox2.Text.Contains("@") && textBox2.Text.Contains(".com") && comboBox1.Text != "")
            {
                //MessageBox.Show(adminData.Role);
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                string res = client.addNewUser(adminData, comboBox1.Text.ToLower(), textBox1.Text, textBox2.Text, "password", true);
                MessageBox.Show(res);
                LoadUsers();
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
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Text = "";

                }

            }
            else
            {
                MessageBox.Show("1. Name must me greater than 5 character.\n2. Email must contains @ and .com. \n3. Select one of the option for role. ", "Please fill all the fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_for_active_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_for_active.Columns["Update_active"].Index)
            {
                const string message = "Are you sure you want to update this user?";
                const string caption = "Update User";
                var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    // Update user logic
                    int userId = Convert.ToInt32(dataGridView_for_active.Rows[e.RowIndex].Cells["id_active"].Value);
                    string userName = dataGridView_for_active.Rows[e.RowIndex].Cells["Name_active"].Value.ToString();
                    string userEmail = dataGridView_for_active.Rows[e.RowIndex].Cells["Email_active"].Value.ToString();
                    string userRole = dataGridView_for_active.Rows[e.RowIndex].Cells["Role_active"].Value.ToString();
                    string password = dataGridView_for_active.Rows[e.RowIndex].Cells["Password_active"].Value.ToString();
                    bool isActive = Convert.ToBoolean(dataGridView_for_active.Rows[e.RowIndex].Cells["activationStatus_active"].Value);
                    //bool workingStatus = Convert.ToBoolean(dataGridView_for_active.Rows[e.RowIndex].Cells["workingStatus_active"].Value);
                    if (userName.Trim().Length > 5 && userEmail.Contains("@") && userEmail.Contains(".com") && userRole != "" && password.Length > 5)
                    {

                        if (userRole == "developer" || userRole == "product manager")
                        {

                            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                            string result = client.updateUser(adminData, userId, userRole, userName, userEmail, password, isActive);
                            MessageBox.Show(result);
                           
                        }
                        else
                        {
                            MessageBox.Show("You can only update role to developer or product manager.", "Limitation of Role Updation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("1. Name must me greater than 5 character.\n2. Email must contains @ and .com.\n3.Password also greater than 5 characters", "Please fill all the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadUsers();
                LoadedUsersInToDataSet("Active");
            }
        }

        private void dataGridView_for_inactive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_for_inactive.Columns["Update_inactive"].Index)
            {
                const string message = "Are you sure you want to update this user?";
                const string caption = "Update User";
                var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    // Update user logic
                    int userId = Convert.ToInt32(dataGridView_for_inactive.Rows[e.RowIndex].Cells["id_inactive"].Value);
                    string userName = dataGridView_for_inactive.Rows[e.RowIndex].Cells["Name_inactive"].Value.ToString();
                    string userEmail = dataGridView_for_inactive.Rows[e.RowIndex].Cells["Email_inactive"].Value.ToString();
                    string userRole = dataGridView_for_inactive.Rows[e.RowIndex].Cells["Role_inactive"].Value.ToString();
                    string password = dataGridView_for_inactive.Rows[e.RowIndex].Cells["Password_inactive"].Value.ToString();
                    bool isActive = Convert.ToBoolean(dataGridView_for_inactive.Rows[e.RowIndex].Cells["activationStatus_inactive"].Value);
                    if (userName.Trim().Length > 5 && userEmail.Contains("@") && userEmail.Contains(".com") && userRole != "" && password.Length > 5)
                    {
                        if (userRole == "developer" || userRole == "product manager")
                        {

                            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                            string result = client.updateUser(adminData, userId, userRole, userName, userEmail, password, isActive);
                            MessageBox.Show(result);
                          
                        }
                        else
                        {
                            MessageBox.Show("You can only update role to developer or product manager.", "Limitation of Role Updation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("1. Name must me greater than 5 character.\n2. Email must contains @ and .com.\n3.Password also greater than 5 characters", "Please fill all the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadUsers();
                LoadedUsersInToDataSet("Inactive");
            }

        }
    }
}
