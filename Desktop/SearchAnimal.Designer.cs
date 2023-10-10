namespace Animals
{
    partial class SearchAnimal
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
            btnSearch = new Button();
            label1 = new Label();
            listAnimals = new ListBox();
            tbxSearch = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(19, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 22);
            label1.TabIndex = 2;
            label1.Text = "Search Animal";
            // 
            // listAnimals
            // 
            listAnimals.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listAnimals.FormattingEnabled = true;
            listAnimals.ItemHeight = 14;
            listAnimals.Location = new Point(19, 153);
            listAnimals.Name = "listAnimals";
            listAnimals.Size = new Size(351, 102);
            listAnimals.TabIndex = 3;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(71, 69);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(134, 23);
            tbxSearch.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Search:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-5, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 70);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-5, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(419, 51);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // SearchAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 302);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(tbxSearch);
            Controls.Add(listAnimals);
            Controls.Add(btnSearch);
            Name = "SearchAnimal";
            Text = "SearchAnimal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private ListBox listAnimals;
        private TextBox tbxSearch;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}