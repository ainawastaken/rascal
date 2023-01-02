namespace rascal_controller
{
    partial class fileEditor
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
            this.syntaxEditor1 = new ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.SyntaxEditor();
            this.SuspendLayout();
            // 
            // syntaxEditor1
            // 
            this.syntaxEditor1.AllowDrop = true;
            this.syntaxEditor1.Location = new System.Drawing.Point(386, 93);
            this.syntaxEditor1.Name = "syntaxEditor1";
            this.syntaxEditor1.Size = new System.Drawing.Size(250, 150);
            this.syntaxEditor1.TabIndex = 0;
            this.syntaxEditor1.Text = "syntaxEditor1";
            // 
            // fileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syntaxEditor1);
            this.Name = "fileEditor";
            this.Text = "fileEditor";
            this.Load += new System.EventHandler(this.fileEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.SyntaxEditor syntaxEditor1;
    }
}