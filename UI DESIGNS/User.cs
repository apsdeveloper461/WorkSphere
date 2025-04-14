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
        public User()
        {
            InitializeComponent();
        }
   
        DataTable dtUsers = new DataTable();

        private void User_Load(object sender, EventArgs e)
        {


            AddButtonsToGrid();

            tabControl1.TabPages[0].Text = "All Users";
            tabControl1.TabPages[1].Text = "Active Users";
            tabControl1.TabPages[2].Text = "Inactive Users";

            dtUsers.Columns.Add("ID");
            dtUsers.Columns.Add("Name");
            dtUsers.Columns.Add("Email");
            dtUsers.Columns.Add("Role");
            dtUsers.Columns.Add("Status");
            dgvUsers.DataSource = dtUsers;
            dtUsers.Rows.Add(1, "Ali", "ali@example.com", "Admin", "Active");
            dtUsers.Rows.Add(2, "Ahmed", "ahmed@example.com", "User", "Inactive");
            dtUsers.Rows.Add(3, "Sara", "sara@example.com", "Manager", "Active");
            dtUsers.Rows.Add(4, "Ayesha", "ayesha@example.com", "User", "Inactive");
            LoadUsers("All");
        }

        private void LoadUsers(string statusFilter = "All")
        {

            AddButtonsToGrid();
            var users = new List<(int ID, string Name, string Email, string Role, string Status)>
    {
        (1, "Ali", "ali@example.com", "Admin", "Active"),
        (2, "Ahmed", "ahmed@example.com", "User", "Inactive"),
        (3, "Sara", "sara@example.com", "Manager", "Active"),
        (4, "Ayesha", "ayesha@example.com", "User", "Inactive")
    };
            var filteredUsers = users.Where(user => statusFilter == "All" || user.Status == statusFilter);

            foreach (var user in filteredUsers)
            {
                dtUsers.Rows.Add(user.ID, user.Name, user.Email, user.Role, user.Status);
            }

        }




        private void AddButtonsToGrid()
        {
            if (dgvUsers.Columns["Update"] == null && dgvUsers.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Name = "Update";
                btnUpdate.HeaderText = "Update";
                btnUpdate.Text = "Update";
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvUsers.Columns.Add(btnUpdate);

                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvUsers.Columns.Add(btnDelete);
            }
        }


        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string columnName = dgvUsers.Columns[e.ColumnIndex].Name;
                int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["ID"].Value);
                string name = dgvUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string email = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string role = dgvUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                string status = dgvUsers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (columnName == "Update")
                {
                    updateuser updateForm = new updateuser(userId.ToString(),name,email,role,status);
                    updateForm.Show();
                    this.Hide();

                }
                else if (columnName == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgvUsers.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("User deleted successfully.");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Adduser dashboard = new Adduser();
            dashboard.Show();
            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadUsers("Inactive");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            LoadUsers("All Users");
        }

       

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvUsers.Columns[e.ColumnIndex].Name;
                int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["ID"].Value); 

                if (columnName == "Update")
                {
                    string name = dgvUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    string email = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    string role = dgvUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                    string status = dgvUsers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    updateuser updateForm = new updateuser(
                        userId.ToString(),  
                        name,
                        email,
                        role,
                        status
                    );
                    updateForm.ShowDialog();
                }
                else if (columnName == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteUser(userId);
                    }
                }
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
                    LoadUsers("All"); 
                }
                else if (selectedTab == "Active Users")
                {
                    LoadUsers("Active"); 
                }
                else if (selectedTab == "Inactive Users")
                {
                    LoadUsers("Inactive"); 
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadUsers("Active");
        }
    }
}
