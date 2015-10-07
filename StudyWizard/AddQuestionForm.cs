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
        bool newQuestion;
        int selectedQuestion;

        public AddQuestionForm(MainForm mainForm, PandQ pandQ)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.pandQ = pandQ;
            newQuestion = true;
        }

        public AddQuestionForm(MainForm mainForm, PandQ pandQ, int selectedQuestion)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.pandQ = pandQ;
            newQuestion = false;
            this.selectedQuestion = selectedQuestion;
            txtBox_question.Text = pandQ.questions[selectedQuestion].question;
            txtBox_Answer1.Text = pandQ.questions[selectedQuestion].answers[0];
            txtBox_Answer2.Text = pandQ.questions[selectedQuestion].answers[1];
            txtBox_Answer3.Text = pandQ.questions[selectedQuestion].answers[2];
            txtBox_Answer4.Text = pandQ.questions[selectedQuestion].answers[3];
            txtBox_Explanation.Text = pandQ.questions[selectedQuestion].explanation;
            txtBox_Subject.Text = pandQ.questions[selectedQuestion].subject;
            txtBox_Sections.Text = pandQ.questions[selectedQuestion].section;
            switch (pandQ.questions[selectedQuestion].correctAnswer)
            {
                case 0:
                    rdoBtn_1.Checked = true;
                    break;
                case 1:
                    rdoBtn_2.Checked = true;
                    break;
                case 2:
                    rdoBtn_3.Checked = true;
                    break;
                case 3:
                    rdoBtn_4.Checked = true;
                    break;
                default: break;
            }
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

                pandQ.saveNewQuestion(txtBox_question.Text, txtBox_Subject.Text, txtBox_Sections.Text, txtBox_Answer1.Text, txtBox_Answer2.Text, txtBox_Answer3.Text, txtBox_Answer4.Text, correctAnswer, txtBox_Explanation.Text);

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
