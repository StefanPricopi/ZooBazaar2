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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(134, 96);
            tbxName.Margin = new Padding(3, 2, 3, 2);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(198, 23);
            tbxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(134, 132);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(198, 23);
            tbxEmail.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(134, 168);
            tbxPassword.Margin = new Padding(3, 2, 3, 2);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(198, 23);
            tbxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // tbxRepPassword
            // 
            tbxRepPassword.Location = new Point(134, 205);
            tbxRepPassword.Margin = new Padding(3, 2, 3, 2);
            tbxRepPassword.Name = "tbxRepPassword";
            tbxRepPassword.Size = new Size(198, 23);
            tbxRepPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSlateBlue;
            label5.Location = new Point(12, 213);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Repeat Password:";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(134, 232);
            btnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(114, 22);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSlateBlue;
            label6.Location = new Point(12, 68);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Username:";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(134, 60);
            tbxUsername.Margin = new Padding(3, 2, 3, 2);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(198, 23);
            tbxUsername.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 46);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(-2, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 237);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 265);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(tbxUsername);
            Controls.Add(btnAddEmployee);
            Controls.Add(tbxRepPassword);
            Controls.Add(tbxPassword);
            Controls.Add(tbxEmail);
            Controls.Add(tbxName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}