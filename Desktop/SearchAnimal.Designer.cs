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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(22, 143);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 53);
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
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(153, 29);
            label1.TabIndex = 2;
            label1.Text = "Search Animal";
            // 
            // listAnimals
            // 
            listAnimals.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listAnimals.FormattingEnabled = true;
            listAnimals.ItemHeight = 19;
            listAnimals.Location = new Point(22, 204);
            listAnimals.Margin = new Padding(3, 4, 3, 4);
            listAnimals.Name = "listAnimals";
            listAnimals.Size = new Size(401, 118);
            listAnimals.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-6, -9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 93);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Desktop.Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-6, 348);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 68);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // SearchAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 403);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listAnimals);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}