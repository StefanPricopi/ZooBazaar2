namespace Desktop
{
    partial class ShiftCapacity
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
            tabPage1 = new TabPage();
            numCapacity = new NumericUpDown();
            label9 = new Label();
            tbxDate = new TextBox();
            btnCreate = new Button();
            label5 = new Label();
            cmbShift = new ComboBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            btnUpdateShift = new Button();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUpdateShift);
            tabPage1.Controls.Add(numCapacity);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(tbxDate);
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(label5);
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
            // numCapacity
            // 
            numCapacity.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numCapacity.Location = new Point(25, 295);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(337, 47);
            numCapacity.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 259);
            label9.Name = "label9";
            label9.Size = new Size(379, 33);
            label9.TabIndex = 9;
            label9.Text = "Needed employees for shift";
            // 
            // tbxDate
            // 
            tbxDate.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDate.Location = new Point(25, 123);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(337, 47);
            tbxDate.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(3, 348);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(184, 53);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Add Capacity";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 87);
            label5.Name = "label5";
            label5.Size = new Size(207, 33);
            label5.TabIndex = 3;
            label5.Text = "Selected Date";
            // 
            // cmbShift
            // 
            cmbShift.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            cmbShift.FormattingEnabled = true;
            cmbShift.Location = new Point(25, 209);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(337, 47);
            cmbShift.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 173);
            label1.Name = "label1";
            label1.Size = new Size(157, 33);
            label1.TabIndex = 4;
            label1.Text = "Select Shift";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(-2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(403, 435);
            tabControl1.TabIndex = 10;
            // 
            // btnUpdateShift
            // 
            btnUpdateShift.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateShift.Location = new Point(196, 348);
            btnUpdateShift.Name = "btnUpdateShift";
            btnUpdateShift.Size = new Size(196, 53);
            btnUpdateShift.TabIndex = 11;
            btnUpdateShift.Text = "Update Capacity";
            btnUpdateShift.UseVisualStyleBackColor = true;
            btnUpdateShift.Click += btnUpdateShift_Click_1;
            // 
            // ShiftCapacity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(tabControl1);
            MinimizeBox = false;
            Name = "ShiftCapacity";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AssignEmployee";
            Load += AssignEmployee_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private NumericUpDown numCapacity;
        private Label label9;
        private TextBox tbxDate;
        private Button btnCreate;
        private Label label5;
        private ComboBox cmbShift;
        private Label label1;
        private TabControl tabControl1;
        private Button btnUpdateShift;
    }
}