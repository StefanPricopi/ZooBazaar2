namespace Desktop
{
    partial class EmployeeSchedulingTest
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_12;
            pictureBox1.Location = new Point(-8, 511);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1669, 54);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_12;
            pictureBox2.Location = new Point(-8, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(885, 62);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(725, 521);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 23;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(644, 521);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 24;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbSunday
            // 
            lbSunday.AutoSize = true;
            lbSunday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSunday.Location = new Point(18, 60);
            lbSunday.Name = "lbSunday";
            lbSunday.Size = new Size(80, 22);
            lbSunday.TabIndex = 25;
            lbSunday.Text = "Sunday";
            // 
            // lbMonday
            // 
            lbMonday.AutoSize = true;
            lbMonday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMonday.Location = new Point(127, 60);
            lbMonday.Name = "lbMonday";
            lbMonday.Size = new Size(88, 22);
            lbMonday.TabIndex = 26;
            lbMonday.Text = "Monday";
            // 
            // lbTuesday
            // 
            lbTuesday.AutoSize = true;
            lbTuesday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTuesday.Location = new Point(236, 60);
            lbTuesday.Name = "lbTuesday";
            lbTuesday.Size = new Size(86, 22);
            lbTuesday.TabIndex = 27;
            lbTuesday.Text = "Tuesday";
            // 
            // lbWednesday
            // 
            lbWednesday.AutoSize = true;
            lbWednesday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbWednesday.Location = new Point(343, 60);
            lbWednesday.Name = "lbWednesday";
            lbWednesday.Size = new Size(120, 22);
            lbWednesday.TabIndex = 28;
            lbWednesday.Text = "Wednesday";
            // 
            // tbThursday
            // 
            tbThursday.AutoSize = true;
            tbThursday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbThursday.Location = new Point(469, 60);
            tbThursday.Name = "tbThursday";
            tbThursday.Size = new Size(92, 22);
            tbThursday.TabIndex = 29;
            tbThursday.Text = "Thursday";
            // 
            // lbFriday
            // 
            lbFriday.AutoSize = true;
            lbFriday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbFriday.Location = new Point(586, 60);
            lbFriday.Name = "lbFriday";
            lbFriday.Size = new Size(65, 22);
            lbFriday.TabIndex = 30;
            lbFriday.Text = "Friday";
            // 
            // lbSaturday
            // 
            lbSaturday.AutoSize = true;
            lbSaturday.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSaturday.Location = new Point(675, 60);
            lbSaturday.Name = "lbSaturday";
            lbSaturday.Size = new Size(94, 22);
            lbSaturday.TabIndex = 31;
            lbSaturday.Text = "Saturday";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(-8, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(808, 401);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // EmployeeSchedulingTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbSaturday);
            Controls.Add(lbFriday);
            Controls.Add(tbThursday);
            Controls.Add(lbWednesday);
            Controls.Add(lbTuesday);
            Controls.Add(lbMonday);
            Controls.Add(lbSunday);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeSchedulingTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeScheduling";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}