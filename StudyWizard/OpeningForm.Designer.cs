namespace StudyWizard
{
    partial class OpeningForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_study = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to StudyWizard!";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 197);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit Playlists";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_study
            // 
            this.btn_study.Location = new System.Drawing.Point(143, 197);
            this.btn_study.Name = "btn_study";
            this.btn_study.Size = new System.Drawing.Size(129, 23);
            this.btn_study.TabIndex = 2;
            this.btn_study.Text = "Study!";
            this.btn_study.UseVisualStyleBackColor = true;
            this.btn_study.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 226);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(260, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 168);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(260, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load File";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_study);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label1);
            this.Name = "OpeningForm";
            this.Text = "StudyWizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_study;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_load;
    }
}

