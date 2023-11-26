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
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 1);
            label1.Name = "label1";
            label1.Size = new Size(480, 58);
            label1.TabIndex = 3;
            label1.Text = "View Animal Details";
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(10, 61);
            dgvAnimals.Margin = new Padding(3, 2, 3, 2);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 29;
            dgvAnimals.Size = new Size(1436, 576);
            dgvAnimals.TabIndex = 21;
            dgvAnimals.DoubleClick += dgvAnimals_DoubleClick;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssign.Location = new Point(12, 691);
            btnAssign.Margin = new Padding(3, 2, 3, 2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(215, 44);
            btnAssign.TabIndex = 22;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 660);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 23;
            label2.Text = "Location:";
            // 
            // comboLocation
            // 
            comboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation.FormattingEnabled = true;
            comboLocation.Location = new Point(94, 660);
            comboLocation.Margin = new Padding(3, 2, 3, 2);
            comboLocation.Name = "comboLocation";
            comboLocation.Size = new Size(133, 23);
            comboLocation.TabIndex = 24;
            // 
            // ViewAnimalDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1496, 736);
            Controls.Add(comboLocation);
            Controls.Add(label2);
            Controls.Add(btnAssign);
            Controls.Add(dgvAnimals);
            Controls.Add(label1);
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