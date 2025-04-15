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
    public partial class AdminForm : Form
    {
        private ServiceReference1.User adminData;
        public AdminForm(ServiceReference1.User adminData)
        {
            InitializeComponent();
            ShowDashboard();
            this.adminData = adminData;
        }

        private void LoadForm(UserControl form)
        {
            panel1.Controls.Clear();

            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
        }

        public void ShowDashboard()
        {
            panel1.Controls.Clear();
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome, Admin!";
            lblWelcome.Font = new Font("Arial", 24, FontStyle.Bold);
            lblWelcome.ForeColor = Color.MediumTurquoise;
            lblWelcome.AutoSize = true;

            lblWelcome.Location = new Point(
                (panel1.Width - lblWelcome.PreferredWidth) / 2,
                panel1.Height / 10
            );

            panel1.Controls.Add(lblWelcome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new User(adminData));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new projects());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadForm(new Receipt());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Feedback fb = new Feedback();
            fb.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadForm(new Finance());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
        "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}