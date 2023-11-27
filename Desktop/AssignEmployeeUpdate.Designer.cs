namespace Desktop
{
    partial class AssignEmployeeUpdate
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
            dataGridView1 = new DataGridView();
            cmbArea = new ComboBox();
            label3 = new Label();
            cmbShift = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbEmployee = new ComboBox();
            tbxDate = new TextBox();
            btnEmpUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(133, 282);
            dataGridView1.TabIndex = 0;
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(151, 201);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(184, 23);
            cmbArea.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(151, 174);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 14;
            label3.Text = "Select Area/Location";
            // 
            // cmbShift
            // 
            cmbShift.FormattingEnabled = true;
            cmbShift.Location = new Point(151, 148);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(184, 23);
            cmbShift.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(151, 121);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 12;
            label1.Text = "Select Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 68);
            label2.Name = "label2";
            label2.Size = new Size(184, 24);
            label2.TabIndex = 11;
            label2.Text = "Select Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(151, 95);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(184, 23);
            cmbEmployee.TabIndex = 10;
            // 
            // tbxDate
            // 
            tbxDate.Location = new Point(151, 35);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(184, 23);
            tbxDate.TabIndex = 8;
            // 
            // btnEmpUpdate
            // 
            btnEmpUpdate.Location = new Point(151, 234);
            btnEmpUpdate.Name = "btnEmpUpdate";
            btnEmpUpdate.Size = new Size(184, 23);
            btnEmpUpdate.TabIndex = 16;
            btnEmpUpdate.Text = "Update";
            btnEmpUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(151, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Update";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // AssignEmployeeUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 328);
            Controls.Add(btnDelete);
            Controls.Add(btnEmpUpdate);
            Controls.Add(cmbArea);
            Controls.Add(label3);
            Controls.Add(cmbShift);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(tbxDate);
            Controls.Add(dataGridView1);
            Name = "AssignEmployeeUpdate";
            Text = "AssignEmployeeUpdate";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbArea;
        private Label label3;
        private ComboBox cmbShift;
        private Label label1;
        private Label label2;
        private ComboBox cmbEmployee;
        private TextBox tbxDate;
        private Button btnEmpUpdate;
        private Button btnDelete;
    }
}