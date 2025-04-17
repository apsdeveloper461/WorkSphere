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
    public partial class UpdatePassword : UserControl
    {
        private ServiceReference1.User userData;
        public UpdatePassword(ServiceReference1.User userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long","Form Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(textBox1.Text == textBox2.Text)
            {
                // confirm 
                string message = "Are you sure you want to update your password?";
                string caption = "Confirm Password Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                string res= client.updatePassword(userData,textBox1.Text);
                userData.Password = textBox1.Text;
                MessageBox.Show(res, "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
