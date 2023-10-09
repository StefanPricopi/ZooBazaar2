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
            btnOpenAddAnimalForm = new Button();
            SuspendLayout();
            // 
            // btnOpenAddAnimalForm
            // 
            btnOpenAddAnimalForm.Location = new Point(22, 22);
            btnOpenAddAnimalForm.Name = "btnOpenAddAnimalForm";
            btnOpenAddAnimalForm.Size = new Size(197, 79);
            btnOpenAddAnimalForm.TabIndex = 0;
            btnOpenAddAnimalForm.Text = "Add Animal";
            btnOpenAddAnimalForm.UseVisualStyleBackColor = true;
            btnOpenAddAnimalForm.Click += btnOpenAddAnimalForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(btnOpenAddAnimalForm);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenAddAnimalForm;
    }
}