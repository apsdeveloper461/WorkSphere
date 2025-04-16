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
        public ServiceReference1.User userData;
        private ServiceReference1.Project activeProject;
        private List<ServiceReference1.Project> projectsData = new List<ServiceReference1.Project>();

        public FeedbackChatBox(ServiceReference1.User user)
        {
            InitializeComponent();
            this.userData = user;

            // Enable auto-scroll for the messagesContainerPanel
            messagesContainerPanel.AutoScroll = true;
        }

        private void LoadedProject()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.Project[] projects = client.displayProject(userData);
            if (projectBindingSource != null)
            {
                dataGridView1.DataSource = projects;
                projectsData = projects.ToList();
            }
        }

        private void AppendMessage(string sender, string messageText)
        {
            // Create an instance of the Message user control
            message messageControl = new message(sender == userData.Email,sender, messageText);
            // Adjust the alignment based on the sender's email
            if (sender == userData.Email)
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
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            messagesContainerPanel.Controls.Clear();
            chat_name.Text = activeProject.Title;
            List<ServiceReference1.Feedback> feedbacks=client.getFeedbacks(userData,activeProject.Id).ToList();
            foreach (var item in feedbacks)
            {
                AppendMessage(item.SenderEmail, item.Message);
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
                //MessageBox.Show("Project ID: " + projectId.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SendingMessage_txtbx.Text.Length > 0)
            {
                MessageBox.Show(activeProject.Id + SendingMessage_txtbx.Text + userData.Id);
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                string res=client.addNewFeedback(userData, activeProject.Id, SendingMessage_txtbx.Text);
                if (res.ToLower() != "yes")
                {
                    MessageBox.Show(res,"Error in sending Feedback",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                AppendMessage(userData.Email, SendingMessage_txtbx.Text);
                SendingMessage_txtbx.Text = string.Empty;

                }
            }
        }

        private void refresh_Chat_Click(object sender, EventArgs e)
        {
            if(activeProject != null)
            {
            LoadedChatData();
            }
        }
    }
}
