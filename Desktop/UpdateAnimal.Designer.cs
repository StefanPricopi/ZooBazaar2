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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboSpecies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxSpecies = new System.Windows.Forms.TextBox();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Garamond", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(15, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboSpecies
            // 
            this.comboSpecies.FormattingEnabled = true;
            this.comboSpecies.Location = new System.Drawing.Point(73, 21);
            this.comboSpecies.Name = "comboSpecies";
            this.comboSpecies.Size = new System.Drawing.Size(121, 24);
            this.comboSpecies.TabIndex = 3;
            this.comboSpecies.SelectedIndexChanged += new System.EventHandler(this.comboSpecies_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 10F);
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 10F);
            this.label5.Location = new System.Drawing.Point(13, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 10F);
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Species:";
            // 
            // tbxLocation
            // 
            this.tbxLocation.Location = new System.Drawing.Point(89, 232);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(182, 22);
            this.tbxLocation.TabIndex = 11;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(89, 189);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(44, 22);
            this.tbxAge.TabIndex = 10;
            // 
            // tbxSpecies
            // 
            this.tbxSpecies.Location = new System.Drawing.Point(89, 148);
            this.tbxSpecies.Name = "tbxSpecies";
            this.tbxSpecies.Size = new System.Drawing.Size(182, 22);
            this.tbxSpecies.TabIndex = 9;
            // 
            // comboAnimal
            // 
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(73, 51);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(121, 24);
            this.comboAnimal.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15F);
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Update Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 10F);
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Species:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 10F);
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name:";
            // 
            // UpdateAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxLocation);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxSpecies);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboSpecies);
            this.Name = "UpdateAnimal";
            this.Text = "UpdateAnimal";
            this.Load += new System.EventHandler(this.UpdateAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboSpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxSpecies;
        private System.Windows.Forms.ComboBox comboAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}