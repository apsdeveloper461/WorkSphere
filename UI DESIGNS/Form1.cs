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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text.Trim();
            string password = textBox1.Text;
            //MessageBox.Show(email + password);  
            if(email.Contains("@") && email.Contains(".com") && password.Length>4)
            {
          
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.User result = service.login(email,password);
                if (result != null)
                {
                    if (result.Role.ToLower() == "admin")
                    {
                        AdminForm adminDasboard = new AdminForm(result);
                        adminDasboard.Show();
                    }
                    //else if (result.Role.ToLower() == "product manager" && result.ActivationStatus == true)
                    //{
                    //    ProductManagerDashbaord productManagerDashbaord = new ProductManagerDashbaord(result);
                    //    productManagerDashbaord.Show();
                    //}
                    //else if (result.Role.ToLower() == "developer" && result.ActivationStatus == true)
                    //{
                    //    DeveloperDashboard developerDashboard = new DeveloperDashboard(result);
                    //    developerDashboard.Show();
                    //}
                    else
                    {
                        MessageBox.Show("Wrong Credentials. Please try again to login WorkSphere", "Invalid Data", MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show( "Wrong Credentials. Please try again to login WorkSphere", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("1. Email must be contains @ and .com.\n2. Password contains atleast 5 characters.", "Invalid Entered Data", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
