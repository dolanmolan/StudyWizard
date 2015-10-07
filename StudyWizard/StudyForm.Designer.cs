namespace StudyWizard
{
    partial class StudyForm
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
            this.txtBox_question = new System.Windows.Forms.TextBox();
            this.rdoBtn_answer1 = new System.Windows.Forms.RadioButton();
            this.rdoBtn_answer2 = new System.Windows.Forms.RadioButton();
            this.rdoBtn_answer3 = new System.Windows.Forms.RadioButton();
            this.rdoBtn_answer4 = new System.Windows.Forms.RadioButton();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_question
            // 
            this.txtBox_question.BackColor = System.Drawing.Color.White;
            this.txtBox_question.Location = new System.Drawing.Point(12, 12);
            this.txtBox_question.Multiline = true;
            this.txtBox_question.Name = "txtBox_question";
            this.txtBox_question.ReadOnly = true;
            this.txtBox_question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_question.Size = new System.Drawing.Size(600, 61);
            this.txtBox_question.TabIndex = 0;
            // 
            // rdoBtn_answer1
            // 
            this.rdoBtn_answer1.AutoSize = true;
            this.rdoBtn_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_answer1.Location = new System.Drawing.Point(12, 80);
            this.rdoBtn_answer1.Name = "rdoBtn_answer1";
            this.rdoBtn_answer1.Size = new System.Drawing.Size(14, 13);
            this.rdoBtn_answer1.TabIndex = 0;
            this.rdoBtn_answer1.TabStop = true;
            this.rdoBtn_answer1.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_answer2
            // 
            this.rdoBtn_answer2.AutoSize = true;
            this.rdoBtn_answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_answer2.Location = new System.Drawing.Point(12, 125);
            this.rdoBtn_answer2.Name = "rdoBtn_answer2";
            this.rdoBtn_answer2.Size = new System.Drawing.Size(14, 13);
            this.rdoBtn_answer2.TabIndex = 1;
            this.rdoBtn_answer2.TabStop = true;
            this.rdoBtn_answer2.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_answer3
            // 
            this.rdoBtn_answer3.AutoSize = true;
            this.rdoBtn_answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_answer3.Location = new System.Drawing.Point(12, 170);
            this.rdoBtn_answer3.Name = "rdoBtn_answer3";
            this.rdoBtn_answer3.Size = new System.Drawing.Size(14, 13);
            this.rdoBtn_answer3.TabIndex = 2;
            this.rdoBtn_answer3.TabStop = true;
            this.rdoBtn_answer3.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_answer4
            // 
            this.rdoBtn_answer4.AutoSize = true;
            this.rdoBtn_answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_answer4.Location = new System.Drawing.Point(12, 215);
            this.rdoBtn_answer4.Name = "rdoBtn_answer4";
            this.rdoBtn_answer4.Size = new System.Drawing.Size(14, 13);
            this.rdoBtn_answer4.TabIndex = 3;
            this.rdoBtn_answer4.TabStop = true;
            this.rdoBtn_answer4.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(12, 272);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(85, 28);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(527, 272);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(85, 28);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // StudyForm
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(624, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.rdoBtn_answer4);
            this.Controls.Add(this.rdoBtn_answer3);
            this.Controls.Add(this.rdoBtn_answer2);
            this.Controls.Add(this.rdoBtn_answer1);
            this.Controls.Add(this.txtBox_question);
            this.MaximumSize = new System.Drawing.Size(640, 351);
            this.MinimumSize = new System.Drawing.Size(640, 351);
            this.Name = "StudyForm";
            this.Text = "StudyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_question;
        private System.Windows.Forms.RadioButton rdoBtn_answer1;
        private System.Windows.Forms.RadioButton rdoBtn_answer2;
        private System.Windows.Forms.RadioButton rdoBtn_answer3;
        private System.Windows.Forms.RadioButton rdoBtn_answer4;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_submit;

    }
}