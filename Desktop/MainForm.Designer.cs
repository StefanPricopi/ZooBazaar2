namespace Desktop
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
            pnlForm = new Panel();
            pnlNav = new Panel();
            pnlContents = new Panel();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.Controls.Add(pnlNav);
            pnlForm.Controls.Add(pnlContents);
            pnlForm.Location = new Point(0, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1921, 1061);
            pnlForm.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(405, 1061);
            pnlNav.TabIndex = 1;
            // 
            // pnlContents
            // 
            pnlContents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContents.Location = new Point(500, 280);
            pnlContents.Name = "pnlContents";
            pnlContents.Size = new Size(1355, 751);
            pnlContents.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(pnlForm);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlForm;
        private Panel pnlContents;
        private Panel pnlNav;
    }
}