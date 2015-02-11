namespace StudyWizard
{
    partial class AddQuestionForm
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
            this.lbl_question = new System.Windows.Forms.Label();
            this.txtBox_question = new System.Windows.Forms.TextBox();
            this.lbl_answer1 = new System.Windows.Forms.Label();
            this.txtBox_Answer1 = new System.Windows.Forms.TextBox();
            this.lbl_answer2 = new System.Windows.Forms.Label();
            this.txtBox_answer2 = new System.Windows.Forms.TextBox();
            this.lbl_answer3 = new System.Windows.Forms.Label();
            this.txtBox_answer3 = new System.Windows.Forms.TextBox();
            this.lbl_answer4 = new System.Windows.Forms.Label();
            this.txtBox_answer4 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.Location = new System.Drawing.Point(12, 9);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(116, 29);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question:";
            // 
            // txtBox_question
            // 
            this.txtBox_question.Location = new System.Drawing.Point(12, 41);
            this.txtBox_question.Multiline = true;
            this.txtBox_question.Name = "txtBox_question";
            this.txtBox_question.Size = new System.Drawing.Size(338, 73);
            this.txtBox_question.TabIndex = 1;
            // 
            // lbl_answer1
            // 
            this.lbl_answer1.AutoSize = true;
            this.lbl_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer1.Location = new System.Drawing.Point(13, 117);
            this.lbl_answer1.Name = "lbl_answer1";
            this.lbl_answer1.Size = new System.Drawing.Size(79, 20);
            this.lbl_answer1.TabIndex = 2;
            this.lbl_answer1.Text = "Answer 1:";
            // 
            // txtBox_Answer1
            // 
            this.txtBox_Answer1.Location = new System.Drawing.Point(12, 140);
            this.txtBox_Answer1.Multiline = true;
            this.txtBox_Answer1.Name = "txtBox_Answer1";
            this.txtBox_Answer1.Size = new System.Drawing.Size(338, 40);
            this.txtBox_Answer1.TabIndex = 3;
            // 
            // lbl_answer2
            // 
            this.lbl_answer2.AutoSize = true;
            this.lbl_answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer2.Location = new System.Drawing.Point(13, 183);
            this.lbl_answer2.Name = "lbl_answer2";
            this.lbl_answer2.Size = new System.Drawing.Size(79, 20);
            this.lbl_answer2.TabIndex = 4;
            this.lbl_answer2.Text = "Answer 2:";
            // 
            // txtBox_answer2
            // 
            this.txtBox_answer2.Location = new System.Drawing.Point(12, 206);
            this.txtBox_answer2.Multiline = true;
            this.txtBox_answer2.Name = "txtBox_answer2";
            this.txtBox_answer2.Size = new System.Drawing.Size(338, 40);
            this.txtBox_answer2.TabIndex = 5;
            // 
            // lbl_answer3
            // 
            this.lbl_answer3.AutoSize = true;
            this.lbl_answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer3.Location = new System.Drawing.Point(13, 249);
            this.lbl_answer3.Name = "lbl_answer3";
            this.lbl_answer3.Size = new System.Drawing.Size(79, 20);
            this.lbl_answer3.TabIndex = 6;
            this.lbl_answer3.Text = "Answer 3:";
            // 
            // txtBox_answer3
            // 
            this.txtBox_answer3.Location = new System.Drawing.Point(12, 272);
            this.txtBox_answer3.Multiline = true;
            this.txtBox_answer3.Name = "txtBox_answer3";
            this.txtBox_answer3.Size = new System.Drawing.Size(338, 40);
            this.txtBox_answer3.TabIndex = 7;
            // 
            // lbl_answer4
            // 
            this.lbl_answer4.AutoSize = true;
            this.lbl_answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer4.Location = new System.Drawing.Point(13, 315);
            this.lbl_answer4.Name = "lbl_answer4";
            this.lbl_answer4.Size = new System.Drawing.Size(79, 20);
            this.lbl_answer4.TabIndex = 8;
            this.lbl_answer4.Text = "Answer 4:";
            // 
            // txtBox_answer4
            // 
            this.txtBox_answer4.Location = new System.Drawing.Point(12, 338);
            this.txtBox_answer4.Multiline = true;
            this.txtBox_answer4.Name = "txtBox_answer4";
            this.txtBox_answer4.Size = new System.Drawing.Size(338, 40);
            this.txtBox_answer4.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(275, 401);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(12, 401);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 11;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_answer4);
            this.Controls.Add(this.lbl_answer4);
            this.Controls.Add(this.txtBox_answer3);
            this.Controls.Add(this.lbl_answer3);
            this.Controls.Add(this.txtBox_answer2);
            this.Controls.Add(this.lbl_answer2);
            this.Controls.Add(this.txtBox_Answer1);
            this.Controls.Add(this.lbl_answer1);
            this.Controls.Add(this.txtBox_question);
            this.Controls.Add(this.lbl_question);
            this.Name = "AddQuestionForm";
            this.Text = "Add A Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox txtBox_question;
        private System.Windows.Forms.Label lbl_answer1;
        private System.Windows.Forms.TextBox txtBox_Answer1;
        private System.Windows.Forms.Label lbl_answer2;
        private System.Windows.Forms.TextBox txtBox_answer2;
        private System.Windows.Forms.Label lbl_answer3;
        private System.Windows.Forms.TextBox txtBox_answer3;
        private System.Windows.Forms.Label lbl_answer4;
        private System.Windows.Forms.TextBox txtBox_answer4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_done;
    }
}