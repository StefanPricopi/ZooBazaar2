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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrOverview));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            btnEmployeeSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-5, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(810, 117);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 342);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditEmployee.BackColor = SystemColors.ActiveCaptionText;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Image = Properties.Resources.Screenshot_13;
            btnEditEmployee.Location = new Point(277, 137);
            btnEditEmployee.Margin = new Padding(0);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(313, 79);
            btnEditEmployee.TabIndex = 11;
            btnEditEmployee.Text = "Change Employee Data";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddEmployee.BackColor = SystemColors.ActiveCaptionText;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Image = Properties.Resources.Screenshot_13;
            btnAddEmployee.Location = new Point(277, 246);
            btnAddEmployee.Margin = new Padding(0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(313, 79);
            btnAddEmployee.TabIndex = 12;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEmployeeSchedule
            // 
            btnEmployeeSchedule.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmployeeSchedule.BackColor = SystemColors.ActiveCaptionText;
            btnEmployeeSchedule.FlatAppearance.BorderSize = 0;
            btnEmployeeSchedule.FlatStyle = FlatStyle.Flat;
            btnEmployeeSchedule.Image = Properties.Resources.Screenshot_13;
            btnEmployeeSchedule.Location = new Point(277, 348);
            btnEmployeeSchedule.Margin = new Padding(0);
            btnEmployeeSchedule.Name = "btnEmployeeSchedule";
            btnEmployeeSchedule.Size = new Size(313, 79);
            btnEmployeeSchedule.TabIndex = 13;
            btnEmployeeSchedule.Text = "View Employee Schedule";
            btnEmployeeSchedule.UseVisualStyleBackColor = false;
            btnEmployeeSchedule.Click += btnEmployeeSchedule_Click;
            // 
            // HrOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployeeSchedule);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "HrOverview";
            Text = "HrOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnEditEmployee;
        private Button btnAddEmployee;
        private Button btnEmployeeSchedule;
    }
}