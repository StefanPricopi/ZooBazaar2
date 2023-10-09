namespace Animals
{
    partial class SearchAnimal
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listAnimals = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Garamond", 10F);
            this.btnSearch.Location = new System.Drawing.Point(22, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 43);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15F);
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Animal";
            // 
            // listAnimals
            // 
            this.listAnimals.Font = new System.Drawing.Font("Garamond", 10F);
            this.listAnimals.FormattingEnabled = true;
            this.listAnimals.ItemHeight = 19;
            this.listAnimals.Location = new System.Drawing.Point(22, 163);
            this.listAnimals.Name = "listAnimals";
            this.listAnimals.Size = new System.Drawing.Size(401, 118);
            this.listAnimals.TabIndex = 3;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(81, 74);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(153, 22);
            this.tbxSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // SearchAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.listAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchAnimal";
            this.Text = "SearchAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAnimals;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
    }
}