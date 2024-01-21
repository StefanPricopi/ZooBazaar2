namespace Desktop
{
    partial class Announcements
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
            button1 = new Button();
            label1 = new Label();
            cbDepartment = new ComboBox();
            rtbText = new RichTextBox();
            tbTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbAnnouncements = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 367);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Create Announcement";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Department :";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(24, 48);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(121, 23);
            cbDepartment.TabIndex = 2;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // rtbText
            // 
            rtbText.Location = new Point(24, 165);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(273, 185);
            rtbText.TabIndex = 3;
            rtbText.Text = "";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(24, 107);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(100, 23);
            tbTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Text :";
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 15;
            lbAnnouncements.Location = new Point(382, 31);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(353, 319);
            lbAnnouncements.TabIndex = 7;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(222, 367);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Announcement";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lbAnnouncements);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbTitle);
            Controls.Add(rtbText);
            Controls.Add(cbDepartment);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Announcements";
            Text = "Announcements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox cbDepartment;
        private RichTextBox rtbText;
        private TextBox tbTitle;
        private Label label2;
        private Label label3;
        private ListBox lbAnnouncements;
        private Button btnEdit;
        private Button btnDelete;
    }
}