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
            btnAddEmployee = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbPosition = new ComboBox();
            cmbDialing = new ComboBox();
            label18 = new Label();
            tbxPhone = new NumericUpDown();
            tbxBSN = new NumericUpDown();
            dtpBirthDate = new DateTimePicker();
            tbxLastName = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            tbxFirstName = new TextBox();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            pictureBox5 = new PictureBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPage5 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbxPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbxBSN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage3.SuspendLayout();
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
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(132, 272);
            btnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(219, 34);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 46);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.ItemSize = new Size(100, 50);
            tabControl1.Location = new Point(-2, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(431, 372);
            tabControl1.TabIndex = 28;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MediumSlateBlue;
            tabPage1.Controls.Add(cmbPosition);
            tabPage1.Controls.Add(cmbDialing);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(tbxPhone);
            tabPage1.Controls.Add(tbxBSN);
            tabPage1.Controls.Add(dtpBirthDate);
            tabPage1.Controls.Add(tbxLastName);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(tbxFirstName);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(btnAddEmployee);
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(423, 314);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee info";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(132, 240);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(219, 27);
            cmbPosition.TabIndex = 39;
            // 
            // cmbDialing
            // 
            cmbDialing.FormattingEnabled = true;
            cmbDialing.Location = new Point(132, 123);
            cmbDialing.Name = "cmbDialing";
            cmbDialing.Size = new Size(219, 27);
            cmbDialing.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.MediumSlateBlue;
            label18.Location = new Point(10, 126);
            label18.Name = "label18";
            label18.Size = new Size(84, 19);
            label18.TabIndex = 37;
            label18.Text = "DialingCode";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(132, 92);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(219, 26);
            tbxPhone.TabIndex = 36;
            // 
            // tbxBSN
            // 
            tbxBSN.Location = new Point(132, 204);
            tbxBSN.Name = "tbxBSN";
            tbxBSN.Size = new Size(219, 26);
            tbxBSN.TabIndex = 35;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(132, 163);
            dtpBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(219, 26);
            dtpBirthDate.TabIndex = 29;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(132, 58);
            tbxLastName.Margin = new Padding(3, 2, 3, 2);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(219, 26);
            tbxLastName.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.MediumSlateBlue;
            label17.Location = new Point(10, 240);
            label17.Name = "label17";
            label17.Size = new Size(60, 19);
            label17.TabIndex = 29;
            label17.Text = "Position:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.MediumSlateBlue;
            label16.Location = new Point(10, 204);
            label16.Name = "label16";
            label16.Size = new Size(43, 19);
            label16.TabIndex = 29;
            label16.Text = "BSN:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.MediumSlateBlue;
            label15.Location = new Point(10, 163);
            label15.Name = "label15";
            label15.Size = new Size(74, 19);
            label15.TabIndex = 29;
            label15.Text = "Birth Date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.MediumSlateBlue;
            label14.Location = new Point(10, 94);
            label14.Name = "label14";
            label14.Size = new Size(104, 19);
            label14.TabIndex = 29;
            label14.Text = "Phone Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.MediumSlateBlue;
            label13.Location = new Point(10, 58);
            label13.Name = "label13";
            label13.Size = new Size(79, 19);
            label13.TabIndex = 29;
            label13.Text = "Last Name:";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(132, 17);
            tbxFirstName.Margin = new Padding(3, 2, 3, 2);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(219, 26);
            tbxFirstName.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.MediumSlateBlue;
            label12.Location = new Point(10, 20);
            label12.Name = "label12";
            label12.Size = new Size(80, 19);
            label12.TabIndex = 29;
            label12.Text = "First Name:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox4.Location = new Point(0, -82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(126, 463);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.MediumSlateBlue;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(tbxEmail);
            tabPage2.Controls.Add(tbxPassword);
            tabPage2.Controls.Add(tbxUsername);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Location = new Point(4, 54);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(423, 314);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employee Login Info";
            // 
            // button1
            // 
            button1.Location = new Point(132, 126);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(219, 34);
            button1.TabIndex = 29;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(132, 89);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(219, 26);
            tbxEmail.TabIndex = 29;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(132, 50);
            tbxPassword.Margin = new Padding(3, 2, 3, 2);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(219, 26);
            tbxPassword.TabIndex = 29;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(132, 9);
            tbxUsername.Margin = new Padding(3, 2, 3, 2);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(219, 26);
            tbxUsername.TabIndex = 29;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.MediumSlateBlue;
            label21.Location = new Point(22, 89);
            label21.Name = "label21";
            label21.Size = new Size(45, 19);
            label21.TabIndex = 29;
            label21.Text = "Email:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.MediumSlateBlue;
            label20.Location = new Point(22, 53);
            label20.Name = "label20";
            label20.Size = new Size(72, 19);
            label20.TabIndex = 29;
            label20.Text = "Password:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.MediumSlateBlue;
            label19.Location = new Point(22, 17);
            label19.Name = "label19";
            label19.Size = new Size(73, 19);
            label19.TabIndex = 29;
            label19.Text = "Username:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(126, 322);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Location = new Point(4, 54);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(423, 314);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Employee Partner Info";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 54);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(423, 314);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Employee Contract Info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(3, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 349);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Location = new Point(23, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 31;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Location = new Point(23, 67);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 32;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.Location = new Point(23, 107);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 33;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSlateBlue;
            label5.Location = new Point(23, 143);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 34;
            label5.Text = "Username:";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(423, 314);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Employee Address Info";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 495);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbxPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbxBSN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddEmployee;
        private PictureBox pictureBox1;
        private TabControl tabControl1;

        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label18;
        private NumericUpDown tbxPhone;
        private NumericUpDown tbxBSN;
        private DateTimePicker dtpBirthDate;
        private TextBox tbxLastName;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox tbxFirstName;
        private Label label12;
        private PictureBox pictureBox4;
        private ComboBox cmbPosition;
        private ComboBox cmbDialing;
        private Button button1;
        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Label label21;
        private Label label20;
        private Label label19;
        private PictureBox pictureBox5;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private TabPage tabPage5;
    }
}