namespace Employees
{
    partial class AddEmployee
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
            tbxName = new TextBox();
            label2 = new Label();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            label3 = new Label();
            tbxRepPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAddEmployee = new Button();
            label6 = new Label();
            tbxUsername = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(153, 95);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(226, 27);
            tbxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 98);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(153, 143);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(226, 27);
            tbxEmail.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(153, 194);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(226, 27);
            tbxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 146);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // tbxRepPassword
            // 
            tbxRepPassword.Location = new Point(153, 241);
            tbxRepPassword.Name = "tbxRepPassword";
            tbxRepPassword.Size = new Size(226, 27);
            tbxRepPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 197);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 244);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 8;
            label5.Text = "Repeat Password:";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(251, 296);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(130, 29);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 51);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 10;
            label6.Text = "Username:";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(153, 48);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(226, 27);
            tbxUsername.TabIndex = 11;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 353);
            Controls.Add(tbxUsername);
            Controls.Add(label6);
            Controls.Add(btnAddEmployee);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxRepPassword);
            Controls.Add(label3);
            Controls.Add(tbxPassword);
            Controls.Add(tbxEmail);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(label1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxName;
        private Label label2;
        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private Label label3;
        private TextBox tbxRepPassword;
        private Label label4;
        private Label label5;
        private Button btnAddEmployee;
        private Label label6;
        private TextBox tbxUsername;
    }
}