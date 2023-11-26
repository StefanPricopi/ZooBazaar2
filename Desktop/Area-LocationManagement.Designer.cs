namespace Desktop
{
    partial class Area_LocationManagement
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
            btnAddArea = new Button();
            rbLocationActive = new RadioButton();
            cbArea = new ComboBox();
            Area = new Label();
            tbAreaName = new TextBox();
            tbLocationName = new TextBox();
            btnEditArea = new Button();
            btnAddLocation = new Button();
            btnEditLocation = new Button();
            rbLocationInactive = new RadioButton();
            rbAreaInactive = new RadioButton();
            rbAreaActive = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            lbArea = new ListBox();
            label1 = new Label();
            label4 = new Label();
            lbLocations = new ListBox();
            label5 = new Label();
            label6 = new Label();
            tbCapacity = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRefresh = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddArea
            // 
            btnAddArea.BackgroundImage = Properties.Resources.Screenshot_12;
            btnAddArea.FlatAppearance.BorderSize = 0;
            btnAddArea.FlatStyle = FlatStyle.Flat;
            btnAddArea.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddArea.ForeColor = Color.Cyan;
            btnAddArea.Location = new Point(124, 712);
            btnAddArea.Margin = new Padding(4);
            btnAddArea.Name = "btnAddArea";
            btnAddArea.Size = new Size(270, 45);
            btnAddArea.TabIndex = 0;
            btnAddArea.Text = "Add Area";
            btnAddArea.UseVisualStyleBackColor = true;
            btnAddArea.Click += btnAddArea_Click;
            // 
            // rbLocationActive
            // 
            rbLocationActive.AutoSize = true;
            rbLocationActive.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbLocationActive.Location = new Point(741, 601);
            rbLocationActive.Margin = new Padding(4);
            rbLocationActive.Name = "rbLocationActive";
            rbLocationActive.Size = new Size(90, 26);
            rbLocationActive.TabIndex = 1;
            rbLocationActive.TabStop = true;
            rbLocationActive.Text = "Active";
            rbLocationActive.UseVisualStyleBackColor = true;
            // 
            // cbArea
            // 
            cbArea.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(746, 508);
            cbArea.Margin = new Padding(4);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(263, 29);
            cbArea.TabIndex = 3;
            cbArea.SelectedIndexChanged += cbArea_SelectedIndexChanged;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Area.Location = new Point(746, 482);
            Area.Margin = new Padding(4, 0, 4, 0);
            Area.Name = "Area";
            Area.Size = new Size(56, 22);
            Area.TabIndex = 4;
            Area.Text = "Area";
            Area.Click += Area_Click;
            // 
            // tbAreaName
            // 
            tbAreaName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAreaName.Location = new Point(13, 452);
            tbAreaName.Margin = new Padding(4);
            tbAreaName.Name = "tbAreaName";
            tbAreaName.Size = new Size(537, 27);
            tbAreaName.TabIndex = 5;
            // 
            // tbLocationName
            // 
            tbLocationName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLocationName.Location = new Point(746, 452);
            tbLocationName.Margin = new Padding(4);
            tbLocationName.Name = "tbLocationName";
            tbLocationName.Size = new Size(263, 27);
            tbLocationName.TabIndex = 6;
            tbLocationName.TextChanged += tbLocationName_TextChanged;
            // 
            // btnEditArea
            // 
            btnEditArea.BackColor = Color.Transparent;
            btnEditArea.BackgroundImage = Properties.Resources.Screenshot_12;
            btnEditArea.FlatAppearance.BorderSize = 0;
            btnEditArea.FlatStyle = FlatStyle.Flat;
            btnEditArea.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditArea.ForeColor = Color.Cyan;
            btnEditArea.Location = new Point(459, 712);
            btnEditArea.Margin = new Padding(4);
            btnEditArea.Name = "btnEditArea";
            btnEditArea.Size = new Size(270, 45);
            btnEditArea.TabIndex = 7;
            btnEditArea.Text = "Edit Area";
            btnEditArea.UseVisualStyleBackColor = false;
            btnEditArea.Click += btnEditArea_Click;
            // 
            // btnAddLocation
            // 
            btnAddLocation.BackgroundImage = Properties.Resources.Screenshot_12;
            btnAddLocation.FlatAppearance.BorderSize = 0;
            btnAddLocation.FlatStyle = FlatStyle.Flat;
            btnAddLocation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLocation.ForeColor = Color.Cyan;
            btnAddLocation.Location = new Point(787, 712);
            btnAddLocation.Margin = new Padding(4);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(270, 45);
            btnAddLocation.TabIndex = 8;
            btnAddLocation.Text = "Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // btnEditLocation
            // 
            btnEditLocation.BackgroundImage = Properties.Resources.Screenshot_12;
            btnEditLocation.FlatAppearance.BorderSize = 0;
            btnEditLocation.FlatStyle = FlatStyle.Flat;
            btnEditLocation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditLocation.ForeColor = Color.Cyan;
            btnEditLocation.Location = new Point(1131, 713);
            btnEditLocation.Margin = new Padding(4);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(270, 45);
            btnEditLocation.TabIndex = 9;
            btnEditLocation.Text = "Edit Location";
            btnEditLocation.UseVisualStyleBackColor = true;
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // rbLocationInactive
            // 
            rbLocationInactive.AutoSize = true;
            rbLocationInactive.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbLocationInactive.Location = new Point(930, 601);
            rbLocationInactive.Margin = new Padding(4);
            rbLocationInactive.Name = "rbLocationInactive";
            rbLocationInactive.Size = new Size(105, 26);
            rbLocationInactive.TabIndex = 10;
            rbLocationInactive.TabStop = true;
            rbLocationInactive.Text = "Inactive";
            rbLocationInactive.UseVisualStyleBackColor = true;
            // 
            // rbAreaInactive
            // 
            rbAreaInactive.AutoSize = true;
            rbAreaInactive.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbAreaInactive.Location = new Point(197, 567);
            rbAreaInactive.Margin = new Padding(4);
            rbAreaInactive.Name = "rbAreaInactive";
            rbAreaInactive.Size = new Size(105, 26);
            rbAreaInactive.TabIndex = 12;
            rbAreaInactive.TabStop = true;
            rbAreaInactive.Text = "Inactive";
            rbAreaInactive.UseVisualStyleBackColor = true;
            // 
            // rbAreaActive
            // 
            rbAreaActive.AutoSize = true;
            rbAreaActive.BackColor = Color.Transparent;
            rbAreaActive.FlatStyle = FlatStyle.Flat;
            rbAreaActive.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbAreaActive.Location = new Point(3, 567);
            rbAreaActive.Margin = new Padding(4);
            rbAreaActive.Name = "rbAreaActive";
            rbAreaActive.Size = new Size(89, 26);
            rbAreaActive.TabIndex = 11;
            rbAreaActive.TabStop = true;
            rbAreaActive.Text = "Active";
            rbAreaActive.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 13;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(746, 426);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 14;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // lbArea
            // 
            lbArea.FormattingEnabled = true;
            lbArea.ItemHeight = 21;
            lbArea.Location = new Point(17, 108);
            lbArea.Margin = new Padding(4);
            lbArea.Name = "lbArea";
            lbArea.Size = new Size(712, 298);
            lbArea.TabIndex = 15;
            lbArea.SelectedIndexChanged += lbArea_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Image = Properties.Resources.Screenshot_14;
            label1.Location = new Point(17, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 16;
            label1.Text = "Areas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Image = Properties.Resources.Screenshot_12;
            label4.Location = new Point(746, 76);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 18;
            label4.Text = "Locations";
            // 
            // lbLocations
            // 
            lbLocations.FormattingEnabled = true;
            lbLocations.ItemHeight = 21;
            lbLocations.Location = new Point(746, 108);
            lbLocations.Margin = new Padding(4);
            lbLocations.Name = "lbLocations";
            lbLocations.Size = new Size(737, 298);
            lbLocations.TabIndex = 17;
            lbLocations.SelectedIndexChanged += lbLocations_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Cyan;
            label5.Image = Properties.Resources.Screenshot_13;
            label5.Location = new Point(17, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 19;
            label5.Text = "Manage Areas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Image = Properties.Resources.Screenshot_12;
            label6.Location = new Point(746, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 23);
            label6.TabIndex = 20;
            label6.Text = "Manage Locations";
            // 
            // tbCapacity
            // 
            tbCapacity.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCapacity.Location = new Point(1019, 452);
            tbCapacity.Margin = new Padding(4);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(242, 27);
            tbCapacity.TabIndex = 21;
            tbCapacity.TextChanged += tbCapacity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1019, 426);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(242, 22);
            label7.TabIndex = 22;
            label7.Text = "Max amount of habitants";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-9, -18);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2147, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-9, 663);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2147, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(443, 561);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 32);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(737, 108);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 540);
            panel1.TabIndex = 78;
            // 
            // Area_LocationManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 772);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(rbAreaActive);
            Controls.Add(rbAreaInactive);
            Controls.Add(rbLocationInactive);
            Controls.Add(rbLocationActive);
            Controls.Add(btnEditLocation);
            Controls.Add(btnAddLocation);
            Controls.Add(btnEditArea);
            Controls.Add(btnAddArea);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(tbCapacity);
            Controls.Add(lbLocations);
            Controls.Add(lbArea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbLocationName);
            Controls.Add(tbAreaName);
            Controls.Add(Area);
            Controls.Add(cbArea);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Area_LocationManagement";
            Text = "Area_LocationManagement";
            Load += Area_LocationManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddArea;
        private RadioButton rbLocationActive;
        private ComboBox cbArea;
        private Label Area;
        private TextBox tbAreaName;
        private TextBox tbLocationName;
        private Button btnEditArea;
        private Button btnAddLocation;
        private Button btnEditLocation;
        private RadioButton rbLocationInactive;
        private RadioButton rbAreaInactive;
        private RadioButton rbAreaActive;
        private Label label2;
        private Label label3;
        private ListBox lbArea;
        private Label label1;
        private Label label4;
        private ListBox lbLocations;
        private Label label5;
        private Label label6;
        private TextBox tbCapacity;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnRefresh;
        private Panel panel1;
    }
}