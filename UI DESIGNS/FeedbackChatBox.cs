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
    public partial class FeedbackChatBox : UserControl
    {
        public ServiceReference1.User admin;
        private ServiceReference1.Project activeProject;
        private List<ServiceReference1.Project> projectsData = new List<ServiceReference1.Project>();

        public FeedbackChatBox(ServiceReference1.User admin)
        {
            InitializeComponent();
            this.admin = admin;

            // Enable auto-scroll for the messagesContainerPanel
            messagesContainerPanel.AutoScroll = true;
        }

        private void LoadedProject()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.displayProject(admin);
            if (projectBindingSource != null)
            {
                dataGridView1.DataSource = projects;
                projectsData = projects.ToList();
            }
        }

        private void AppendMessage(string sender, string messageText)
        {
            // Create an instance of the Message user control
            message messageControl = new message(sender == admin.Email,sender, messageText);
            // Adjust the alignment based on the sender's email
            if (sender == admin.Email)
            {
                messageControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }
            else
            {
                messageControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            // Add the message control to the messagesContainerPanel
            messagesContainerPanel.Controls.Add(messageControl);

            // Ensure the panel scrolls to the bottom if the messages overflow
            messagesContainerPanel.ScrollControlIntoView(messageControl);
        }

        private void LoadedChatData()
        {
            messagesContainerPanel.Controls.Clear();
            chat_name.Text = activeProject.Title;
            for (int i = 0; i < 10; i++)
            {
                AppendMessage("amabr@gmail.com", "This is my message");
            }
        }

        private void FeedbackChatBox_Load(object sender, EventArgs e)
        {
            LoadedProject();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["title"].Index)
            {
                int projectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                activeProject = projectsData.FirstOrDefault(p => p.Id == projectId);
                LoadedChatData();
                MessageBox.Show("Project ID: " + projectId.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SendingMessage_txtbx.Text.Length > 0)
            {
                MessageBox.Show(activeProject.Id + SendingMessage_txtbx.Text + admin.Id);
                AppendMessage(admin.Email, SendingMessage_txtbx.Text);
            }
        }
    }
}
