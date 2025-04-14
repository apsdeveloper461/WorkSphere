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
        DataTable dtProjects = new DataTable();
        private void projects_Load(object sender, EventArgs e)
        {
            AddButtonsToGrid();
            tabControl1.Text = "All Projects";
            tabControl1.Text = "Active Projects";
            tabControl1.Text = "Completed Projects";

            dtProjects.Columns.Add("ID");
            dtProjects.Columns.Add("Title");
            dtProjects.Columns.Add("Description");
            dtProjects.Columns.Add("AssignedTo");
            dtProjects.Columns.Add("Status");
            dataGridView1.DataSource = dtProjects;

            AddDummyProjects();      
            AddButtonsToGrid();
        }
        private void AddButtonsToGrid()
        {
            if (dataGridView1.Columns["Update"] == null && dataGridView1.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn updateBtn = new DataGridViewButtonColumn();
                updateBtn.Name = "Update";
                updateBtn.Text = "Update";
                updateBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(updateBtn);

                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteBtn);
            }
        }

        private void AddDummyProjects()
        {
            dtProjects.Rows.Add("1", "Website", "Build frontend", "Ali", "Active");
            dtProjects.Rows.Add("2", "App", "Mobile app", "Sara", "Completed");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Text;

            if (selectedTab == "All Projects")
                dataGridView1.DataSource = dtProjects;
            else
            {
                string status = selectedTab.Contains("Active") ? "Active" : "Completed";
                DataView view = new DataView(dtProjects);
                view.RowFilter = $"Status = '{status}'";
                dataGridView1.DataSource = view;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string col = dataGridView1.Columns[e.ColumnIndex].Name;

                if (col == "Update")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    string title = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    string desc = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    string assigned = dataGridView1.Rows[e.RowIndex].Cells["AssignedTo"].Value.ToString();
                    string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    UpdateProject updateForm = new UpdateProject();
                    updateForm.ShowDialog();
                }
                else if (col == "Delete")
                {
                    if (MessageBox.Show("Delete this project?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addForm = new AddProject();
            addForm.ShowDialog();
        }
    }
}
