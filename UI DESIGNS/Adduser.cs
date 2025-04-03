using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_DESIGNS
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Admin", "User", "Manager" });
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new string[] { "Active", "Inactive" });
            comboBox2.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is AdminForm adminForm) 
            {
                adminForm.Show(); 
                adminForm.ShowDashboard(); 
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string role = comboBox1.SelectedItem.ToString();
            string status = comboBox2.SelectedItem.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"User Added Successfully!\n\nID: {id}\nName: {name}\nEmail: {email}\nRole: {role}\nStatus: {status}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
