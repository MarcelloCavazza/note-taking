namespace note_taking
{
    partial class Create
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.rTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 114);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(59, 42);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Title:";
            // 
            // rTxtDescription
            // 
            this.rTxtDescription.Location = new System.Drawing.Point(48, 144);
            this.rTxtDescription.Name = "rTxtDescription";
            this.rTxtDescription.Size = new System.Drawing.Size(318, 117);
            this.rTxtDescription.TabIndex = 4;
            this.rTxtDescription.Text = "";
            this.rTxtDescription.TextChanged += new System.EventHandler(this.rTxtDescription_TextChanged);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(62, 314);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 5;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(269, 314);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 428);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.rTxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtTitle);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.RichTextBox rTxtDescription;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnReturn;
    }
}

