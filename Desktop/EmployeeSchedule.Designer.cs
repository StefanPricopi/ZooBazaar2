namespace Employees
{
    partial class EmployeeSchedule
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            cmbEmployees = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(38, 56);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(247, 15);
            label1.TabIndex = 1;
            label1.Text = "Select a day to view the scheduled employees";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(320, 56);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(271, 162);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(38, 278);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(229, 22);
            button1.TabIndex = 3;
            button1.Text = "Add Employee to selected date";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddEmployee_Click;
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(37, 242);
            cmbEmployees.Margin = new Padding(3, 2, 3, 2);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(230, 23);
            cmbEmployees.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 218);
            label2.Name = "label2";
            label2.Size = new Size(241, 15);
            label2.TabIndex = 5;
            label2.Text = "Select an employee to add them to schedule";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-11, 269);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 69);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-11, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(713, 62);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox3.Location = new Point(-11, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 231);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // EmployeeSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(cmbEmployees);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeSchedule";
            Text = "EmployeeSchedule";
            Load += EmployeeScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox cmbEmployees;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}