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
            btnPartner = new Button();
            tbxPhonePartner = new TextBox();
            tbxLastNamePartner = new TextBox();
            tbxFirstNamePartner = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tabPage4 = new TabPage();
            label23 = new Label();
            tbxContractType = new TextBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label8 = new Label();
            btnContract = new Button();
            tbxSalary = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            tabPage5 = new TabPage();
            btnAddress = new Button();
            tbxCountry = new TextBox();
            tbxZipCode = new TextBox();
            tbxCity = new TextBox();
            tbxStreet = new TextBox();
            label22 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            cmbRole = new ComboBox();
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
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(151, 363);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(250, 45);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 61);
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
            tabControl1.Location = new Point(-2, 45);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(493, 496);
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
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(485, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee info";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(151, 320);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(250, 30);
            cmbPosition.TabIndex = 39;
            // 
            // cmbDialing
            // 
            cmbDialing.FormattingEnabled = true;
            cmbDialing.Location = new Point(151, 164);
            cmbDialing.Margin = new Padding(3, 4, 3, 4);
            cmbDialing.Name = "cmbDialing";
            cmbDialing.Size = new Size(250, 30);
            cmbDialing.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.MediumSlateBlue;
            label18.Location = new Point(11, 168);
            label18.Name = "label18";
            label18.Size = new Size(111, 22);
            label18.TabIndex = 37;
            label18.Text = "DialingCode";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(151, 123);
            tbxPhone.Margin = new Padding(3, 4, 3, 4);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(250, 30);
            tbxPhone.TabIndex = 36;
            // 
            // tbxBSN
            // 
            tbxBSN.Location = new Point(151, 272);
            tbxBSN.Margin = new Padding(3, 4, 3, 4);
            tbxBSN.Name = "tbxBSN";
            tbxBSN.Size = new Size(250, 30);
            tbxBSN.TabIndex = 35;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(151, 217);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 30);
            dtpBirthDate.TabIndex = 29;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(151, 77);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(250, 30);
            tbxLastName.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.MediumSlateBlue;
            label17.Location = new Point(11, 320);
            label17.Name = "label17";
            label17.Size = new Size(81, 22);
            label17.TabIndex = 29;
            label17.Text = "Position:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.MediumSlateBlue;
            label16.Location = new Point(11, 272);
            label16.Name = "label16";
            label16.Size = new Size(54, 22);
            label16.TabIndex = 29;
            label16.Text = "BSN:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.MediumSlateBlue;
            label15.Location = new Point(11, 217);
            label15.Name = "label15";
            label15.Size = new Size(98, 22);
            label15.TabIndex = 29;
            label15.Text = "Birth Date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.MediumSlateBlue;
            label14.Location = new Point(11, 125);
            label14.Name = "label14";
            label14.Size = new Size(132, 22);
            label14.TabIndex = 29;
            label14.Text = "Phone Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.MediumSlateBlue;
            label13.Location = new Point(11, 77);
            label13.Name = "label13";
            label13.Size = new Size(100, 22);
            label13.TabIndex = 29;
            label13.Text = "Last Name:";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(151, 23);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(250, 30);
            tbxFirstName.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.MediumSlateBlue;
            label12.Location = new Point(11, 27);
            label12.Name = "label12";
            label12.Size = new Size(104, 22);
            label12.TabIndex = 29;
            label12.Text = "First Name:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox4.Location = new Point(0, -109);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(144, 617);
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
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(485, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employee Login Info";
            // 
            // button1
            // 
            button1.Location = new Point(151, 168);
            button1.Name = "button1";
            button1.Size = new Size(250, 45);
            button1.TabIndex = 29;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(151, 119);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(250, 30);
            tbxEmail.TabIndex = 29;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(151, 67);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(250, 30);
            tbxPassword.TabIndex = 29;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(151, 12);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(250, 30);
            tbxUsername.TabIndex = 29;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.MediumSlateBlue;
            label21.Location = new Point(25, 119);
            label21.Name = "label21";
            label21.Size = new Size(63, 22);
            label21.TabIndex = 29;
            label21.Text = "Email:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.MediumSlateBlue;
            label20.Location = new Point(25, 71);
            label20.Name = "label20";
            label20.Size = new Size(94, 22);
            label20.TabIndex = 29;
            label20.Text = "Password:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.MediumSlateBlue;
            label19.Location = new Point(25, 23);
            label19.Name = "label19";
            label19.Size = new Size(94, 22);
            label19.TabIndex = 29;
            label19.Text = "Username:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(144, 429);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnPartner);
            tabPage3.Controls.Add(tbxPhonePartner);
            tabPage3.Controls.Add(tbxLastNamePartner);
            tabPage3.Controls.Add(tbxFirstNamePartner);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Location = new Point(4, 54);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(485, 438);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Employee Partner Info";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPartner
            // 
            btnPartner.Location = new Point(170, 192);
            btnPartner.Name = "btnPartner";
            btnPartner.Size = new Size(250, 45);
            btnPartner.TabIndex = 38;
            btnPartner.Text = "Add Partner ";
            btnPartner.UseVisualStyleBackColor = true;
            // 
            // tbxPhonePartner
            // 
            tbxPhonePartner.Location = new Point(170, 140);
            tbxPhonePartner.Name = "tbxPhonePartner";
            tbxPhonePartner.Size = new Size(250, 30);
            tbxPhonePartner.TabIndex = 37;
            // 
            // tbxLastNamePartner
            // 
            tbxLastNamePartner.Location = new Point(170, 86);
            tbxLastNamePartner.Name = "tbxLastNamePartner";
            tbxLastNamePartner.Size = new Size(250, 30);
            tbxLastNamePartner.TabIndex = 36;
            // 
            // tbxFirstNamePartner
            // 
            tbxFirstNamePartner.Location = new Point(170, 37);
            tbxFirstNamePartner.Name = "tbxFirstNamePartner";
            tbxFirstNamePartner.Size = new Size(250, 30);
            tbxFirstNamePartner.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.Location = new Point(26, 143);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 33;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Location = new Point(26, 89);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 32;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Location = new Point(26, 40);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 31;
            label2.Text = "First Name:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(3, -5);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 465);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cmbRole);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(tbxContractType);
            tabPage4.Controls.Add(dtpEndDate);
            tabPage4.Controls.Add(dtpStartDate);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(btnContract);
            tabPage4.Controls.Add(tbxSalary);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Location = new Point(4, 54);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(485, 438);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Employee Contract Info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(29, 239);
            label23.Name = "label23";
            label23.Size = new Size(54, 22);
            label23.TabIndex = 45;
            label23.Text = "Role:";
            // 
            // tbxContractType
            // 
            tbxContractType.Location = new Point(170, 183);
            tbxContractType.Name = "tbxContractType";
            tbxContractType.Size = new Size(250, 30);
            tbxContractType.TabIndex = 43;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(170, 75);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 30);
            dtpEndDate.TabIndex = 42;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(170, 26);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 30);
            dtpStartDate.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 186);
            label8.Name = "label8";
            label8.Size = new Size(55, 22);
            label8.TabIndex = 40;
            label8.Text = "Type:";
            // 
            // btnContract
            // 
            btnContract.Location = new Point(170, 289);
            btnContract.Name = "btnContract";
            btnContract.Size = new Size(250, 50);
            btnContract.TabIndex = 38;
            btnContract.Text = "Add Contract";
            btnContract.UseVisualStyleBackColor = true;
            // 
            // tbxSalary
            // 
            tbxSalary.Location = new Point(170, 127);
            tbxSalary.Name = "tbxSalary";
            tbxSalary.Size = new Size(250, 30);
            tbxSalary.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 130);
            label7.Name = "label7";
            label7.Size = new Size(67, 22);
            label7.TabIndex = 34;
            label7.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 81);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 33;
            label6.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 32);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 32;
            label5.Text = "Start Date:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 465);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnAddress);
            tabPage5.Controls.Add(tbxCountry);
            tabPage5.Controls.Add(tbxZipCode);
            tabPage5.Controls.Add(tbxCity);
            tabPage5.Controls.Add(tbxStreet);
            tabPage5.Controls.Add(label22);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(pictureBox6);
            tabPage5.Location = new Point(4, 54);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(485, 438);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Employee Address Info";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            btnAddress.Location = new Point(165, 236);
            btnAddress.Name = "btnAddress";
            btnAddress.Size = new Size(216, 35);
            btnAddress.TabIndex = 42;
            btnAddress.Text = "Add Address";
            btnAddress.UseVisualStyleBackColor = true;
            // 
            // tbxCountry
            // 
            tbxCountry.Location = new Point(165, 187);
            tbxCountry.Name = "tbxCountry";
            tbxCountry.Size = new Size(216, 30);
            tbxCountry.TabIndex = 41;
            // 
            // tbxZipCode
            // 
            tbxZipCode.Location = new Point(165, 136);
            tbxZipCode.Name = "tbxZipCode";
            tbxZipCode.Size = new Size(216, 30);
            tbxZipCode.TabIndex = 40;
            // 
            // tbxCity
            // 
            tbxCity.Location = new Point(165, 94);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(216, 30);
            tbxCity.TabIndex = 39;
            // 
            // tbxStreet
            // 
            tbxStreet.Location = new Point(165, 44);
            tbxStreet.Name = "tbxStreet";
            tbxStreet.Size = new Size(216, 30);
            tbxStreet.TabIndex = 38;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 190);
            label22.Name = "label22";
            label22.Size = new Size(78, 22);
            label22.TabIndex = 37;
            label22.Text = "Country:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 139);
            label11.Name = "label11";
            label11.Size = new Size(90, 22);
            label11.TabIndex = 36;
            label11.Text = "Zip Code:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 97);
            label10.Name = "label10";
            label10.Size = new Size(49, 22);
            label10.TabIndex = 34;
            label10.Text = "City:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 47);
            label9.Name = "label9";
            label9.Size = new Size(113, 22);
            label9.TabIndex = 33;
            label9.Text = "Street Name:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(144, 465);
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(170, 231);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(250, 30);
            cmbRole.TabIndex = 46;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 660);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private TabPage tabPage5;
        private TextBox tbxPhonePartner;
        private TextBox tbxLastNamePartner;
        private TextBox tbxFirstNamePartner;
        private Button btnPartner;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnContract;
        private TextBox tbxSalary;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox6;
        private Label label22;
        private TextBox tbxZipCode;
        private TextBox tbxCity;
        private TextBox tbxStreet;
        private Button btnAddress;
        private TextBox tbxCountry;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private TextBox tbxContractType;
        private Label label23;
        private ComboBox cmbRole;
    }
}