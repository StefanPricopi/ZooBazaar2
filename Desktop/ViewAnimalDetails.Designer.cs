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
            listAnimals = new ListBox();
            btnViewDetails = new Button();
            label1 = new Label();
            tbxSearch = new TextBox();
            label6 = new Label();
            comboOrdo = new ComboBox();
            label5 = new Label();
            comboClassis = new ComboBox();
            label4 = new Label();
            comboPhylum = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listAnimals
            // 
            listAnimals.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listAnimals.FormattingEnabled = true;
            listAnimals.ItemHeight = 17;
            listAnimals.Location = new Point(12, 293);
            listAnimals.Margin = new Padding(3, 4, 3, 4);
            listAnimals.Name = "listAnimals";
            listAnimals.Size = new Size(223, 123);
            listAnimals.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewDetails.Location = new Point(12, 237);
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
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(260, 31);
            label1.TabIndex = 3;
            label1.Text = "View Animal Details";
            // 
            // tbxSearch
            // 
            tbxSearch.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSearch.Location = new Point(84, 203);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(151, 27);
            tbxSearch.TabIndex = 12;
            tbxSearch.TextChanged += tbxSearch_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 156);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 19;
            label6.Text = "Ordo:";
            // 
            // comboOrdo
            // 
            comboOrdo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOrdo.FormattingEnabled = true;
            comboOrdo.Location = new Point(84, 151);
            comboOrdo.Name = "comboOrdo";
            comboOrdo.Size = new Size(151, 28);
            comboOrdo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 17;
            label5.Text = "Classis:";
            // 
            // comboClassis
            // 
            comboClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassis.FormattingEnabled = true;
            comboClassis.Location = new Point(84, 110);
            comboClassis.Name = "comboClassis";
            comboClassis.Size = new Size(151, 28);
            comboClassis.TabIndex = 16;
            comboClassis.SelectedIndexChanged += comboClassis_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 15;
            label4.Text = "Phylum:";
            // 
            // comboPhylum
            // 
            comboPhylum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPhylum.FormattingEnabled = true;
            comboPhylum.Location = new Point(84, 69);
            comboPhylum.Name = "comboPhylum";
            comboPhylum.Size = new Size(151, 28);
            comboPhylum.TabIndex = 14;
            comboPhylum.SelectedIndexChanged += comboPhylum_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 206);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 20;
            label2.Text = "Search";
            // 
            // ViewAnimalDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 449);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(comboOrdo);
            Controls.Add(label5);
            Controls.Add(comboClassis);
            Controls.Add(label4);
            Controls.Add(comboPhylum);
            Controls.Add(tbxSearch);
            Controls.Add(label1);
            Controls.Add(btnViewDetails);
            Controls.Add(listAnimals);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAnimalDetails";
            Text = "ViewAnimalDetails";
            Load += ViewAnimalDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listAnimals;
        private Button btnViewDetails;
        private Label label1;
        private TextBox tbxSearch;
        private Label label6;
        private ComboBox comboOrdo;
        private Label label5;
        private ComboBox comboClassis;
        private Label label4;
        private ComboBox comboPhylum;
        private Label label2;
    }
}