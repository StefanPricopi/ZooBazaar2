namespace Desktop
{
    partial class AssignEmployee
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
            tbxDate = new TextBox();
            cmbEmployee = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbShift = new ComboBox();
            label3 = new Label();
            cmbArea = new ComboBox();
            btnCreate = new Button();
            btnUpdateShift = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            cmbEmployeeType = new ComboBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            btnDeleteShift = new Button();
            tbxUpdateDate = new TextBox();
            cmbUpdateArea = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbUpdateEmployee = new ComboBox();
            cmbUpdateShift = new ComboBox();
            label8 = new Label();
            dgvShifts = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShifts).BeginInit();
            SuspendLayout();
            // 
            // tbxDate
            // 
            tbxDate.Location = new Point(23, 49);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(361, 27);
            tbxDate.TabIndex = 0;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(23, 195);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(361, 29);
            cmbEmployee.TabIndex = 2;
            cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 94);
            label2.Name = "label2";
            label2.Size = new Size(375, 24);
            label2.TabIndex = 3;
            label2.Text = "Select type of employee availablity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 227);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 4;
            label1.Text = "Select Shift";
            // 
            // cmbShift
            // 
            cmbShift.FormattingEnabled = true;
            cmbShift.Location = new Point(23, 254);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(361, 29);
            cmbShift.TabIndex = 5;
            cmbShift.SelectedIndexChanged += cmbShift_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 286);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 6;
            label3.Text = "Select Area/Location";
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(23, 313);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(361, 29);
            cmbArea.TabIndex = 7;
            cmbArea.SelectedIndexChanged += cmbArea_SelectedIndexChanged;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(23, 348);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(361, 53);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create Shift";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdateShift
            // 
            btnUpdateShift.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateShift.Location = new Point(9, 345);
            btnUpdateShift.Name = "btnUpdateShift";
            btnUpdateShift.Size = new Size(232, 53);
            btnUpdateShift.TabIndex = 9;
            btnUpdateShift.Text = "Update Shift";
            btnUpdateShift.UseVisualStyleBackColor = true;
            btnUpdateShift.Click += btnUpdateShift_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(-2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(403, 435);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(cmbEmployeeType);
            tabPage1.Controls.Add(tbxDate);
            tabPage1.Controls.Add(cmbArea);
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cmbEmployee);
            tabPage1.Controls.Add(cmbShift);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(395, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 168);
            label9.Name = "label9";
            label9.Size = new Size(184, 24);
            label9.TabIndex = 10;
            label9.Text = "Select Employee";
            // 
            // cmbEmployeeType
            // 
            cmbEmployeeType.FormattingEnabled = true;
            cmbEmployeeType.Location = new Point(23, 121);
            cmbEmployeeType.Name = "cmbEmployeeType";
            cmbEmployeeType.Size = new Size(361, 29);
            cmbEmployeeType.TabIndex = 9;
            cmbEmployeeType.SelectedIndexChanged += cmbEmployeeType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 22);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 3;
            label5.Text = "Selected Date";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteShift);
            tabPage2.Controls.Add(tbxUpdateDate);
            tabPage2.Controls.Add(cmbUpdateArea);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cmbUpdateEmployee);
            tabPage2.Controls.Add(cmbUpdateShift);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dgvShifts);
            tabPage2.Controls.Add(btnUpdateShift);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(395, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete/Update";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnDeleteShift
            // 
            btnDeleteShift.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteShift.Location = new Point(245, 345);
            btnDeleteShift.Name = "btnDeleteShift";
            btnDeleteShift.Size = new Size(147, 53);
            btnDeleteShift.TabIndex = 19;
            btnDeleteShift.Text = "Delete Shift";
            btnDeleteShift.UseVisualStyleBackColor = true;
            btnDeleteShift.Click += btnDeleteShift_Click;
            // 
            // tbxUpdateDate
            // 
            tbxUpdateDate.Location = new Point(247, 41);
            tbxUpdateDate.Name = "tbxUpdateDate";
            tbxUpdateDate.Size = new Size(118, 27);
            tbxUpdateDate.TabIndex = 11;
            // 
            // cmbUpdateArea
            // 
            cmbUpdateArea.FormattingEnabled = true;
            cmbUpdateArea.Location = new Point(252, 261);
            cmbUpdateArea.Name = "cmbUpdateArea";
            cmbUpdateArea.Size = new Size(118, 29);
            cmbUpdateArea.TabIndex = 18;
            cmbUpdateArea.SelectedIndexChanged += cmbUpdateArea_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(247, 217);
            label4.Name = "label4";
            label4.Size = new Size(145, 53);
            label4.TabIndex = 17;
            label4.Text = "Select Area/Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(247, 14);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 13;
            label6.Text = "Selected Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(247, 86);
            label7.Name = "label7";
            label7.Size = new Size(138, 21);
            label7.TabIndex = 14;
            label7.Text = "Select Employee";
            // 
            // cmbUpdateEmployee
            // 
            cmbUpdateEmployee.FormattingEnabled = true;
            cmbUpdateEmployee.Location = new Point(247, 113);
            cmbUpdateEmployee.Name = "cmbUpdateEmployee";
            cmbUpdateEmployee.Size = new Size(118, 29);
            cmbUpdateEmployee.TabIndex = 12;
            // 
            // cmbUpdateShift
            // 
            cmbUpdateShift.FormattingEnabled = true;
            cmbUpdateShift.Location = new Point(247, 185);
            cmbUpdateShift.Name = "cmbUpdateShift";
            cmbUpdateShift.Size = new Size(118, 29);
            cmbUpdateShift.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(247, 158);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 15;
            label8.Text = "Select Shift";
            // 
            // dgvShifts
            // 
            dgvShifts.BackgroundColor = Color.White;
            dgvShifts.BorderStyle = BorderStyle.None;
            dgvShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShifts.Location = new Point(3, 14);
            dgvShifts.Name = "dgvShifts";
            dgvShifts.RowTemplate.Height = 25;
            dgvShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShifts.Size = new Size(238, 328);
            dgvShifts.TabIndex = 10;
            // 
            // AssignEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(tabControl1);
            MinimizeBox = false;
            Name = "AssignEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AssignEmployee";
            Load += AssignEmployee_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShifts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxDate;
        private ComboBox cmbEmployee;
        private Label label2;
        private Label label1;
        private ComboBox cmbShift;
        private Label label3;
        private ComboBox cmbArea;
        private Button btnCreate;
        private Button btnUpdateShift;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label5;
        private TabPage tabPage2;
        private DataGridView dgvShifts;
        private TextBox tbxUpdateDate;
        private ComboBox cmbUpdateArea;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox cmbUpdateEmployee;
        private ComboBox cmbUpdateShift;
        private Label label8;
        private Button btnDeleteShift;
        private Label label9;
        private ComboBox cmbEmployeeType;
    }
}