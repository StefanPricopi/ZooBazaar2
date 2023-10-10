namespace Desktop
{
    partial class ManagerOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerOverview));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAreaManagement = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-6, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(810, 117);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 342);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnAreaManagement
            // 
            btnAreaManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAreaManagement.BackColor = SystemColors.ActiveCaptionText;
            btnAreaManagement.FlatAppearance.BorderSize = 0;
            btnAreaManagement.FlatStyle = FlatStyle.Flat;
            btnAreaManagement.Image = Properties.Resources.Screenshot_13;
            btnAreaManagement.Location = new Point(161, 9);
            btnAreaManagement.Margin = new Padding(0);
            btnAreaManagement.Name = "btnAreaManagement";
            btnAreaManagement.Size = new Size(158, 79);
            btnAreaManagement.TabIndex = 7;
            btnAreaManagement.Text = "Manage Areas And Locations";
            btnAreaManagement.UseVisualStyleBackColor = false;
            btnAreaManagement.Click += btnAreaManagement_Click;
            // 
            // ManagerOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAreaManagement);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ManagerOverview";
            Text = "ManagerOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAreaManagement;
    }
}