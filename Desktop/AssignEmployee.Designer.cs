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
            tbxShiftType = new TextBox();
            cmbEmployee = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbShift = new ComboBox();
            label3 = new Label();
            cmbArea = new ComboBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // tbxDate
            // 
            tbxDate.Location = new Point(88, 94);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(184, 23);
            tbxDate.TabIndex = 0;
            // 
            // tbxShiftType
            // 
            tbxShiftType.Location = new Point(88, 163);
            tbxShiftType.Name = "tbxShiftType";
            tbxShiftType.Size = new Size(184, 23);
            tbxShiftType.TabIndex = 1;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(88, 231);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(184, 23);
            cmbEmployee.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 204);
            label2.Name = "label2";
            label2.Size = new Size(184, 24);
            label2.TabIndex = 3;
            label2.Text = "Select Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 257);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 4;
            label1.Text = "Select Shift";
            // 
            // cmbShift
            // 
            cmbShift.FormattingEnabled = true;
            cmbShift.Location = new Point(88, 284);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(184, 23);
            cmbShift.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(88, 310);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 6;
            label3.Text = "Select Area/Location";
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(88, 337);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(184, 23);
            cmbArea.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(88, 385);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(184, 53);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create Shift";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // AssignEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(btnCreate);
            Controls.Add(cmbArea);
            Controls.Add(label3);
            Controls.Add(cmbShift);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(tbxShiftType);
            Controls.Add(tbxDate);
            Name = "AssignEmployee";
            Text = "AssignEmployee";
            Load += AssignEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxDate;
        private TextBox tbxShiftType;
        private ComboBox cmbEmployee;
        private Label label2;
        private Label label1;
        private ComboBox cmbShift;
        private Label label3;
        private ComboBox cmbArea;
        private Button btnCreate;
    }
}