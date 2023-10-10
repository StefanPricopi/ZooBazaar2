namespace Desktop
{
    partial class CaretakerOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaretakerOverview));
            pictureBox1 = new PictureBox();
            btnOpenAddAnimalForm = new Button();
            pictureBox2 = new PictureBox();
            btnOpenViewAnimalDetailsForm = new Button();
            btnOpenUpdateAnimalForm = new Button();
            btnOpenSearchAnimalForm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-11, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(815, 117);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnOpenAddAnimalForm
            // 
            btnOpenAddAnimalForm.BackColor = SystemColors.ControlDark;
            btnOpenAddAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenAddAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenAddAnimalForm.ForeColor = SystemColors.ControlText;
            btnOpenAddAnimalForm.Image = (Image)resources.GetObject("btnOpenAddAnimalForm.Image");
            btnOpenAddAnimalForm.Location = new Point(175, 134);
            btnOpenAddAnimalForm.Name = "btnOpenAddAnimalForm";
            btnOpenAddAnimalForm.Size = new Size(197, 79);
            btnOpenAddAnimalForm.TabIndex = 4;
            btnOpenAddAnimalForm.Text = "Add Animal";
            btnOpenAddAnimalForm.UseVisualStyleBackColor = false;
            btnOpenAddAnimalForm.Click += btnOpenAddAnimalForm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 342);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnOpenViewAnimalDetailsForm
            // 
            btnOpenViewAnimalDetailsForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenViewAnimalDetailsForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenViewAnimalDetailsForm.FlatAppearance.BorderSize = 0;
            btnOpenViewAnimalDetailsForm.FlatStyle = FlatStyle.Flat;
            btnOpenViewAnimalDetailsForm.Image = Properties.Resources.Screenshot_13;
            btnOpenViewAnimalDetailsForm.Location = new Point(175, 319);
            btnOpenViewAnimalDetailsForm.Margin = new Padding(0);
            btnOpenViewAnimalDetailsForm.Name = "btnOpenViewAnimalDetailsForm";
            btnOpenViewAnimalDetailsForm.Size = new Size(197, 79);
            btnOpenViewAnimalDetailsForm.TabIndex = 6;
            btnOpenViewAnimalDetailsForm.Text = "View Animal Details";
            btnOpenViewAnimalDetailsForm.UseVisualStyleBackColor = false;
            btnOpenViewAnimalDetailsForm.Click += btnOpenViewAnimalDetailsForm_Click;
            // 
            // btnOpenUpdateAnimalForm
            // 
            btnOpenUpdateAnimalForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenUpdateAnimalForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenUpdateAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenUpdateAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenUpdateAnimalForm.Image = Properties.Resources.Screenshot_13;
            btnOpenUpdateAnimalForm.Location = new Point(499, 319);
            btnOpenUpdateAnimalForm.Margin = new Padding(0);
            btnOpenUpdateAnimalForm.Name = "btnOpenUpdateAnimalForm";
            btnOpenUpdateAnimalForm.Size = new Size(197, 79);
            btnOpenUpdateAnimalForm.TabIndex = 7;
            btnOpenUpdateAnimalForm.Text = "Update Animal";
            btnOpenUpdateAnimalForm.UseVisualStyleBackColor = false;
            btnOpenUpdateAnimalForm.Click += btnOpenUpdateAnimalForm_Click;
            // 
            // btnOpenSearchAnimalForm
            // 
            btnOpenSearchAnimalForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpenSearchAnimalForm.BackColor = SystemColors.ActiveCaptionText;
            btnOpenSearchAnimalForm.FlatAppearance.BorderSize = 0;
            btnOpenSearchAnimalForm.FlatStyle = FlatStyle.Flat;
            btnOpenSearchAnimalForm.Image = Properties.Resources.Screenshot_13;
            btnOpenSearchAnimalForm.Location = new Point(499, 134);
            btnOpenSearchAnimalForm.Margin = new Padding(0);
            btnOpenSearchAnimalForm.Name = "btnOpenSearchAnimalForm";
            btnOpenSearchAnimalForm.Size = new Size(197, 79);
            btnOpenSearchAnimalForm.TabIndex = 8;
            btnOpenSearchAnimalForm.Text = "Search Animal";
            btnOpenSearchAnimalForm.UseVisualStyleBackColor = false;
            btnOpenSearchAnimalForm.Click += btnOpenSearchAnimalForm_Click;
            // 
            // CaretakerOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenSearchAnimalForm);
            Controls.Add(btnOpenUpdateAnimalForm);
            Controls.Add(btnOpenViewAnimalDetailsForm);
            Controls.Add(pictureBox2);
            Controls.Add(btnOpenAddAnimalForm);
            Controls.Add(pictureBox1);
            Name = "CaretakerOverview";
            Text = "CaretakerOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnOpenAddAnimalForm;
        private PictureBox pictureBox2;
        private Button btnOpenViewAnimalDetailsForm;
        private Button btnOpenUpdateAnimalForm;
        private Button btnOpenSearchAnimalForm;
    }
}