namespace Animals
{
    partial class AddAnimal
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
            tbxName = new TextBox();
            tbxSpecies = new TextBox();
            tbxAge = new TextBox();
            tbxLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddAnimal = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbxName
            // 
            tbxName.Location = new Point(84, 68);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(160, 23);
            tbxName.TabIndex = 0;
            // 
            // tbxSpecies
            // 
            tbxSpecies.Location = new Point(84, 105);
            tbxSpecies.Name = "tbxSpecies";
            tbxSpecies.Size = new Size(160, 23);
            tbxSpecies.TabIndex = 1;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(84, 143);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(39, 23);
            tbxAge.TabIndex = 2;
            // 
            // tbxLocation
            // 
            tbxLocation.Location = new Point(84, 184);
            tbxLocation.Name = "tbxLocation";
            tbxLocation.Size = new Size(160, 23);
            tbxLocation.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 112);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 5;
            label2.Text = "Species:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 150);
            label3.Name = "label3";
            label3.Size = new Size(31, 16);
            label3.TabIndex = 6;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 191);
            label4.Name = "label4";
            label4.Size = new Size(58, 16);
            label4.TabIndex = 7;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSlateBlue;
            label5.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 18);
            label5.Name = "label5";
            label5.Size = new Size(106, 22);
            label5.TabIndex = 8;
            label5.Text = "Add Animal";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAnimal.Location = new Point(84, 219);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(152, 28);
            btnAddAnimal.TabIndex = 9;
            btnAddAnimal.Text = "Add animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-8, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 80);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_14;
            pictureBox2.Location = new Point(-8, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 203);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 259);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddAnimal);
            Controls.Add(tbxLocation);
            Controls.Add(tbxAge);
            Controls.Add(tbxSpecies);
            Controls.Add(tbxName);
            Name = "AddAnimal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private TextBox tbxSpecies;
        private TextBox tbxAge;
        private TextBox tbxLocation;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddAnimal;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

