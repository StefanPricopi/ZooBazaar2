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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditEmployee = new Button();
            tbxUsername = new TextBox();
            tbxName = new TextBox();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            tbxRepeatPassword = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnDeleteEmployee = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 0;
            label1.Text = "Edit Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 51);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 98);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 146);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 197);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 244);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 5;
            label6.Text = "Repeat Password:";
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(211, 309);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(168, 29);
            btnEditEmployee.TabIndex = 6;
            btnEditEmployee.Text = "Edit Employee Details";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(153, 48);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(226, 27);
            tbxUsername.TabIndex = 7;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(153, 95);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(226, 27);
            tbxName.TabIndex = 8;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(153, 143);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(226, 27);
            tbxEmail.TabIndex = 9;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(153, 194);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(226, 27);
            tbxPassword.TabIndex = 10;
            // 
            // tbxRepeatPassword
            // 
            tbxRepeatPassword.Location = new Point(153, 241);
            tbxRepeatPassword.Name = "tbxRepeatPassword";
            tbxRepeatPassword.Size = new Size(226, 27);
            tbxRepeatPassword.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(444, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(530, 245);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(444, 309);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 13;
            button1.Text = "Reload Employee Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRefresh_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(736, 309);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(238, 29);
            btnDeleteEmployee.TabIndex = 14;
            btnDeleteEmployee.Text = "Delete Employee Acount";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(430, 12);
            label7.Name = "label7";
            label7.Size = new Size(557, 26);
            label7.TabIndex = 15;
            label7.Text = "Select an Employee to edit their data or delete their account";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 369);
            Controls.Add(label7);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(tbxRepeatPassword);
            Controls.Add(tbxPassword);
            Controls.Add(tbxEmail);
            Controls.Add(tbxName);
            Controls.Add(tbxUsername);
            Controls.Add(btnEditEmployee);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditEmployee";
            Text = "EditEmployee";
            Load += EditEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditEmployee;
        private TextBox tbxUsername;
        private TextBox tbxName;
        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private TextBox tbxRepeatPassword;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnDeleteEmployee;
        private Label label7;
    }
}