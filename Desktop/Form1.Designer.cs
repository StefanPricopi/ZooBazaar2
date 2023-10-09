namespace Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAreaManagement = new Button();
            btnOpenAddAnimalForm = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnOpenViewAnimalDetailsForm = new Button();
            btnOpenUpdateAnimalForm = new Button();
            btnOpenSearchAnimalForm = new Button();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            btnEmployeeSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAreaManagement
            // 
            btnAreaManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAreaManagement.BackColor = SystemColors.ActiveCaptionText;
            btnAreaManagement.FlatAppearance.BorderSize = 0;
            btnAreaManagement.FlatStyle = FlatStyle.Flat;
            btnAreaManagement.Image = Properties.Resources.Screenshot_13;
            btnAreaManagement.Location = new Point(162, 12);
            btnAreaManagement.Margin = new Padding(0);
            btnAreaManagement.Name = "btnAreaManagement";
            btnAreaManagement.Size = new Size(158, 79);
            btnAreaManagement.TabIndex = 0;
            btnAreaManagement.Text = "Manage Areas And Locations";
            btnAreaManagement.UseVisualStyleBackColor = false;
            btnAreaManagement.Click += btnAreaManagement_Click;
            // 
            // btnOpenAddAnimalForm
            // 
            btnOpenAddAnimalForm.BackColor = SystemColors.ControlDark;
            btnOpenAddAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenAddAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenAddAnimalForm.ForeColor = SystemColors.ControlText;
            btnOpenAddAnimalForm.Image = (Image)resources.GetObject("btnOpenAddAnimalForm.Image");
            btnOpenAddAnimalForm.Location = new Point(501, 12);
            btnOpenAddAnimalForm.Name = "btnOpenAddAnimalForm";
            btnOpenAddAnimalForm.Size = new Size(197, 79);
            btnOpenAddAnimalForm.TabIndex = 1;
            btnOpenAddAnimalForm.Text = "Add Animal";
            btnOpenAddAnimalForm.UseVisualStyleBackColor = false;
            btnOpenAddAnimalForm.Click += btnOpenAddAnimalForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 117);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 342);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnOpenViewAnimalDetailsForm
            // 
            btnOpenViewAnimalDetailsForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenViewAnimalDetailsForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenViewAnimalDetailsForm.FlatAppearance.BorderSize = 0;
            btnOpenViewAnimalDetailsForm.FlatStyle = FlatStyle.Flat;
            btnOpenViewAnimalDetailsForm.Image = Properties.Resources.Screenshot_13;
            btnOpenViewAnimalDetailsForm.Location = new Point(5, 137);
            btnOpenViewAnimalDetailsForm.Margin = new Padding(0);
            btnOpenViewAnimalDetailsForm.Name = "btnOpenViewAnimalDetailsForm";
            btnOpenViewAnimalDetailsForm.Size = new Size(158, 79);
            btnOpenViewAnimalDetailsForm.TabIndex = 4;
            btnOpenViewAnimalDetailsForm.Text = "View Animal Details";
            btnOpenViewAnimalDetailsForm.UseVisualStyleBackColor = false;
            btnOpenViewAnimalDetailsForm.Click += btnOpenViewAnimalDetailsForm_Click;
            // 
            // btnOpenUpdateAnimalForm
            // 
            btnOpenUpdateAnimalForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenUpdateAnimalForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenUpdateAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenUpdateAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenUpdateAnimalForm.Image = Properties.Resources.Screenshot_13;
            btnOpenUpdateAnimalForm.Location = new Point(5, 225);
            btnOpenUpdateAnimalForm.Margin = new Padding(0);
            btnOpenUpdateAnimalForm.Name = "btnOpenUpdateAnimalForm";
            btnOpenUpdateAnimalForm.Size = new Size(158, 79);
            btnOpenUpdateAnimalForm.TabIndex = 5;
            btnOpenUpdateAnimalForm.Text = "Update Animal";
            btnOpenUpdateAnimalForm.UseVisualStyleBackColor = false;
            btnOpenUpdateAnimalForm.Click += btnOpenUpdateAnimalForm_Click;
            // 
            // btnOpenSearchAnimalForm
            // 
            btnOpenSearchAnimalForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenSearchAnimalForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenSearchAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenSearchAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenSearchAnimalForm.Image = Properties.Resources.Screenshot_13;
            btnOpenSearchAnimalForm.Location = new Point(5, 317);
            btnOpenSearchAnimalForm.Margin = new Padding(0);
            btnOpenSearchAnimalForm.Name = "btnOpenSearchAnimalForm";
            btnOpenSearchAnimalForm.Size = new Size(158, 79);
            btnOpenSearchAnimalForm.TabIndex = 6;
            btnOpenSearchAnimalForm.Text = "Search Animal";
            btnOpenSearchAnimalForm.UseVisualStyleBackColor = false;
            btnOpenSearchAnimalForm.Click += btnOpenSearchAnimalForm_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditEmployee.BackColor = SystemColors.ActiveCaptionText;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Image = Properties.Resources.Screenshot_13;
            btnEditEmployee.Location = new Point(549, 137);
            btnEditEmployee.Margin = new Padding(0);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(158, 79);
            btnEditEmployee.TabIndex = 10;
            btnEditEmployee.Text = "Add Employee";
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
            btnAddEmployee.Location = new Point(549, 244);
            btnAddEmployee.Margin = new Padding(0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(158, 79);
            btnAddEmployee.TabIndex = 11;
            btnAddEmployee.Text = "Change Employee Data";
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
            btnEmployeeSchedule.Location = new Point(549, 348);
            btnEmployeeSchedule.Margin = new Padding(0);
            btnEmployeeSchedule.Name = "btnEmployeeSchedule";
            btnEmployeeSchedule.Size = new Size(158, 79);
            btnEmployeeSchedule.TabIndex = 12;
            btnEmployeeSchedule.Text = "View Employee Schedule";
            btnEmployeeSchedule.UseVisualStyleBackColor = false;
            btnEmployeeSchedule.Click += btnEmployeeSchedule_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployeeSchedule);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnOpenSearchAnimalForm);
            Controls.Add(btnOpenUpdateAnimalForm);
            Controls.Add(btnOpenViewAnimalDetailsForm);
            Controls.Add(pictureBox2);
            Controls.Add(btnAreaManagement);
            Controls.Add(btnOpenAddAnimalForm);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAreaManagement;
        private Button btnOpenAddAnimalForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnOpenViewAnimalDetailsForm;
        private Button btnOpenUpdateAnimalForm;
        private Button btnOpenSearchAnimalForm;
        private Button btnEditEmployee;
        private Button btnAddEmployee;
        private Button btnEmployeeSchedule;
    }
}