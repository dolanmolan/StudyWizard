namespace StudyWizard
{
    partial class SelectStudyForm
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
            this.lsbx_StudyListBox = new System.Windows.Forms.ListBox();
            this.btn_study = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbx_StudyListBox
            // 
            this.lsbx_StudyListBox.FormattingEnabled = true;
            this.lsbx_StudyListBox.Location = new System.Drawing.Point(12, 12);
            this.lsbx_StudyListBox.Name = "lsbx_StudyListBox";
            this.lsbx_StudyListBox.Size = new System.Drawing.Size(129, 238);
            this.lsbx_StudyListBox.TabIndex = 0;
            // 
            // btn_study
            // 
            this.btn_study.Location = new System.Drawing.Point(173, 226);
            this.btn_study.Name = "btn_study";
            this.btn_study.Size = new System.Drawing.Size(99, 23);
            this.btn_study.TabIndex = 1;
            this.btn_study.Text = "Study";
            this.btn_study.UseVisualStyleBackColor = true;
            this.btn_study.Click += new System.EventHandler(this.btn_study_Click);
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
            // SelectStudyForm
            // 
            this.AcceptButton = this.btn_study;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_study);
            this.Controls.Add(this.lsbx_StudyListBox);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SelectStudyForm";
            this.Text = "Choose a playlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbx_StudyListBox;
        private System.Windows.Forms.Button btn_study;
        private System.Windows.Forms.Button btn_back;
    }
}