namespace StudyWizard
{
    partial class EditForm
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
            this.lbl_playlistName = new System.Windows.Forms.Label();
            this.txtBox_playlistName = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_chapters = new System.Windows.Forms.Label();
            this.txtBox_Sections = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtBox_subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_playlistName
            // 
            this.lbl_playlistName.AutoSize = true;
            this.lbl_playlistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlistName.Location = new System.Drawing.Point(12, 9);
            this.lbl_playlistName.Name = "lbl_playlistName";
            this.lbl_playlistName.Size = new System.Drawing.Size(107, 20);
            this.lbl_playlistName.TabIndex = 0;
            this.lbl_playlistName.Text = "Playlist Name:";
            // 
            // txtBox_playlistName
            // 
            this.txtBox_playlistName.Location = new System.Drawing.Point(125, 9);
            this.txtBox_playlistName.Name = "txtBox_playlistName";
            this.txtBox_playlistName.Size = new System.Drawing.Size(249, 20);
            this.txtBox_playlistName.TabIndex = 0;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(12, 36);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(67, 20);
            this.lbl_Subject.TabIndex = 3;
            this.lbl_Subject.Text = "Subject:";
            // 
            // lbl_chapters
            // 
            this.lbl_chapters.AutoSize = true;
            this.lbl_chapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chapters.Location = new System.Drawing.Point(12, 62);
            this.lbl_chapters.Name = "lbl_chapters";
            this.lbl_chapters.Size = new System.Drawing.Size(75, 20);
            this.lbl_chapters.TabIndex = 4;
            this.lbl_chapters.Text = "Sections:";
            // 
            // txtBox_Sections
            // 
            this.txtBox_Sections.Location = new System.Drawing.Point(93, 62);
            this.txtBox_Sections.Name = "txtBox_Sections";
            this.txtBox_Sections.Size = new System.Drawing.Size(281, 20);
            this.txtBox_Sections.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(299, 103);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(218, 103);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtBox_subject
            // 
            this.txtBox_subject.Location = new System.Drawing.Point(85, 36);
            this.txtBox_subject.Name = "txtBox_subject";
            this.txtBox_subject.Size = new System.Drawing.Size(289, 20);
            this.txtBox_subject.TabIndex = 1;
            // 
            // EditForm
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(386, 138);
            this.ControlBox = false;
            this.Controls.Add(this.txtBox_subject);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_Sections);
            this.Controls.Add(this.lbl_chapters);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txtBox_playlistName);
            this.Controls.Add(this.lbl_playlistName);
            this.MaximumSize = new System.Drawing.Size(402, 177);
            this.MinimumSize = new System.Drawing.Size(402, 177);
            this.Name = "EditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playlistName;
        private System.Windows.Forms.TextBox txtBox_playlistName;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_chapters;
        private System.Windows.Forms.TextBox txtBox_Sections;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtBox_subject;
    }
}