﻿namespace Animals
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
            label1 = new Label();
            comboPhylum = new ComboBox();
            tbxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateBirth = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboClassis = new ComboBox();
            label6 = new Label();
            comboOrdo = new ComboBox();
            btnAddAnimal = new Button();
            label7 = new Label();
            tbxSearch = new TextBox();
            label8 = new Label();
            comboFamilia = new ComboBox();
            label9 = new Label();
            comboGenus = new ComboBox();
            label10 = new Label();
            comboSpecies = new ComboBox();
            tbxHistory = new TextBox();
            label11 = new Label();
            label12 = new Label();
            comboStatus = new ComboBox();
            label13 = new Label();
            tbxDiet = new TextBox();
            tbxSpecialDiet = new TextBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 49);
            label1.TabIndex = 0;
            label1.Text = "Add Animal";
            // 
            // comboPhylum
            // 
            comboPhylum.AllowDrop = true;
            comboPhylum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPhylum.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            comboPhylum.FormattingEnabled = true;
            comboPhylum.Location = new Point(364, 208);
            comboPhylum.Name = "comboPhylum";
            comboPhylum.Size = new Size(302, 57);
            comboPhylum.TabIndex = 1;
            comboPhylum.SelectedIndexChanged += comboPhylum_SelectedIndexChanged;
            // 
            // tbxName
            // 
            tbxName.AllowDrop = true;
            tbxName.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.Location = new Point(364, 68);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(302, 57);
            tbxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(155, 49);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 145);
            label3.Name = "label3";
            label3.Size = new Size(273, 49);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // dateBirth
            // 
            dateBirth.AllowDrop = true;
            dateBirth.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirth.Location = new Point(364, 138);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(302, 57);
            dateBirth.TabIndex = 5;
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(174, 49);
            label4.TabIndex = 6;
            label4.Text = "Phylum:";
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(159, 49);
            label5.TabIndex = 8;
            label5.Text = "Classis:";
            // 
            // comboClassis
            // 
            comboClassis.AllowDrop = true;
            comboClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassis.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            comboClassis.FormattingEnabled = true;
            comboClassis.Location = new Point(364, 291);
            comboClassis.Name = "comboClassis";
            comboClassis.Size = new Size(302, 57);
            comboClassis.TabIndex = 7;
            comboClassis.SelectedIndexChanged += comboClassis_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 368);
            label6.Name = "label6";
            label6.Size = new Size(133, 49);
            label6.TabIndex = 10;
            label6.Text = "Ordo:";
            // 
            // comboOrdo
            // 
            comboOrdo.AllowDrop = true;
            comboOrdo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOrdo.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            comboOrdo.FormattingEnabled = true;
            comboOrdo.Location = new Point(364, 365);
            comboOrdo.Name = "comboOrdo";
            comboOrdo.Size = new Size(302, 57);
            comboOrdo.TabIndex = 9;
            comboOrdo.SelectedIndexChanged += comboOrdo_SelectedIndexChanged;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.AllowDrop = true;
            btnAddAnimal.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAnimal.Location = new Point(12, 546);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(1548, 107);
            btnAddAnimal.TabIndex = 11;
            btnAddAnimal.Text = "Add";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 434);
            label7.Name = "label7";
            label7.Size = new Size(157, 49);
            label7.TabIndex = 22;
            label7.Text = "Search";
            // 
            // tbxSearch
            // 
            tbxSearch.AllowDrop = true;
            tbxSearch.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSearch.Location = new Point(364, 434);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(302, 57);
            tbxSearch.TabIndex = 21;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(850, 24);
            label8.Name = "label8";
            label8.Size = new Size(138, 40);
            label8.TabIndex = 24;
            label8.Text = "Familia:";
            // 
            // comboFamilia
            // 
            comboFamilia.AllowDrop = true;
            comboFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFamilia.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboFamilia.FormattingEnabled = true;
            comboFamilia.Location = new Point(1082, 24);
            comboFamilia.Name = "comboFamilia";
            comboFamilia.Size = new Size(407, 48);
            comboFamilia.TabIndex = 23;
            comboFamilia.SelectedIndexChanged += comboFamilia_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(842, 90);
            label9.Name = "label9";
            label9.Size = new Size(133, 40);
            label9.TabIndex = 26;
            label9.Text = "Genus:";
            // 
            // comboGenus
            // 
            comboGenus.AllowDrop = true;
            comboGenus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGenus.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboGenus.FormattingEnabled = true;
            comboGenus.Location = new Point(1082, 90);
            comboGenus.Name = "comboGenus";
            comboGenus.Size = new Size(407, 48);
            comboGenus.TabIndex = 25;
            comboGenus.SelectedIndexChanged += comboGenus_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(850, 159);
            label10.Name = "label10";
            label10.Size = new Size(152, 40);
            label10.TabIndex = 28;
            label10.Text = "Species:";
            // 
            // comboSpecies
            // 
            comboSpecies.AllowDrop = true;
            comboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSpecies.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboSpecies.FormattingEnabled = true;
            comboSpecies.Location = new Point(1082, 156);
            comboSpecies.Name = "comboSpecies";
            comboSpecies.Size = new Size(407, 48);
            comboSpecies.TabIndex = 27;
            comboSpecies.SelectedIndexChanged += comboSpecies_SelectedIndexChanged;
            // 
            // tbxHistory
            // 
            tbxHistory.AllowDrop = true;
            tbxHistory.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbxHistory.Location = new Point(1082, 227);
            tbxHistory.Name = "tbxHistory";
            tbxHistory.Size = new Size(407, 48);
            tbxHistory.TabIndex = 29;
            // 
            // label11
            // 
            label11.AllowDrop = true;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(850, 235);
            label11.Name = "label11";
            label11.Size = new Size(132, 40);
            label11.TabIndex = 30;
            label11.Text = "History:";
            // 
            // label12
            // 
            label12.AllowDrop = true;
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(850, 308);
            label12.Name = "label12";
            label12.Size = new Size(124, 40);
            label12.TabIndex = 32;
            label12.Text = "Status:";
            // 
            // comboStatus
            // 
            comboStatus.AllowDrop = true;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Healthy", "Sick" });
            comboStatus.Location = new Point(1082, 298);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(407, 48);
            comboStatus.TabIndex = 33;
            // 
            // label13
            // 
            label13.AllowDrop = true;
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(850, 382);
            label13.Name = "label13";
            label13.Size = new Size(92, 40);
            label13.TabIndex = 34;
            label13.Text = "Diet:";
            // 
            // tbxDiet
            // 
            tbxDiet.AllowDrop = true;
            tbxDiet.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDiet.Location = new Point(1082, 369);
            tbxDiet.Name = "tbxDiet";
            tbxDiet.Size = new Size(407, 48);
            tbxDiet.TabIndex = 35;
            // 
            // tbxSpecialDiet
            // 
            tbxSpecialDiet.AllowDrop = true;
            tbxSpecialDiet.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSpecialDiet.Location = new Point(1082, 441);
            tbxSpecialDiet.Name = "tbxSpecialDiet";
            tbxSpecialDiet.Size = new Size(407, 48);
            tbxSpecialDiet.TabIndex = 37;
            // 
            // label14
            // 
            label14.AllowDrop = true;
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(850, 444);
            label14.Name = "label14";
            label14.Size = new Size(221, 40);
            label14.TabIndex = 36;
            label14.Text = "Special Diet:";
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1572, 665);
            Controls.Add(tbxSpecialDiet);
            Controls.Add(label14);
            Controls.Add(tbxDiet);
            Controls.Add(label13);
            Controls.Add(comboStatus);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(tbxHistory);
            Controls.Add(label10);
            Controls.Add(comboSpecies);
            Controls.Add(label9);
            Controls.Add(comboGenus);
            Controls.Add(label8);
            Controls.Add(comboFamilia);
            Controls.Add(label7);
            Controls.Add(tbxSearch);
            Controls.Add(btnAddAnimal);
            Controls.Add(label6);
            Controls.Add(comboOrdo);
            Controls.Add(label5);
            Controls.Add(comboClassis);
            Controls.Add(label4);
            Controls.Add(dateBirth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(comboPhylum);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAnimal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboPhylum;
        private TextBox tbxName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateBirth;
        private Label label4;
        private Label label5;
        private ComboBox comboClassis;
        private Label label6;
        private ComboBox comboOrdo;
        private Button btnAddAnimal;
        private Label label7;
        private TextBox tbxSearch;
        private Label label8;
        private ComboBox comboFamilia;
        private Label label9;
        private ComboBox comboGenus;
        private Label label10;
        private ComboBox comboSpecies;
        private TextBox tbxHistory;
        private Label label11;
        private Label label12;
        private ComboBox comboStatus;
        private Label label13;
        private TextBox tbxDiet;
        private TextBox tbxSpecialDiet;
        private Label label14;
    }
}

