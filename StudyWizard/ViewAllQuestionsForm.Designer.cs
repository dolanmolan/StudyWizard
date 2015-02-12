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
            this.txtBox_Questions = new System.Windows.Forms.TextBox();
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
            // txtBox_Questions
            // 
            this.txtBox_Questions.BackColor = System.Drawing.Color.White;
            this.txtBox_Questions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Questions.Location = new System.Drawing.Point(12, 12);
            this.txtBox_Questions.Multiline = true;
            this.txtBox_Questions.Name = "txtBox_Questions";
            this.txtBox_Questions.ReadOnly = true;
            this.txtBox_Questions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_Questions.Size = new System.Drawing.Size(260, 208);
            this.txtBox_Questions.TabIndex = 1;
            // 
            // ViewAllQuestionsForm
            // 
            this.AcceptButton = this.btn_back;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.txtBox_Questions);
            this.Controls.Add(this.btn_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuestionsForm";
            this.ShowIcon = false;
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtBox_Questions;
    }
}