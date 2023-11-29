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
            label1 = new Label();
            tbxSpecialDiet = new TextBox();
            label14 = new Label();
            tbxDiet = new TextBox();
            label13 = new Label();
            comboStatus = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            tbxHistory = new TextBox();
            label10 = new Label();
            comboSpecies = new ComboBox();
            label9 = new Label();
            comboGenus = new ComboBox();
            label8 = new Label();
            comboFamilia = new ComboBox();
            label6 = new Label();
            comboOrdo = new ComboBox();
            label5 = new Label();
            comboClassis = new ComboBox();
            label4 = new Label();
            dateBirth = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbxName = new TextBox();
            comboPhylum = new ComboBox();
            label15 = new Label();
            comboUpdateOrdo = new ComboBox();
            label16 = new Label();
            comboUpdateClassis = new ComboBox();
            label17 = new Label();
            comboUpdatePhylum = new ComboBox();
            label18 = new Label();
            comboUpdateSpecies = new ComboBox();
            label19 = new Label();
            comboUpdateGenus = new ComboBox();
            label20 = new Label();
            comboUpdateFamilia = new ComboBox();
            panel1 = new Panel();
            dgvAnimals = new DataGridView();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(17, 604);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(398, 48);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(369, 57);
            label1.TabIndex = 16;
            label1.Text = "Update Animal";
            // 
            // tbxSpecialDiet
            // 
            tbxSpecialDiet.Location = new Point(112, 556);
            tbxSpecialDiet.Name = "tbxSpecialDiet";
            tbxSpecialDiet.Size = new Size(151, 27);
            tbxSpecialDiet.TabIndex = 63;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(19, 561);
            label14.Name = "label14";
            label14.Size = new Size(87, 17);
            label14.TabIndex = 62;
            label14.Text = "Special Diet:";
            // 
            // tbxDiet
            // 
            tbxDiet.Location = new Point(112, 523);
            tbxDiet.Name = "tbxDiet";
            tbxDiet.Size = new Size(151, 27);
            tbxDiet.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(19, 528);
            label13.Name = "label13";
            label13.Size = new Size(37, 17);
            label13.TabIndex = 60;
            label13.Text = "Diet:";
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Healthy", "Sick" });
            comboStatus.Location = new Point(112, 479);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(151, 28);
            comboStatus.TabIndex = 59;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(19, 485);
            label12.Name = "label12";
            label12.Size = new Size(52, 17);
            label12.TabIndex = 58;
            label12.Text = "Status:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(19, 441);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 57;
            label11.Text = "History:";
            // 
            // tbxHistory
            // 
            tbxHistory.Location = new Point(112, 436);
            tbxHistory.Name = "tbxHistory";
            tbxHistory.Size = new Size(151, 27);
            tbxHistory.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 401);
            label10.Name = "label10";
            label10.Size = new Size(62, 17);
            label10.TabIndex = 55;
            label10.Text = "Species:";
            // 
            // comboSpecies
            // 
            comboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSpecies.FormattingEnabled = true;
            comboSpecies.Location = new Point(112, 396);
            comboSpecies.Name = "comboSpecies";
            comboSpecies.Size = new Size(151, 28);
            comboSpecies.TabIndex = 54;
            comboSpecies.SelectedIndexChanged += comboSpecies_SelectedIndexChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 367);
            label9.Name = "label9";
            label9.Size = new Size(54, 17);
            label9.TabIndex = 53;
            label9.Text = "Genus:";
            // 
            // comboGenus
            // 
            comboGenus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGenus.FormattingEnabled = true;
            comboGenus.Location = new Point(112, 362);
            comboGenus.Name = "comboGenus";
            comboGenus.Size = new Size(151, 28);
            comboGenus.TabIndex = 52;
            comboGenus.SelectedIndexChanged += comboGenus_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 333);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 51;
            label8.Text = "Familia:";
            // 
            // comboFamilia
            // 
            comboFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFamilia.FormattingEnabled = true;
            comboFamilia.Location = new Point(112, 328);
            comboFamilia.Name = "comboFamilia";
            comboFamilia.Size = new Size(151, 28);
            comboFamilia.TabIndex = 50;
            comboFamilia.SelectedIndexChanged += comboFamilia_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 294);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 47;
            label6.Text = "Ordo:";
            // 
            // comboOrdo
            // 
            comboOrdo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOrdo.FormattingEnabled = true;
            comboOrdo.Location = new Point(114, 289);
            comboOrdo.Name = "comboOrdo";
            comboOrdo.Size = new Size(151, 28);
            comboOrdo.TabIndex = 46;
            comboOrdo.SelectedIndexChanged += comboOrdo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 253);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 45;
            label5.Text = "Classis:";
            // 
            // comboClassis
            // 
            comboClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassis.FormattingEnabled = true;
            comboClassis.Location = new Point(114, 248);
            comboClassis.Name = "comboClassis";
            comboClassis.Size = new Size(151, 28);
            comboClassis.TabIndex = 44;
            comboClassis.SelectedIndexChanged += comboClassis_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 212);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 43;
            label4.Text = "Phylum:";
            // 
            // dateBirth
            // 
            dateBirth.Location = new Point(114, 163);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(151, 27);
            dateBirth.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 170);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 41;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 130);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 40;
            label2.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(114, 125);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(151, 27);
            tbxName.TabIndex = 39;
            // 
            // comboPhylum
            // 
            comboPhylum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPhylum.FormattingEnabled = true;
            comboPhylum.Location = new Point(114, 207);
            comboPhylum.Name = "comboPhylum";
            comboPhylum.Size = new Size(151, 28);
            comboPhylum.TabIndex = 38;
            comboPhylum.SelectedIndexChanged += comboPhylum_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(507, 127);
            label15.Name = "label15";
            label15.Size = new Size(44, 17);
            label15.TabIndex = 70;
            label15.Text = "Ordo:";
            // 
            // comboUpdateOrdo
            // 
            comboUpdateOrdo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdateOrdo.FormattingEnabled = true;
            comboUpdateOrdo.Location = new Point(600, 123);
            comboUpdateOrdo.Name = "comboUpdateOrdo";
            comboUpdateOrdo.Size = new Size(151, 28);
            comboUpdateOrdo.TabIndex = 69;
            comboUpdateOrdo.SelectedIndexChanged += comboUpdateOrdo_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(507, 94);
            label16.Name = "label16";
            label16.Size = new Size(56, 17);
            label16.TabIndex = 68;
            label16.Text = "Classis:";
            // 
            // comboUpdateClassis
            // 
            comboUpdateClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdateClassis.FormattingEnabled = true;
            comboUpdateClassis.Location = new Point(600, 89);
            comboUpdateClassis.Name = "comboUpdateClassis";
            comboUpdateClassis.Size = new Size(151, 28);
            comboUpdateClassis.TabIndex = 67;
            comboUpdateClassis.SelectedIndexChanged += comboUpdateClassis_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(507, 60);
            label17.Name = "label17";
            label17.Size = new Size(58, 17);
            label17.TabIndex = 66;
            label17.Text = "Phylum:";
            // 
            // comboUpdatePhylum
            // 
            comboUpdatePhylum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdatePhylum.FormattingEnabled = true;
            comboUpdatePhylum.Location = new Point(600, 55);
            comboUpdatePhylum.Name = "comboUpdatePhylum";
            comboUpdatePhylum.Size = new Size(151, 28);
            comboUpdatePhylum.TabIndex = 65;
            comboUpdatePhylum.SelectedIndexChanged += comboUpdatePhylum_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(507, 232);
            label18.Name = "label18";
            label18.Size = new Size(62, 17);
            label18.TabIndex = 76;
            label18.Text = "Species:";
            // 
            // comboUpdateSpecies
            // 
            comboUpdateSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdateSpecies.FormattingEnabled = true;
            comboUpdateSpecies.Location = new Point(600, 227);
            comboUpdateSpecies.Name = "comboUpdateSpecies";
            comboUpdateSpecies.Size = new Size(151, 28);
            comboUpdateSpecies.TabIndex = 75;
            comboUpdateSpecies.SelectedIndexChanged += comboUpdateSpecies_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(507, 198);
            label19.Name = "label19";
            label19.Size = new Size(54, 17);
            label19.TabIndex = 74;
            label19.Text = "Genus:";
            // 
            // comboUpdateGenus
            // 
            comboUpdateGenus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdateGenus.FormattingEnabled = true;
            comboUpdateGenus.Location = new Point(600, 193);
            comboUpdateGenus.Name = "comboUpdateGenus";
            comboUpdateGenus.Size = new Size(151, 28);
            comboUpdateGenus.TabIndex = 73;
            comboUpdateGenus.SelectedIndexChanged += comboUpdateGenus_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(507, 164);
            label20.Name = "label20";
            label20.Size = new Size(56, 17);
            label20.TabIndex = 72;
            label20.Text = "Familia:";
            // 
            // comboUpdateFamilia
            // 
            comboUpdateFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUpdateFamilia.FormattingEnabled = true;
            comboUpdateFamilia.Location = new Point(600, 159);
            comboUpdateFamilia.Name = "comboUpdateFamilia";
            comboUpdateFamilia.Size = new Size(151, 28);
            comboUpdateFamilia.TabIndex = 71;
            comboUpdateFamilia.SelectedIndexChanged += comboUpdateFamilia_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(445, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 700);
            panel1.TabIndex = 77;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(489, 281);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 29;
            dgvAnimals.Size = new Size(1025, 353);
            dgvAnimals.TabIndex = 78;
            dgvAnimals.SelectionChanged += dgvAnimals_SelectionChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(878, 98);
            label21.Name = "label21";
            label21.Size = new Size(442, 57);
            label21.TabIndex = 79;
            label21.Text = "Filter by taxonomy";
            // 
            // UpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1572, 665);
            Controls.Add(label21);
            Controls.Add(dgvAnimals);
            Controls.Add(panel1);
            Controls.Add(label18);
            Controls.Add(comboUpdateSpecies);
            Controls.Add(label19);
            Controls.Add(comboUpdateGenus);
            Controls.Add(label20);
            Controls.Add(comboUpdateFamilia);
            Controls.Add(label15);
            Controls.Add(comboUpdateOrdo);
            Controls.Add(label16);
            Controls.Add(comboUpdateClassis);
            Controls.Add(label17);
            Controls.Add(comboUpdatePhylum);
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
            Controls.Add(btnUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateAnimal";
            Text = "UpdateAnimal";
            Load += UpdateAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label1;
        private TextBox tbxSpecialDiet;
        private Label label14;
        private TextBox tbxDiet;
        private Label label13;
        private ComboBox comboStatus;
        private Label label12;
        private Label label11;
        private TextBox tbxHistory;
        private Label label10;
        private ComboBox comboSpecies;
        private Label label9;
        private ComboBox comboGenus;
        private Label label8;
        private ComboBox comboFamilia;
        private Label label6;
        private ComboBox comboOrdo;
        private Label label5;
        private ComboBox comboClassis;
        private Label label4;
        private DateTimePicker dateBirth;
        private Label label3;
        private Label label2;
        private TextBox tbxName;
        private ComboBox comboPhylum;
        private Label label15;
        private ComboBox comboUpdateOrdo;
        private Label label16;
        private ComboBox comboUpdateClassis;
        private Label label17;
        private ComboBox comboUpdatePhylum;
        private Label label18;
        private ComboBox comboUpdateSpecies;
        private Label label19;
        private ComboBox comboUpdateGenus;
        private Label label20;
        private ComboBox comboUpdateFamilia;
        private Panel panel1;
        private DataGridView dgvAnimals;
        private Label label21;
    }
}