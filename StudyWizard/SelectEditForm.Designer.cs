namespace StudyWizard
{
    partial class SelectEditForm
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
            this.lsbx_EditListBox = new System.Windows.Forms.ListBox();
            this.btn_newPlaylist = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_addQuestion = new System.Windows.Forms.Button();
            this.btn_viewAll = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbx_EditListBox
            // 
            this.lsbx_EditListBox.AllowDrop = true;
            this.lsbx_EditListBox.FormattingEnabled = true;
            this.lsbx_EditListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsbx_EditListBox.Location = new System.Drawing.Point(12, 11);
            this.lsbx_EditListBox.Name = "lsbx_EditListBox";
            this.lsbx_EditListBox.Size = new System.Drawing.Size(129, 238);
            this.lsbx_EditListBox.TabIndex = 0;
            // 
            // btn_newPlaylist
            // 
            this.btn_newPlaylist.Location = new System.Drawing.Point(173, 41);
            this.btn_newPlaylist.Name = "btn_newPlaylist";
            this.btn_newPlaylist.Size = new System.Drawing.Size(99, 23);
            this.btn_newPlaylist.TabIndex = 1;
            this.btn_newPlaylist.Text = "New Playlist";
            this.btn_newPlaylist.UseVisualStyleBackColor = true;
            this.btn_newPlaylist.Click += new System.EventHandler(this.btn_newPlaylist_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(173, 227);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(99, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_addQuestion
            // 
            this.btn_addQuestion.Location = new System.Drawing.Point(173, 70);
            this.btn_addQuestion.Name = "btn_addQuestion";
            this.btn_addQuestion.Size = new System.Drawing.Size(99, 23);
            this.btn_addQuestion.TabIndex = 2;
            this.btn_addQuestion.Text = "Add Questions";
            this.btn_addQuestion.UseVisualStyleBackColor = true;
            this.btn_addQuestion.Click += new System.EventHandler(this.btn_addQuestion_Click);
            // 
            // btn_viewAll
            // 
            this.btn_viewAll.Location = new System.Drawing.Point(173, 99);
            this.btn_viewAll.Name = "btn_viewAll";
            this.btn_viewAll.Size = new System.Drawing.Size(99, 23);
            this.btn_viewAll.TabIndex = 3;
            this.btn_viewAll.Text = "View all questions";
            this.btn_viewAll.UseVisualStyleBackColor = true;
            this.btn_viewAll.Click += new System.EventHandler(this.btn_viewAll_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(173, 198);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(173, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SelectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_viewAll);
            this.Controls.Add(this.btn_addQuestion);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_newPlaylist);
            this.Controls.Add(this.lsbx_EditListBox);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SelectEditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newPlaylist;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_addQuestion;
        private System.Windows.Forms.Button btn_viewAll;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.ListBox lsbx_EditListBox;

    }
}