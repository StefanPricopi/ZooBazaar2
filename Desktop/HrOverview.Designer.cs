namespace Desktop
{
    partial class HrOverview
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
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            btnEmployeeSchedule = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlOverview = new Panel();
            btnAnnouncement = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditEmployee.BackColor = SystemColors.ActiveCaptionText;
            btnEditEmployee.Dock = DockStyle.Top;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Image = Properties.Resources.Screenshot_13;
            btnEditEmployee.Location = new Point(0, 249);
            btnEditEmployee.Margin = new Padding(0);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(273, 127);
            btnEditEmployee.TabIndex = 2;
            btnEditEmployee.Text = "Change Employee Data";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddEmployee.BackColor = SystemColors.ActiveCaptionText;
            btnAddEmployee.Dock = DockStyle.Top;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Image = Properties.Resources.Screenshot_13;
            btnAddEmployee.Location = new Point(0, 122);
            btnAddEmployee.Margin = new Padding(0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(273, 127);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEmployeeSchedule
            // 
            btnEmployeeSchedule.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmployeeSchedule.BackColor = SystemColors.ActiveCaptionText;
            btnEmployeeSchedule.Dock = DockStyle.Top;
            btnEmployeeSchedule.FlatAppearance.BorderSize = 0;
            btnEmployeeSchedule.FlatStyle = FlatStyle.Flat;
            btnEmployeeSchedule.Image = Properties.Resources.Screenshot_13;
            btnEmployeeSchedule.Location = new Point(0, 0);
            btnEmployeeSchedule.Margin = new Padding(0);
            btnEmployeeSchedule.Name = "btnEmployeeSchedule";
            btnEmployeeSchedule.Size = new Size(273, 122);
            btnEmployeeSchedule.TabIndex = 1;
            btnEmployeeSchedule.Text = "View Employee Schedule";
            btnEmployeeSchedule.UseVisualStyleBackColor = false;
            btnEmployeeSchedule.Click += btnEmployeeSchedule_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1664, 270);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(btnAnnouncement);
            panel2.Controls.Add(btnEditEmployee);
            panel2.Controls.Add(btnAddEmployee);
            panel2.Controls.Add(btnEmployeeSchedule);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 505);
            panel2.TabIndex = 5;
            // 
            // pnlOverview
            // 
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.Location = new Point(273, 270);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Size = new Size(1391, 505);
            pnlOverview.TabIndex = 6;
            // 
            // btnAnnouncement
            // 
            btnAnnouncement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAnnouncement.BackColor = SystemColors.ActiveCaptionText;
            btnAnnouncement.Dock = DockStyle.Top;
            btnAnnouncement.FlatAppearance.BorderSize = 0;
            btnAnnouncement.FlatStyle = FlatStyle.Flat;
            btnAnnouncement.Image = Properties.Resources.Screenshot_13;
            btnAnnouncement.Location = new Point(0, 376);
            btnAnnouncement.Margin = new Padding(0);
            btnAnnouncement.Name = "btnAnnouncement";
            btnAnnouncement.Size = new Size(273, 127);
            btnAnnouncement.TabIndex = 3;
            btnAnnouncement.Text = "Manage Announcements";
            btnAnnouncement.UseVisualStyleBackColor = false;
            btnAnnouncement.Click += btnAnnouncement_Click;
            // 
            // HrOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(pnlOverview);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HrOverview";
            Text = "HrOverview";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEditEmployee;
        private Button btnAddEmployee;
        private Button btnEmployeeSchedule;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlOverview;
        private Button btnAnnouncement;
    }
}