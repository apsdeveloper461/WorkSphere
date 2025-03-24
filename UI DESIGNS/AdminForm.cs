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
        public AdminForm()
        {
            InitializeComponent();
            ShowDashboard(); 
        }

        private void LoadForm(UserControl form)
        {
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
        }

        private void ShowDashboard()
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
            LoadForm(new User());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
