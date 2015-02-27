namespace StudyWizard
{
    partial class ViewAllQuestionsForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.chdlsbx_questions = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(12, 226);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(278, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(278, 41);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(99, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // chdlsbx_questions
            // 
            this.chdlsbx_questions.CheckOnClick = true;
            this.chdlsbx_questions.FormattingEnabled = true;
            this.chdlsbx_questions.Location = new System.Drawing.Point(12, 12);
            this.chdlsbx_questions.Name = "chdlsbx_questions";
            this.chdlsbx_questions.ScrollAlwaysVisible = true;
            this.chdlsbx_questions.Size = new System.Drawing.Size(260, 199);
            this.chdlsbx_questions.TabIndex = 4;
            // 
            // ViewAllQuestionsForm
            // 
            this.AcceptButton = this.btn_back;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.ControlBox = false;
            this.Controls.Add(this.chdlsbx_questions);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuestionsForm";
            this.ShowIcon = false;
            this.Text = "Questions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.CheckedListBox chdlsbx_questions;
    }
}