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
    public partial class ProductManagerForm : Form
    {
        private ServiceReference1.User productManagerdata;
        public ProductManagerForm(ServiceReference1.User productManagerdata)
        {
            InitializeComponent();
            this.productManagerdata = productManagerdata;
            ShowDashboard();
        }
        private void LoadForm(UserControl form)
        {
            panel1.Controls.Clear();

            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
        }
        private void ProductManagerForm_Load(object sender, EventArgs e)
        {

        }
        public void ShowDashboard()
        {
            panel1.Controls.Clear();
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome, " + productManagerdata.Name + " !";
            lblWelcome.Font = new Font("Arial", 24, FontStyle.Bold);
            lblWelcome.ForeColor = Color.MediumTurquoise;
            lblWelcome.AutoSize = true;

            lblWelcome.Location = new Point(
                (panel1.Width - lblWelcome.PreferredWidth) / 2,
                panel1.Height / 10
            );

            panel1.Controls.Add(lblWelcome);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadForm(new FeedbackChatBox(productManagerdata));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
        "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Form1 loginForm = new Form1();
                //loginForm.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageTimeLog(productManagerdata));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new AssignedProject(productManagerdata));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdatePassword(productManagerdata));
        }
    }
}
