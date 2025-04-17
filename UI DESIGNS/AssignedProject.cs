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
    public partial class AssignedProject : UserControl
    {
        private ServiceReference1.User userData;
        public AssignedProject(ServiceReference1.User user)
        {
            InitializeComponent();
            this.userData = user;
        }

        private void AssignedProject_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.projectOnWhichWork(userData);
            dataGridView1.DataSource = projects;
        }
    }
}
