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
            pictureBox1 = new PictureBox();
            lbText = new Label();
            pnlNav = new Panel();
            pnlContents = new Panel();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.Controls.Add(btnLogOut);
            pnlForm.Controls.Add(pictureBox1);
            pnlForm.Controls.Add(lbText);
            pnlForm.Controls.Add(pnlNav);
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
            btnLogOut.Location = new Point(1557, 158);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(337, 55);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 192);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbText.Location = new Point(400, 169);
            lbText.Name = "lbText";
            lbText.Size = new Size(356, 44);
            lbText.TabIndex = 3;
            lbText.Text = "Display name Here";
            // 
            // pnlNav
            // 
            pnlNav.Location = new Point(0, 219);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(305, 842);
            pnlNav.TabIndex = 1;
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
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlForm;
        private Panel pnlContents;
        private Panel pnlNav;
        private Label lbText;
        private PictureBox pictureBox1;
        private Button btnLogOut;
    }
}