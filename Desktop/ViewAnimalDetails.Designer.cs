namespace Animals
{
    partial class ViewAnimalDetails
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
            comboSpecies = new ComboBox();
            listAnimals = new ListBox();
            btnViewDetails = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            tbxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboSpecies
            // 
            comboSpecies.FormattingEnabled = true;
            comboSpecies.Location = new Point(77, 85);
            comboSpecies.Margin = new Padding(3, 4, 3, 4);
            comboSpecies.Name = "comboSpecies";
            comboSpecies.Size = new Size(121, 28);
            comboSpecies.TabIndex = 0;
            // 
            // listAnimals
            // 
            listAnimals.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listAnimals.FormattingEnabled = true;
            listAnimals.ItemHeight = 19;
            listAnimals.Location = new Point(13, 178);
            listAnimals.Margin = new Padding(3, 4, 3, 4);
            listAnimals.Name = "listAnimals";
            listAnimals.Size = new Size(401, 137);
            listAnimals.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewDetails.Location = new Point(13, 122);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(132, 48);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "View details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 3;
            label1.Text = "View Animal Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 89);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 4;
            label2.Text = "Species:";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(12, 330);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // tbxSearch
            // 
            tbxSearch.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSearch.Location = new Point(60, 339);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(259, 27);
            tbxSearch.TabIndex = 12;
            tbxSearch.TextChanged += tbxSearch_TextChanged_1;
            // 
            // ViewAnimalDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 378);
            Controls.Add(pictureBox3);
            Controls.Add(tbxSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnViewDetails);
            Controls.Add(listAnimals);
            Controls.Add(comboSpecies);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAnimalDetails";
            Text = "ViewAnimalDetails";
            Load += ViewAnimalDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboSpecies;
        private ListBox listAnimals;
        private Button btnViewDetails;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox tbxSearch;
    }
}