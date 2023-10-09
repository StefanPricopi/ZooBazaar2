namespace Animals
{
    partial class MainForm
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
            this.btnOpenAddAnimalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenAddAnimalForm
            // 
            this.btnOpenAddAnimalForm.Location = new System.Drawing.Point(25, 23);
            this.btnOpenAddAnimalForm.Name = "btnOpenAddAnimalForm";
            this.btnOpenAddAnimalForm.Size = new System.Drawing.Size(225, 84);
            this.btnOpenAddAnimalForm.TabIndex = 0;
            this.btnOpenAddAnimalForm.Text = "Add Animal";
            this.btnOpenAddAnimalForm.UseVisualStyleBackColor = true;
            this.btnOpenAddAnimalForm.Click += new System.EventHandler(this.btnOpenAddAnimalForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenAddAnimalForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddAnimalForm;
    }
}