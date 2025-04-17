namespace UI_DESIGNS
{
    partial class ManageTimeLog
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pending = new System.Windows.Forms.TabPage();
            this.other = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.pending.SuspendLayout();
            this.other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Project Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pending);
            this.tabControl1.Controls.Add(this.other);
            this.tabControl1.Location = new System.Drawing.Point(4, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 436);
            this.tabControl1.TabIndex = 3;
            // 
            // pending
            // 
            this.pending.Controls.Add(this.dataGridView1);
            this.pending.Location = new System.Drawing.Point(4, 25);
            this.pending.Name = "pending";
            this.pending.Padding = new System.Windows.Forms.Padding(3);
            this.pending.Size = new System.Drawing.Size(1163, 407);
            this.pending.TabIndex = 0;
            this.pending.Text = "Pending";
            this.pending.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.Controls.Add(this.dataGridView2);
            this.other.Location = new System.Drawing.Point(4, 25);
            this.other.Name = "other";
            this.other.Padding = new System.Windows.Forms.Padding(3);
            this.other.Size = new System.Drawing.Size(1163, 407);
            this.other.TabIndex = 1;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Approve,
            this.reject});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 403);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Approve
            // 
            this.Approve.HeaderText = "Approve Time Log";
            this.Approve.MinimumWidth = 7;
            this.Approve.Name = "Approve";
            this.Approve.ReadOnly = true;
            this.Approve.Text = "Approve";
            this.Approve.UseColumnTextForButtonValue = true;
            this.Approve.Width = 130;
            // 
            // reject
            // 
            this.reject.HeaderText = "Reject Time Log";
            this.reject.MinimumWidth = 7;
            this.reject.Name = "reject";
            this.reject.ReadOnly = true;
            this.reject.Text = "reject";
            this.reject.UseColumnTextForButtonValue = true;
            this.reject.Width = 130;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 53;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1165, 407);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ManageTimeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ManageTimeLog";
            this.Size = new System.Drawing.Size(1176, 598);
            this.Load += new System.EventHandler(this.ManageTimeLog_Load);
            this.tabControl1.ResumeLayout(false);
            this.pending.ResumeLayout(false);
            this.other.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pending;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage other;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
        private System.Windows.Forms.DataGridViewButtonColumn reject;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
