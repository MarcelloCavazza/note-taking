namespace note_taking
{
    partial class InitialScreen
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
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.btnListNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(252, 208);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNote.TabIndex = 0;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // btnListNote
            // 
            this.btnListNote.Location = new System.Drawing.Point(439, 208);
            this.btnListNote.Name = "btnListNote";
            this.btnListNote.Size = new System.Drawing.Size(75, 23);
            this.btnListNote.TabIndex = 1;
            this.btnListNote.Text = "List Notes";
            this.btnListNote.UseVisualStyleBackColor = true;
            this.btnListNote.Click += new System.EventHandler(this.btnListNote_Click);
            // 
            // InitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListNote);
            this.Controls.Add(this.btnCreateNote);
            this.Name = "InitialScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Button btnListNote;
    }
}