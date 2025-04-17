namespace UI_DESIGNS
{
    partial class AddTimeLog
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.description_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hours_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.all = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pending = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.approved = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.reject = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.timeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.approved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.reject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Project";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(583, 38);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 22);
            this.date_picker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pick Date";
            // 
            // description_txtbx
            // 
            this.description_txtbx.Location = new System.Drawing.Point(260, 86);
            this.description_txtbx.Multiline = true;
            this.description_txtbx.Name = "description_txtbx";
            this.description_txtbx.Size = new System.Drawing.Size(269, 42);
            this.description_txtbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log Description";
            // 
            // hours_txtbx
            // 
            this.hours_txtbx.Location = new System.Drawing.Point(583, 106);
            this.hours_txtbx.Name = "hours_txtbx";
            this.hours_txtbx.Size = new System.Drawing.Size(200, 22);
            this.hours_txtbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spend Hours";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Time Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.all);
            this.tabControl1.Controls.Add(this.pending);
            this.tabControl1.Controls.Add(this.approved);
            this.tabControl1.Controls.Add(this.reject);
            this.tabControl1.Location = new System.Drawing.Point(4, 159);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1187, 496);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // all
            // 
            this.all.Controls.Add(this.dataGridView1);
            this.all.Location = new System.Drawing.Point(4, 25);
            this.all.Name = "all";
            this.all.Padding = new System.Windows.Forms.Padding(3);
            this.all.Size = new System.Drawing.Size(1179, 467);
            this.all.TabIndex = 0;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 532);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pending
            // 
            this.pending.Controls.Add(this.dataGridView2);
            this.pending.Location = new System.Drawing.Point(4, 25);
            this.pending.Name = "pending";
            this.pending.Padding = new System.Windows.Forms.Padding(3);
            this.pending.Size = new System.Drawing.Size(1179, 467);
            this.pending.TabIndex = 1;
            this.pending.Text = "Pending";
            this.pending.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 53;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1183, 532);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // approved
            // 
            this.approved.Controls.Add(this.dataGridView3);
            this.approved.Location = new System.Drawing.Point(4, 25);
            this.approved.Name = "approved";
            this.approved.Padding = new System.Windows.Forms.Padding(3);
            this.approved.Size = new System.Drawing.Size(1179, 467);
            this.approved.TabIndex = 2;
            this.approved.Text = "Approved";
            this.approved.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 53;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1183, 532);
            this.dataGridView3.TabIndex = 1;
            // 
            // reject
            // 
            this.reject.Controls.Add(this.dataGridView4);
            this.reject.Location = new System.Drawing.Point(4, 25);
            this.reject.Name = "reject";
            this.reject.Padding = new System.Windows.Forms.Padding(3);
            this.reject.Size = new System.Drawing.Size(1179, 467);
            this.reject.TabIndex = 3;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 53;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1183, 532);
            this.dataGridView4.TabIndex = 1;
            // 
            // timeLogBindingSource
            // 
            this.timeLogBindingSource.DataSource = typeof(UI_DESIGNS.ServiceReference1.TimeLog);
            // 
            // AddTimeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hours_txtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddTimeLog";
            this.Size = new System.Drawing.Size(1190, 654);
            this.Load += new System.EventHandler(this.AddTimeLog_Load);
            this.tabControl1.ResumeLayout(false);
            this.all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.approved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.reject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hours_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage all;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource timeLogBindingSource;
        private System.Windows.Forms.TabPage pending;
        private System.Windows.Forms.TabPage approved;
        private System.Windows.Forms.TabPage reject;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}
