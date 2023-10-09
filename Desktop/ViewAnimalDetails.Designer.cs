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
            this.comboSpecies = new System.Windows.Forms.ComboBox();
            this.listAnimals = new System.Windows.Forms.ListBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSpecies
            // 
            this.comboSpecies.FormattingEnabled = true;
            this.comboSpecies.Location = new System.Drawing.Point(77, 68);
            this.comboSpecies.Name = "comboSpecies";
            this.comboSpecies.Size = new System.Drawing.Size(121, 24);
            this.comboSpecies.TabIndex = 0;
            // 
            // listAnimals
            // 
            this.listAnimals.Font = new System.Drawing.Font("Garamond", 10F);
            this.listAnimals.FormattingEnabled = true;
            this.listAnimals.ItemHeight = 19;
            this.listAnimals.Location = new System.Drawing.Point(13, 142);
            this.listAnimals.Name = "listAnimals";
            this.listAnimals.Size = new System.Drawing.Size(401, 118);
            this.listAnimals.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Garamond", 10F);
            this.btnViewDetails.Location = new System.Drawing.Point(13, 98);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(132, 38);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Animal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 10F);
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Species:";
            // 
            // ViewAnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.listAnimals);
            this.Controls.Add(this.comboSpecies);
            this.Name = "ViewAnimalDetails";
            this.Text = "ViewAnimalDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSpecies;
        private System.Windows.Forms.ListBox listAnimals;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}