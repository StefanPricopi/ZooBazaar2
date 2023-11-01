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
            label1 = new Label();
            comboPhylum = new ComboBox();
            tbxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboClassis = new ComboBox();
            label6 = new Label();
            comboOrdo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 0;
            label1.Text = "Add Animal";
            // 
            // comboPhylum
            // 
            comboPhylum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPhylum.FormattingEnabled = true;
            comboPhylum.Location = new Point(118, 156);
            comboPhylum.Name = "comboPhylum";
            comboPhylum.Size = new Size(151, 28);
            comboPhylum.TabIndex = 1;
            comboPhylum.SelectedIndexChanged += comboPhylum_SelectedIndexChanged;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(118, 74);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(192, 27);
            tbxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 119);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 161);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 6;
            label4.Text = "Phylum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 202);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 8;
            label5.Text = "Classis:";
            // 
            // comboClassis
            // 
            comboClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassis.FormattingEnabled = true;
            comboClassis.Location = new Point(118, 197);
            comboClassis.Name = "comboClassis";
            comboClassis.Size = new Size(151, 28);
            comboClassis.TabIndex = 7;
            comboClassis.SelectedIndexChanged += comboClassis_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 243);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 10;
            label6.Text = "Ordo:";
            // 
            // comboOrdo
            // 
            comboOrdo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOrdo.FormattingEnabled = true;
            comboOrdo.Location = new Point(118, 238);
            comboOrdo.Name = "comboOrdo";
            comboOrdo.Size = new Size(151, 28);
            comboOrdo.TabIndex = 9;
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 476);
            Controls.Add(label6);
            Controls.Add(comboOrdo);
            Controls.Add(label5);
            Controls.Add(comboClassis);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(comboPhylum);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAnimal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboPhylum;
        private TextBox tbxName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private ComboBox comboClassis;
        private Label label6;
        private ComboBox comboOrdo;
    }
}

