namespace Desktop
{
    partial class EmployeeSchedulingForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            lbSunday = new Label();
            lbMonday = new Label();
            lbTuesday = new Label();
            lbWednesday = new Label();
            tbThursday = new Label();
            lbFriday = new Label();
            lbSaturday = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbWeekNum = new Label();
            pictureBox3 = new PictureBox();
            Morning = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-8, 732);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1524, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-8, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1524, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(1224, 745);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(276, 43);
            btnNext.TabIndex = 23;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(914, 745);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(276, 43);
            btnPrevious.TabIndex = 24;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbSunday
            // 
            lbSunday.AutoSize = true;
            lbSunday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSunday.Location = new Point(109, 60);
            lbSunday.Name = "lbSunday";
            lbSunday.Size = new Size(80, 22);
            lbSunday.TabIndex = 25;
            lbSunday.Text = "Sunday";
            // 
            // lbMonday
            // 
            lbMonday.AutoSize = true;
            lbMonday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMonday.Location = new Point(214, 60);
            lbMonday.Name = "lbMonday";
            lbMonday.Size = new Size(88, 22);
            lbMonday.TabIndex = 26;
            lbMonday.Text = "Monday";
            // 
            // lbTuesday
            // 
            lbTuesday.AutoSize = true;
            lbTuesday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTuesday.Location = new Point(320, 60);
            lbTuesday.Name = "lbTuesday";
            lbTuesday.Size = new Size(86, 22);
            lbTuesday.TabIndex = 27;
            lbTuesday.Text = "Tuesday";
            // 
            // lbWednesday
            // 
            lbWednesday.AutoSize = true;
            lbWednesday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbWednesday.Location = new Point(426, 60);
            lbWednesday.Name = "lbWednesday";
            lbWednesday.Size = new Size(120, 22);
            lbWednesday.TabIndex = 28;
            lbWednesday.Text = "Wednesday";
            // 
            // tbThursday
            // 
            tbThursday.AutoSize = true;
            tbThursday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbThursday.Location = new Point(581, 60);
            tbThursday.Name = "tbThursday";
            tbThursday.Size = new Size(92, 22);
            tbThursday.TabIndex = 29;
            tbThursday.Text = "Thursday";
            // 
            // lbFriday
            // 
            lbFriday.AutoSize = true;
            lbFriday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbFriday.Location = new Point(702, 60);
            lbFriday.Name = "lbFriday";
            lbFriday.Size = new Size(65, 22);
            lbFriday.TabIndex = 30;
            lbFriday.Text = "Friday";
            // 
            // lbSaturday
            // 
            lbSaturday.AutoSize = true;
            lbSaturday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSaturday.Location = new Point(791, 60);
            lbSaturday.Name = "lbSaturday";
            lbSaturday.Size = new Size(94, 22);
            lbSaturday.TabIndex = 31;
            lbSaturday.Text = "Saturday";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(125, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1404, 567);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // lbWeekNum
            // 
            lbWeekNum.AutoSize = true;
            lbWeekNum.BackColor = Color.Transparent;
            lbWeekNum.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbWeekNum.Location = new Point(303, 9);
            lbWeekNum.Name = "lbWeekNum";
            lbWeekNum.Size = new Size(226, 23);
            lbWeekNum.TabIndex = 33;
            lbWeekNum.Text = "Display Week num here";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_14;
            pictureBox3.Location = new Point(-8, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 747);
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // Morning
            // 
            Morning.AutoSize = true;
            Morning.BackColor = Color.DarkViolet;
            Morning.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Morning.ForeColor = Color.FromArgb(128, 255, 255);
            Morning.Location = new Point(12, 106);
            Morning.Name = "Morning";
            Morning.Size = new Size(85, 23);
            Morning.TabIndex = 35;
            Morning.Text = "Morning";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkViolet;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(2, 295);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 35;
            label1.Text = "Afternoon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkViolet;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(12, 499);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 35;
            label2.Text = "Evening";
            // 
            // EmployeeSchedulingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 811);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Morning);
            Controls.Add(pictureBox3);
            Controls.Add(lbWeekNum);
            Controls.Add(lbSunday);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbSaturday);
            Controls.Add(lbFriday);
            Controls.Add(tbThursday);
            Controls.Add(lbWednesday);
            Controls.Add(lbTuesday);
            Controls.Add(lbMonday);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeSchedulingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeScheduling";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnNext;
        private Button btnPrevious;
        private Label lbSunday;
        private Label lbMonday;
        private Label lbTuesday;
        private Label lbWednesday;
        private Label tbThursday;
        private Label lbFriday;
        private Label lbSaturday;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbWeekNum;
        private PictureBox pictureBox3;
        private Label Morning;
        private Label label1;
        private Label label2;
    }
}