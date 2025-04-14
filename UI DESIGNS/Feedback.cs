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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void AddMessage(string message, bool isUser)
        {
           
            Panel msgPanel = new Panel();
            msgPanel.AutoSize = true;
            msgPanel.Padding = new Padding(10);
            msgPanel.Margin = new Padding(10);
            msgPanel.MaximumSize = new Size(300, 0); 
            msgPanel.BackColor = isUser ? Color.LightGreen : Color.WhiteSmoke;

            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.MaximumSize = new Size(280, 0); 
            msgPanel.Controls.Add(lbl);

            msgPanel.Paint += (s, e) =>
            {
                msgPanel.Region = new Region(
                    new System.Drawing.Drawing2D.GraphicsPath()
                    {
                        FillMode = System.Drawing.Drawing2D.FillMode.Winding
                    });
            };
            msgPanel.Anchor = AnchorStyles.Left;
            if (isUser)
            {
                msgPanel.Dock = DockStyle.Right;
            }

            flowChat.Controls.Add(msgPanel);
        }


        private Dictionary<string, List<ChatMessage>> projectChats = new Dictionary<string, List<ChatMessage>>();


        private void FeedbackChatForm_Load(object sender, EventArgs e)
        {
            listBoxProjects.Items.Add("Project A");
            listBoxProjects.Items.Add("Project B");
            listBoxProjects.Items.Add("Project C");

            projectChats["Project A"] = new List<ChatMessage>
    {
        new ChatMessage { Sender = "Admin", Text = "Work started", Timestamp = DateTime.Now.AddMinutes(-10) },
        new ChatMessage { Sender = "User", Text = "Noted", Timestamp = DateTime.Now.AddMinutes(-5) }
    };

            projectChats["Project B"] = new List<ChatMessage>();
        }

        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProject = listBoxProjects.SelectedItem.ToString();
            lblProjectTitle.Text = selectedProject;
            DisplayMessages(selectedProject);
        }

        private void DisplayMessages(string projectName)
        {
            flowChat.Controls.Clear();

            if (!projectChats.ContainsKey(projectName))
                return;

            foreach (var msg in projectChats[projectName])
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.MaximumSize = new Size(250, 0);
                lbl.Text = msg.Text;
                lbl.Padding = new Padding(10);
                lbl.Margin = new Padding(5);

                if (msg.Sender == "Admin")
                {
                    lbl.BackColor = Color.LightGreen;
                    lbl.TextAlign = ContentAlignment.MiddleRight;
                    lbl.Anchor = AnchorStyles.Right;
                }
                else
                {
                    lbl.BackColor = Color.LightBlue;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Anchor = AnchorStyles.Left;
                }

                flowChat.Controls.Add(lbl);
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void panelProjects_Paint(object sender, PaintEventArgs e)
        {
            Panel panelProjects = new Panel();
            panelProjects.Size = new Size(300, 600);
            panelProjects.Dock = DockStyle.Left;
            panelProjects.BackColor = Color.FromArgb(240, 240, 240);
            this.Controls.Add(panelProjects);

        }

        private void panelChat_Paint(object sender, PaintEventArgs e)
        {
            Panel panelChat = new Panel();
            panelChat.Dock = DockStyle.Fill;
            panelChat.BackColor = Color.White;
            this.Controls.Add(panelChat);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lblProjectTitle = new Label();
            lblProjectTitle.Text = "Project Name";
            lblProjectTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblProjectTitle.Dock = DockStyle.Top;
            lblProjectTitle.Height = 50;
            lblProjectTitle.Padding = new Padding(10, 10, 0, 0);
            panelChat.Controls.Add(lblProjectTitle);
        }
        public class ChatMessage
        {
            public string Sender { get; set; }
            public string Text { get; set; }
            public DateTime Timestamp { get; set; }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(msg))
            {
                AddMessage(msg, true); 
                txtMessage.Clear();

                AddMessage("Thank you for your feedback!", false); 
            }

            if (listBoxProjects.SelectedItem == null || string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            string selectedProject = listBoxProjects.SelectedItem.ToString();
            string messageText = txtMessage.Text;

            var newMessage = new ChatMessage
            {
                Sender = "Admin",
                Text = messageText,
                Timestamp = DateTime.Now
            };

            projectChats[selectedProject].Add(newMessage);
            txtMessage.Clear();
            DisplayMessages(selectedProject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
