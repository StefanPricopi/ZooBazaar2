namespace Employees
{
    partial class EditEmployee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditEmployee = new Button();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxPhone = new TextBox();
            dataGridView1 = new DataGridView();
            btnReload = new Button();
            btnDeleteEmployee = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            tbxBSN = new TextBox();
            dtpBirthDate = new DateTimePicker();
            label4 = new Label();
            tbxPosition = new TextBox();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            tbxEmail = new TextBox();
            btnEditLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 7);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 0;
            label1.Text = "Edit Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSlateBlue;
            label5.Location = new Point(12, 118);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSlateBlue;
            label6.Location = new Point(12, 156);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "Birth Date:";
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.MediumSlateBlue;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Location = new Point(120, 458);
            btnEditEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(147, 22);
            btnEditEmployee.TabIndex = 6;
            btnEditEmployee.Text = "Edit Employee Details";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(134, 36);
            tbxFirstName.Margin = new Padding(3, 2, 3, 2);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(231, 23);
            tbxFirstName.TabIndex = 7;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(134, 71);
            tbxLastName.Margin = new Padding(3, 2, 3, 2);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(231, 23);
            tbxLastName.TabIndex = 8;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(134, 113);
            tbxPhone.Margin = new Padding(3, 2, 3, 2);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(231, 23);
            tbxPhone.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 36);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(464, 204);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.MediumSlateBlue;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Location = new Point(499, 458);
            btnReload.Margin = new Padding(3, 2, 3, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(160, 22);
            btnReload.TabIndex = 13;
            btnReload.Text = "Reload Employee Data";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnRefresh_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.MediumSlateBlue;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Location = new Point(698, 458);
            btnDeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(208, 22);
            btnDeleteEmployee.TabIndex = 14;
            btnDeleteEmployee.Text = "Delete Employee Acount";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(376, 9);
            label7.Name = "label7";
            label7.Size = new Size(456, 21);
            label7.TabIndex = 15;
            label7.Text = "Select an Employee to edit their data or delete their account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-20, 441);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(941, 56);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(-2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 499);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumSlateBlue;
            label8.Location = new Point(12, 190);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 18;
            label8.Text = "BSN:";
            // 
            // tbxBSN
            // 
            tbxBSN.Location = new Point(134, 185);
            tbxBSN.Margin = new Padding(3, 2, 3, 2);
            tbxBSN.Name = "tbxBSN";
            tbxBSN.Size = new Size(231, 23);
            tbxBSN.TabIndex = 19;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(134, 151);
            dtpBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(231, 23);
            dtpBirthDate.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 21;
            label4.Text = "Position:";
            // 
            // tbxPosition
            // 
            tbxPosition.Location = new Point(134, 217);
            tbxPosition.Margin = new Padding(3, 2, 3, 2);
            tbxPosition.Name = "tbxPosition";
            tbxPosition.Size = new Size(231, 23);
            tbxPosition.TabIndex = 22;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(388, 265);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(464, 171);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MediumSlateBlue;
            label9.Location = new Point(12, 289);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 24;
            label9.Text = "Username:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MediumSlateBlue;
            label10.Location = new Point(12, 337);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 25;
            label10.Text = "Password:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.MediumSlateBlue;
            label11.Location = new Point(12, 383);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 26;
            label11.Text = "Email:";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(134, 286);
            tbxUsername.Margin = new Padding(3, 2, 3, 2);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(231, 23);
            tbxUsername.TabIndex = 27;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(134, 337);
            tbxPassword.Margin = new Padding(3, 2, 3, 2);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(231, 23);
            tbxPassword.TabIndex = 28;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(134, 383);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(231, 23);
            tbxEmail.TabIndex = 29;
            // 
            // btnEditLogin
            // 
            btnEditLogin.BackColor = Color.MediumSlateBlue;
            btnEditLogin.FlatAppearance.BorderSize = 0;
            btnEditLogin.FlatStyle = FlatStyle.Flat;
            btnEditLogin.Location = new Point(302, 458);
            btnEditLogin.Margin = new Padding(3, 2, 3, 2);
            btnEditLogin.Name = "btnEditLogin";
            btnEditLogin.Size = new Size(147, 22);
            btnEditLogin.TabIndex = 30;
            btnEditLogin.Text = "Edit Employee Login";
            btnEditLogin.UseVisualStyleBackColor = false;
            btnEditLogin.Click += btnEditLogin_Click;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 491);
            Controls.Add(btnEditLogin);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(tbxPosition);
            Controls.Add(label4);
            Controls.Add(dtpBirthDate);
            Controls.Add(tbxBSN);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnReload);
            Controls.Add(btnEditEmployee);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(tbxPhone);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnEditEmployee;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxPhone;
        private DataGridView dataGridView1;
        private Button btnReload;
        private Button btnDeleteEmployee;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private TextBox tbxBSN;
        private DateTimePicker dtpBirthDate;
        private Label label4;
        private TextBox tbxPosition;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private TextBox tbxEmail;
        private Button btnEditLogin;

    }
}