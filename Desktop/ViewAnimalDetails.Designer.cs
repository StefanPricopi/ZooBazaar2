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
            label1 = new Label();
            dgvAnimals = new DataGridView();
            btnAssign = new Button();
            label2 = new Label();
            comboLocation = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(472, 57);
            label1.TabIndex = 3;
            label1.Text = "View Animal Details";
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(12, 81);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 29;
            dgvAnimals.Size = new Size(1548, 458);
            dgvAnimals.TabIndex = 21;
            dgvAnimals.DoubleClick += dgvAnimals_DoubleClick;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssign.Location = new Point(23, 595);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(234, 58);
            btnAssign.TabIndex = 22;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 557);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 23;
            label2.Text = "Location:";
            // 
            // comboLocation
            // 
            comboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation.FormattingEnabled = true;
            comboLocation.Location = new Point(106, 554);
            comboLocation.Name = "comboLocation";
            comboLocation.Size = new Size(151, 28);
            comboLocation.TabIndex = 24;
            // 
            // ViewAnimalDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1572, 665);
            Controls.Add(comboLocation);
            Controls.Add(label2);
            Controls.Add(btnAssign);
            Controls.Add(dgvAnimals);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAnimalDetails";
            Text = "ViewAnimalDetails";
            Load += ViewAnimalDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvAnimals;
        private Button btnAssign;
        private Label label2;
        private ComboBox comboLocation;
    }
}