namespace UI_DESIGNS
{
    partial class FeedbackChatBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messagesContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_Chat = new System.Windows.Forms.Button();
            this.chat_name = new System.Windows.Forms.Label();
            this.SendingMessage_txtbx = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(269, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // messagesContainerPanel
            // 
            this.messagesContainerPanel.Location = new System.Drawing.Point(272, 55);
            this.messagesContainerPanel.Name = "messagesContainerPanel";
            this.messagesContainerPanel.Size = new System.Drawing.Size(939, 569);
            this.messagesContainerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.refresh_Chat);
            this.panel1.Controls.Add(this.chat_name);
            this.panel1.Location = new System.Drawing.Point(273, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 51);
            this.panel1.TabIndex = 2;
            // 
            // refresh_Chat
            // 
            this.refresh_Chat.Location = new System.Drawing.Point(869, 0);
            this.refresh_Chat.Name = "refresh_Chat";
            this.refresh_Chat.Size = new System.Drawing.Size(72, 51);
            this.refresh_Chat.TabIndex = 17;
            this.refresh_Chat.Text = "Refresh";
            this.refresh_Chat.UseVisualStyleBackColor = true;
            this.refresh_Chat.Click += new System.EventHandler(this.refresh_Chat_Click);
            // 
            // chat_name
            // 
            this.chat_name.AutoSize = true;
            this.chat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_name.Location = new System.Drawing.Point(19, 11);
            this.chat_name.Name = "chat_name";
            this.chat_name.Size = new System.Drawing.Size(141, 25);
            this.chat_name.TabIndex = 0;
            this.chat_name.Text = "Project Name";
            // 
            // SendingMessage_txtbx
            // 
            this.SendingMessage_txtbx.Location = new System.Drawing.Point(272, 633);
            this.SendingMessage_txtbx.Multiline = true;
            this.SendingMessage_txtbx.Name = "SendingMessage_txtbx";
            this.SendingMessage_txtbx.Size = new System.Drawing.Size(842, 41);
            this.SendingMessage_txtbx.TabIndex = 3;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sendMessageButton.FlatAppearance.BorderSize = 0;
            this.sendMessageButton.Location = new System.Drawing.Point(1120, 633);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(91, 41);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(UI_DESIGNS.ServiceReference1.Project);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 7;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 130;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 7;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 170;
            // 
            // FeedbackChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.SendingMessage_txtbx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagesContainerPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FeedbackChatBox";
            this.Size = new System.Drawing.Size(1217, 678);
            this.Load += new System.EventHandler(this.FeedbackChatBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.FlowLayoutPanel messagesContainerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label chat_name;
        private System.Windows.Forms.TextBox SendingMessage_txtbx;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button refresh_Chat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}
