namespace UI_DESIGNS
{
    partial class Recipt
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
            this.hourlyRate_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.managementCost_txtbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.financeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managementcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostofprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hourlyRate_txtbx
            // 
            this.hourlyRate_txtbx.Location = new System.Drawing.Point(407, 96);
            this.hourlyRate_txtbx.Name = "hourlyRate_txtbx";
            this.hourlyRate_txtbx.Size = new System.Drawing.Size(203, 22);
            this.hourlyRate_txtbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hourly Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Management  Cost";
            // 
            // managementCost_txtbx
            // 
            this.managementCost_txtbx.Location = new System.Drawing.Point(647, 96);
            this.managementCost_txtbx.Name = "managementCost_txtbx";
            this.managementCost_txtbx.Size = new System.Drawing.Size(203, 22);
            this.managementCost_txtbx.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Recipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hourlyrateDataGridViewTextBoxColumn,
            this.totalhoursDataGridViewTextBoxColumn,
            this.managementcostDataGridViewTextBoxColumn,
            this.totalcostofprojectDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.financeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 402);
            this.dataGridView1.TabIndex = 7;
            // 
            // financeBindingSource
            // 
            this.financeBindingSource.DataSource = typeof(UI_DESIGNS.ServiceReference1.Finance);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "project_id";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "project_id";
            this.projectidDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectidDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // hourlyrateDataGridViewTextBoxColumn
            // 
            this.hourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_rate";
            this.hourlyrateDataGridViewTextBoxColumn.HeaderText = "hourly_rate";
            this.hourlyrateDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.hourlyrateDataGridViewTextBoxColumn.Name = "hourlyrateDataGridViewTextBoxColumn";
            this.hourlyrateDataGridViewTextBoxColumn.ReadOnly = true;
            this.hourlyrateDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalhoursDataGridViewTextBoxColumn
            // 
            this.totalhoursDataGridViewTextBoxColumn.DataPropertyName = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.HeaderText = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.totalhoursDataGridViewTextBoxColumn.Name = "totalhoursDataGridViewTextBoxColumn";
            this.totalhoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalhoursDataGridViewTextBoxColumn.Width = 130;
            // 
            // managementcostDataGridViewTextBoxColumn
            // 
            this.managementcostDataGridViewTextBoxColumn.DataPropertyName = "management_cost";
            this.managementcostDataGridViewTextBoxColumn.HeaderText = "management_cost";
            this.managementcostDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.managementcostDataGridViewTextBoxColumn.Name = "managementcostDataGridViewTextBoxColumn";
            this.managementcostDataGridViewTextBoxColumn.ReadOnly = true;
            this.managementcostDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalcostofprojectDataGridViewTextBoxColumn
            // 
            this.totalcostofprojectDataGridViewTextBoxColumn.DataPropertyName = "total_cost_of_project";
            this.totalcostofprojectDataGridViewTextBoxColumn.HeaderText = "total_cost_of_project";
            this.totalcostofprojectDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.totalcostofprojectDataGridViewTextBoxColumn.Name = "totalcostofprojectDataGridViewTextBoxColumn";
            this.totalcostofprojectDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalcostofprojectDataGridViewTextBoxColumn.Width = 130;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddateDataGridViewTextBoxColumn.Width = 130;
            // 
            // Recipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managementCost_txtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourlyRate_txtbx);
            this.Name = "Recipt";
            this.Size = new System.Drawing.Size(1221, 664);
            this.Load += new System.EventHandler(this.Recipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourlyRate_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox managementCost_txtbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managementcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostofprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource financeBindingSource;
    }
}
