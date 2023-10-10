namespace Animals
{
    partial class UpdateAnimal
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
            btnUpdate = new Button();
            comboSpecies = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxLocation = new TextBox();
            tbxAge = new TextBox();
            tbxSpecies = new TextBox();
            comboAnimal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(13, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // comboSpecies
            // 
            comboSpecies.FormattingEnabled = true;
            comboSpecies.Location = new Point(78, 19);
            comboSpecies.Name = "comboSpecies";
            comboSpecies.Size = new Size(106, 23);
            comboSpecies.TabIndex = 3;
            comboSpecies.SelectedIndexChanged += comboSpecies_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 220);
            label4.Name = "label4";
            label4.Size = new Size(58, 16);
            label4.TabIndex = 14;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 183);
            label5.Name = "label5";
            label5.Size = new Size(31, 16);
            label5.TabIndex = 13;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 144);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 12;
            label6.Text = "Species:";
            // 
            // tbxLocation
            // 
            tbxLocation.Location = new Point(78, 218);
            tbxLocation.Name = "tbxLocation";
            tbxLocation.Size = new Size(160, 23);
            tbxLocation.TabIndex = 11;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(78, 177);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(39, 23);
            tbxAge.TabIndex = 10;
            // 
            // tbxSpecies
            // 
            tbxSpecies.Location = new Point(78, 139);
            tbxSpecies.Name = "tbxSpecies";
            tbxSpecies.Size = new Size(160, 23);
            tbxSpecies.TabIndex = 9;
            // 
            // comboAnimal
            // 
            comboAnimal.FormattingEnabled = true;
            comboAnimal.Location = new Point(78, 48);
            comboAnimal.Name = "comboAnimal";
            comboAnimal.Size = new Size(106, 23);
            comboAnimal.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 98);
            label1.Name = "label1";
            label1.Size = new Size(128, 22);
            label1.TabIndex = 16;
            label1.Text = "Update Animal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 17;
            label2.Text = "Species:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 52);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 18;
            label3.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 87);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // UpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 310);
            Controls.Add(comboAnimal);
            Controls.Add(comboSpecies);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbxLocation);
            Controls.Add(tbxAge);
            Controls.Add(tbxSpecies);
            Controls.Add(btnUpdate);
            Name = "UpdateAnimal";
            Text = "UpdateAnimal";
            Load += UpdateAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ComboBox comboSpecies;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxLocation;
        private TextBox tbxAge;
        private TextBox tbxSpecies;
        private ComboBox comboAnimal;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}