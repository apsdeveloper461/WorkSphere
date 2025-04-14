namespace UI_DESIGNS
{
    partial class Feedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelProjects = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panelProjects.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProjects
            // 
            this.panelProjects.BackColor = System.Drawing.Color.LightGray;
            this.panelProjects.Controls.Add(this.button1);
            this.panelProjects.Controls.Add(this.listBoxProjects);
            this.panelProjects.Controls.Add(this.label1);
            this.panelProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProjects.Location = new System.Drawing.Point(0, 0);
            this.panelProjects.Name = "panelProjects";
            this.panelProjects.Size = new System.Drawing.Size(271, 561);
            this.panelProjects.TabIndex = 0;
            this.panelProjects.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProjects_Paint);
            // 
            // panelChat
            // 
            this.panelChat.Controls.Add(this.panel1);
            this.panelChat.Controls.Add(this.panelHeader);
            this.panelChat.Location = new System.Drawing.Point(265, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(718, 560);
            this.panelChat.TabIndex = 1;
            this.panelChat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChat_Paint);
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Location = new System.Drawing.Point(29, 29);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(35, 13);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "label1";
            this.lblProjectTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(0, 75);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(268, 485);
            this.listBoxProjects.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelHeader.Controls.Add(this.flowChat);
            this.panelHeader.Controls.Add(this.lblProjectTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(718, 75);
            this.panelHeader.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 483);
            this.panel1.TabIndex = 2;
            // 
            // flowChat
            // 
            this.flowChat.Location = new System.Drawing.Point(0, 73);
            this.flowChat.Name = "flowChat";
            this.flowChat.Size = new System.Drawing.Size(715, 447);
            this.flowChat.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(623, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(0, 428);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(715, 51);
            this.txtMessage.TabIndex = 0;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.panelProjects.ResumeLayout(false);
            this.panelProjects.PerformLayout();
            this.panelChat.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProjects;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMessage;
    }
}