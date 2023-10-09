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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(42, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 34);
            label1.Name = "label1";
            label1.Size = new Size(313, 20);
            label1.TabIndex = 1;
            label1.Text = "Select a day to view the scheduled employees";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(310, 207);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(42, 357);
            button1.Name = "button1";
            button1.Size = new Size(262, 29);
            button1.TabIndex = 3;
            button1.Text = "Add Employee to selected date";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddEmployee_Click;
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(42, 323);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(262, 28);
            cmbEmployees.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 291);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 5;
            label2.Text = "Select an employee to add them to schedule";
            // 
            // EmployeeSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(cmbEmployees);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "EmployeeSchedule";
            Text = "EmployeeSchedule";
            Load += EmployeeScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}