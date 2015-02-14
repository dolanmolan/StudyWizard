using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyWizard
{
    public partial class AddQuestionForm : Form
    {
        DialogResult dialogResult = new DialogResult();
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();

        public AddQuestionForm(MainForm myMainForm, PandQ myPandQ)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPandQ;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Are you sure you want to quit? Everything here will be lost.", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                SelectEditForm selectEditForm = new SelectEditForm(mainForm, pandQ);
                selectEditForm.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int correctAnswer = 0;

            if (!(rdoBtn_1.Checked || rdoBtn_2.Checked || rdoBtn_3.Checked || rdoBtn_4.Checked))
            {
                dialogResult = MessageBox.Show("Please make sure to select an answer to be the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdoBtn_1.Checked)
                {
                    correctAnswer = 0;
                }
                else if (rdoBtn_2.Checked)
                {
                    correctAnswer = 1;
                }
                else if (rdoBtn_3.Checked)
                {
                    correctAnswer = 2;
                }
                else
                {
                    correctAnswer = 3;
                }
                pandQ.addQuestion(txtBox_question.Text, txtBox_Subject.Text, txtBox_Sections.Text, txtBox_Answer1.Text, txtBox_Answer2.Text, txtBox_Answer3.Text, txtBox_Answer4.Text, correctAnswer, txtBox_Explanation.Text);
                txtBox_question.Text = "";
                txtBox_Answer1.Text = "";
                txtBox_Answer2.Text = "";
                txtBox_Answer3.Text = "";
                txtBox_Answer4.Text = "";
                txtBox_Explanation.Text = "";
                txtBox_Subject.Text = "";
                txtBox_Sections.Text = "";
                rdoBtn_1.Checked = false;
                rdoBtn_2.Checked = false;
                rdoBtn_3.Checked = false;
                rdoBtn_4.Checked = false;
            }
        }
    }
}
