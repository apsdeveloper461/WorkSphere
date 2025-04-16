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
    public partial class projects : UserControl
    {
        public projects()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void projects_Load(object sender, EventArgs e)
        {
          
        }
       

    

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedTab = tabControl1.SelectedTab.Text;

            //if (selectedTab == "All Projects")
            //    dataGridView1.DataSource = dtProjects;
            //else
            //{
            //    string status = selectedTab.Contains("Active") ? "Active" : "Completed";
            //    DataView view = new DataView(dtProjects);
            //    view.RowFilter = $"Status = '{status}'";
            //    dataGridView1.DataSource = view;
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addForm = new AddProject();
            addForm.ShowDialog();
        }
    }
}
