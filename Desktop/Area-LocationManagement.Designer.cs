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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddArea
            // 
            btnAddArea.BackgroundImage = Properties.Resources.Screenshot_12;
            btnAddArea.FlatAppearance.BorderSize = 0;
            btnAddArea.FlatStyle = FlatStyle.Flat;
            btnAddArea.Location = new Point(12, 415);
            btnAddArea.Name = "btnAddArea";
            btnAddArea.Size = new Size(149, 23);
            btnAddArea.TabIndex = 0;
            btnAddArea.Text = "Add Area";
            btnAddArea.UseVisualStyleBackColor = true;
            btnAddArea.Click += btnAddArea_Click;
            // 
            // rbLocationActive
            // 
            rbLocationActive.AutoSize = true;
            rbLocationActive.Location = new Point(411, 359);
            rbLocationActive.Name = "rbLocationActive";
            rbLocationActive.Size = new Size(58, 19);
            rbLocationActive.TabIndex = 1;
            rbLocationActive.TabStop = true;
            rbLocationActive.Text = "Active";
            rbLocationActive.UseVisualStyleBackColor = true;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(411, 330);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(185, 23);
            cbArea.TabIndex = 3;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Location = new Point(411, 312);
            Area.Name = "Area";
            Area.Size = new Size(31, 15);
            Area.TabIndex = 4;
            Area.Text = "Area";
            // 
            // tbAreaName
            // 
            tbAreaName.Location = new Point(12, 279);
            tbAreaName.Name = "tbAreaName";
            tbAreaName.Size = new Size(377, 23);
            tbAreaName.TabIndex = 5;
            // 
            // tbLocationName
            // 
            tbLocationName.Location = new Point(411, 279);
            tbLocationName.Name = "tbLocationName";
            tbLocationName.Size = new Size(377, 23);
            tbLocationName.TabIndex = 6;
            // 
            // btnEditArea
            // 
            btnEditArea.BackColor = Color.Transparent;
            btnEditArea.BackgroundImage = Properties.Resources.Screenshot_12;
            btnEditArea.FlatAppearance.BorderSize = 0;
            btnEditArea.FlatStyle = FlatStyle.Flat;
            btnEditArea.Location = new Point(215, 415);
            btnEditArea.Name = "btnEditArea";
            btnEditArea.Size = new Size(149, 23);
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
            btnAddLocation.Location = new Point(411, 415);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(149, 23);
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
            btnEditLocation.Location = new Point(612, 415);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(149, 23);
            btnEditLocation.TabIndex = 9;
            btnEditLocation.Text = "Edit Location";
            btnEditLocation.UseVisualStyleBackColor = true;
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // rbLocationInactive
            // 
            rbLocationInactive.AutoSize = true;
            rbLocationInactive.Location = new Point(475, 359);
            rbLocationInactive.Name = "rbLocationInactive";
            rbLocationInactive.Size = new Size(66, 19);
            rbLocationInactive.TabIndex = 10;
            rbLocationInactive.TabStop = true;
            rbLocationInactive.Text = "Inactive";
            rbLocationInactive.UseVisualStyleBackColor = true;
            // 
            // rbAreaInactive
            // 
            rbAreaInactive.AutoSize = true;
            rbAreaInactive.Location = new Point(76, 359);
            rbAreaInactive.Name = "rbAreaInactive";
            rbAreaInactive.Size = new Size(66, 19);
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
            rbAreaActive.Location = new Point(12, 359);
            rbAreaActive.Name = "rbAreaActive";
            rbAreaActive.Size = new Size(57, 19);
            rbAreaActive.TabIndex = 11;
            rbAreaActive.TabStop = true;
            rbAreaActive.Text = "Active";
            rbAreaActive.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 261);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Name";
            // 
            // lbArea
            // 
            lbArea.FormattingEnabled = true;
            lbArea.ItemHeight = 15;
            lbArea.Location = new Point(12, 77);
            lbArea.Name = "lbArea";
            lbArea.Size = new Size(377, 184);
            lbArea.TabIndex = 15;
            lbArea.SelectedIndexChanged += lbArea_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = Properties.Resources.Screenshot_14;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 16;
            label1.Text = "Areas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = Properties.Resources.Screenshot_12;
            label4.Location = new Point(411, 54);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 18;
            label4.Text = "Locations";
            // 
            // lbLocations
            // 
            lbLocations.FormattingEnabled = true;
            lbLocations.ItemHeight = 15;
            lbLocations.Location = new Point(411, 74);
            lbLocations.Name = "lbLocations";
            lbLocations.Size = new Size(377, 184);
            lbLocations.TabIndex = 17;
            lbLocations.SelectedIndexChanged += lbLocations_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Image = Properties.Resources.Screenshot_13;
            label5.Location = new Point(99, 22);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 19;
            label5.Text = "Manage Areas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Image = Properties.Resources.Screenshot_12;
            label6.Location = new Point(524, 22);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 20;
            label6.Text = "Manage Locations";
            // 
            // tbCapacity
            // 
            tbCapacity.Location = new Point(602, 330);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(186, 23);
            tbCapacity.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 312);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 22;
            label7.Text = "Capacity";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-6, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 84);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-6, 384);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(822, 84);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // Area_LocationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Area_LocationManagement";
            Text = "Area_LocationManagement";
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
    }
}