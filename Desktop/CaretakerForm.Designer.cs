namespace Desktop
{
    partial class CaretakerForm
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
            btnAdd = new Button();
            btnView = new Button();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pnlFormContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(312, 224);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(207, 162, 253);
            btnView.Dock = DockStyle.Top;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(0, 448);
            btnView.Name = "btnView";
            btnView.Size = new Size(312, 224);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(312, 224);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JungleCode;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 360);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(365, 222);
            label2.Name = "label2";
            label2.Size = new Size(601, 74);
            label2.TabIndex = 5;
            label2.Text = "Manager Overview";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 96);
            label1.Name = "label1";
            label1.Size = new Size(536, 93);
            label1.TabIndex = 4;
            label1.Text = "Jungle Code";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 162, 253);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 673);
            panel2.TabIndex = 5;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(312, 360);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(1590, 673);
            pnlFormContainer.TabIndex = 6;
            // 
            // CaretakerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlFormContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaretakerForm";
            Text = "CaretakerForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnView;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel pnlFormContainer;
    }
}