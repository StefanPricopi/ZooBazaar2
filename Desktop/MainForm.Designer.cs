namespace Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlForm = new Panel();
            btnLogOut = new Button();
            lbText = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnlNav = new Panel();
            pictureBox2 = new PictureBox();
            pnlContents = new Panel();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.Controls.Add(btnLogOut);
            pnlForm.Controls.Add(lbText);
            pnlForm.Controls.Add(pictureBox1);
            pnlForm.Controls.Add(pictureBox3);
            pnlForm.Controls.Add(pnlNav);
            pnlForm.Controls.Add(pictureBox2);
            pnlForm.Controls.Add(pnlContents);
            pnlForm.Location = new Point(0, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1921, 1061);
            pnlForm.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(1559, 145);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(337, 55);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // lbText
            // 
            lbText.BackColor = Color.Transparent;
            lbText.FlatStyle = FlatStyle.Flat;
            lbText.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbText.ImageAlign = ContentAlignment.MiddleLeft;
            lbText.Location = new Point(400, 169);
            lbText.Name = "lbText";
            lbText.Size = new Size(356, 44);
            lbText.TabIndex = 8;
            lbText.Text = "Display name Here";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(337, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1649, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkViolet;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(15, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(302, 192);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.DarkViolet;
            pnlNav.ForeColor = Color.GhostWhite;
            pnlNav.Location = new Point(12, 236);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(305, 793);
            pnlNav.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 1106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pnlContents
            // 
            pnlContents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContents.Location = new Point(400, 274);
            pnlContents.Name = "pnlContents";
            pnlContents.Size = new Size(1512, 775);
            pnlContents.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(pnlForm);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlForm;
        private Panel pnlContents;
        private PictureBox pictureBox3;
        private Panel pnlNav;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLogOut;
        private Label lbText;
    }
}