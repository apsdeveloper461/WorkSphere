namespace UI_DESIGNS
{
    partial class User
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_for_active = new System.Windows.Forms.DataGridView();
            this.dataGridView_for_inactive = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.activationStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.working = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activationStatus_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.update_active = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingStatus_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ActivationStatus_inactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.update_inactive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingStatus_inactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_inactive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddUser.Location = new System.Drawing.Point(1454, 48);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(196, 28);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 148);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 514);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUsers);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1421, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activationStatus,
            this.update,
            this.id,
            this.name,
            this.email,
            this.password,
            this.role,
            this.working});
            this.dgvUsers.DataSource = this.userBindingSource1;
            this.dgvUsers.Location = new System.Drawing.Point(-9, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 53;
            this.dgvUsers.Size = new System.Drawing.Size(1433, 491);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(UI_DESIGNS.ServiceReference1.User);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_for_active);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1421, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_for_inactive);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1421, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inactive Users";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Users ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UI_DESIGNS.ServiceReference1.User);
            // 
            // dataGridView_for_active
            // 
            this.dataGridView_for_active.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_for_active.AutoGenerateColumns = false;
            this.dataGridView_for_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_active.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activationStatus_active,
            this.update_active,
            this.id_active,
            this.name_active,
            this.email_active,
            this.password_active,
            this.role_active,
            this.workingStatus_active});
            this.dataGridView_for_active.DataSource = this.userBindingSource1;
            this.dataGridView_for_active.Location = new System.Drawing.Point(-6, -3);
            this.dataGridView_for_active.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_for_active.Name = "dataGridView_for_active";
            this.dataGridView_for_active.RowHeadersWidth = 53;
            this.dataGridView_for_active.Size = new System.Drawing.Size(1433, 491);
            this.dataGridView_for_active.TabIndex = 1;
            this.dataGridView_for_active.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_for_active_CellContentClick);
            // 
            // dataGridView_for_inactive
            // 
            this.dataGridView_for_inactive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_for_inactive.AutoGenerateColumns = false;
            this.dataGridView_for_inactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_inactive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivationStatus_inactive,
            this.update_inactive,
            this.id_inactive,
            this.name_inactive,
            this.email_inactive,
            this.password_inactive,
            this.role_inactive,
            this.workingStatus_inactive});
            this.dataGridView_for_inactive.DataSource = this.userBindingSource1;
            this.dataGridView_for_inactive.Location = new System.Drawing.Point(-6, -3);
            this.dataGridView_for_inactive.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_for_inactive.Name = "dataGridView_for_inactive";
            this.dataGridView_for_inactive.RowHeadersWidth = 53;
            this.dataGridView_for_inactive.Size = new System.Drawing.Size(1433, 491);
            this.dataGridView_for_inactive.TabIndex = 1;
            this.dataGridView_for_inactive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_for_inactive_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "developer",
            "product manager"});
            this.comboBox1.Location = new System.Drawing.Point(546, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(340, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 10;
            // 
            // activationStatus
            // 
            this.activationStatus.DataPropertyName = "ActivationStatus";
            this.activationStatus.HeaderText = "ActivationStatus";
            this.activationStatus.MinimumWidth = 7;
            this.activationStatus.Name = "activationStatus";
            this.activationStatus.Width = 130;
            // 
            // update
            // 
            this.update.HeaderText = "Update";
            this.update.MinimumWidth = 7;
            this.update.Name = "update";
            this.update.Text = "update";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 130;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 7;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 130;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 7;
            this.name.Name = "name";
            this.name.Width = 130;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 7;
            this.email.Name = "email";
            this.email.Width = 130;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 7;
            this.password.Name = "password";
            this.password.Width = 130;
            // 
            // role
            // 
            this.role.DataPropertyName = "Role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 7;
            this.role.Name = "role";
            this.role.Width = 130;
            // 
            // working
            // 
            this.working.DataPropertyName = "WorkingStatus";
            this.working.HeaderText = "WorkingStatus";
            this.working.MinimumWidth = 7;
            this.working.Name = "working";
            this.working.Width = 130;
            // 
            // activationStatus_active
            // 
            this.activationStatus_active.DataPropertyName = "ActivationStatus";
            this.activationStatus_active.HeaderText = "ActivationStatus";
            this.activationStatus_active.MinimumWidth = 7;
            this.activationStatus_active.Name = "activationStatus_active";
            this.activationStatus_active.Width = 130;
            // 
            // update_active
            // 
            this.update_active.HeaderText = "Update";
            this.update_active.MinimumWidth = 7;
            this.update_active.Name = "update_active";
            this.update_active.Text = "update";
            this.update_active.UseColumnTextForButtonValue = true;
            this.update_active.Width = 130;
            // 
            // id_active
            // 
            this.id_active.DataPropertyName = "Id";
            this.id_active.HeaderText = "Id";
            this.id_active.MinimumWidth = 7;
            this.id_active.Name = "id_active";
            this.id_active.ReadOnly = true;
            this.id_active.Width = 130;
            // 
            // name_active
            // 
            this.name_active.DataPropertyName = "Name";
            this.name_active.HeaderText = "Name";
            this.name_active.MinimumWidth = 7;
            this.name_active.Name = "name_active";
            this.name_active.Width = 130;
            // 
            // email_active
            // 
            this.email_active.DataPropertyName = "Email";
            this.email_active.HeaderText = "Email";
            this.email_active.MinimumWidth = 7;
            this.email_active.Name = "email_active";
            this.email_active.Width = 130;
            // 
            // password_active
            // 
            this.password_active.DataPropertyName = "Password";
            this.password_active.HeaderText = "Password";
            this.password_active.MinimumWidth = 7;
            this.password_active.Name = "password_active";
            this.password_active.Width = 130;
            // 
            // role_active
            // 
            this.role_active.DataPropertyName = "Role";
            this.role_active.HeaderText = "Role";
            this.role_active.MinimumWidth = 7;
            this.role_active.Name = "role_active";
            this.role_active.Width = 130;
            // 
            // workingStatus_active
            // 
            this.workingStatus_active.DataPropertyName = "WorkingStatus";
            this.workingStatus_active.HeaderText = "WorkingStatus";
            this.workingStatus_active.MinimumWidth = 7;
            this.workingStatus_active.Name = "workingStatus_active";
            this.workingStatus_active.Width = 130;
            // 
            // ActivationStatus_inactive
            // 
            this.ActivationStatus_inactive.DataPropertyName = "ActivationStatus";
            this.ActivationStatus_inactive.HeaderText = "ActivationStatus";
            this.ActivationStatus_inactive.MinimumWidth = 7;
            this.ActivationStatus_inactive.Name = "ActivationStatus_inactive";
            this.ActivationStatus_inactive.Width = 130;
            // 
            // update_inactive
            // 
            this.update_inactive.HeaderText = "Update";
            this.update_inactive.MinimumWidth = 7;
            this.update_inactive.Name = "update_inactive";
            this.update_inactive.Text = "update";
            this.update_inactive.UseColumnTextForButtonValue = true;
            this.update_inactive.Width = 130;
            // 
            // id_inactive
            // 
            this.id_inactive.DataPropertyName = "Id";
            this.id_inactive.HeaderText = "Id";
            this.id_inactive.MinimumWidth = 7;
            this.id_inactive.Name = "id_inactive";
            this.id_inactive.ReadOnly = true;
            this.id_inactive.Width = 130;
            // 
            // name_inactive
            // 
            this.name_inactive.DataPropertyName = "Name";
            this.name_inactive.HeaderText = "Name";
            this.name_inactive.MinimumWidth = 7;
            this.name_inactive.Name = "name_inactive";
            this.name_inactive.Width = 130;
            // 
            // email_inactive
            // 
            this.email_inactive.DataPropertyName = "Email";
            this.email_inactive.HeaderText = "Email";
            this.email_inactive.MinimumWidth = 7;
            this.email_inactive.Name = "email_inactive";
            this.email_inactive.Width = 130;
            // 
            // password_inactive
            // 
            this.password_inactive.DataPropertyName = "Password";
            this.password_inactive.HeaderText = "Password";
            this.password_inactive.MinimumWidth = 7;
            this.password_inactive.Name = "password_inactive";
            this.password_inactive.Width = 130;
            // 
            // role_inactive
            // 
            this.role_inactive.DataPropertyName = "Role";
            this.role_inactive.HeaderText = "Role";
            this.role_inactive.MinimumWidth = 7;
            this.role_inactive.Name = "role_inactive";
            this.role_inactive.Width = 130;
            // 
            // workingStatus_inactive
            // 
            this.workingStatus_inactive.DataPropertyName = "WorkingStatus";
            this.workingStatus_inactive.HeaderText = "WorkingStatus";
            this.workingStatus_inactive.MinimumWidth = 7;
            this.workingStatus_inactive.Name = "workingStatus_inactive";
            this.workingStatus_inactive.Width = 130;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1431, 666);
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_inactive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_for_active;
        private System.Windows.Forms.DataGridView dataGridView_for_inactive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activationStatus;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn working;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activationStatus_active;
        private System.Windows.Forms.DataGridViewButtonColumn update_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn workingStatus_active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivationStatus_inactive;
        private System.Windows.Forms.DataGridViewButtonColumn update_inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_inactive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn workingStatus_inactive;
    }
}
