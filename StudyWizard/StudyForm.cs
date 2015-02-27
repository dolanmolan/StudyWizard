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
    public partial class StudyForm : Form
    {
        Random random = new Random();
        PandQ pandQ = new PandQ();
        List<Questions> studyingQuestions = new List<Questions>();
        int selectedPlaylist;
        int correctAnswer;
        int randomQuestion;

        public StudyForm(PandQ pandQ, int selectedPlaylist)
        {
            InitializeComponent();
            this.pandQ = pandQ;
            this.selectedPlaylist = selectedPlaylist;
            studyingQuestions = pandQ.findQuestions(selectedPlaylist);
            randomQuestion = random.Next(studyingQuestions.Count);
            correctAnswer = addNewQuestion(randomQuestion);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm(pandQ);
                mainForm.Show();
                this.Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (rdoBtn_answer1.Checked && correctAnswer == 0 || rdoBtn_answer2.Checked && correctAnswer == 1 || rdoBtn_answer3.Checked && correctAnswer == 2 || rdoBtn_answer4.Checked && correctAnswer == 3)
            {
                MessageBox.Show("Correct!\nCorrect Answer: " + studyingQuestions[randomQuestion].answers[studyingQuestions[randomQuestion].correctAnswer] + "\n" + studyingQuestions[randomQuestion].explanation, 
                    "Correct!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Not Quite!\nCorrect Answer: " + studyingQuestions[randomQuestion].answers[studyingQuestions[randomQuestion].correctAnswer] + "\n" + studyingQuestions[randomQuestion].explanation, 
                    "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            randomQuestion = random.Next(studyingQuestions.Count);
            correctAnswer = addNewQuestion(randomQuestion);
        }

        private int addNewQuestion(int randomQuestion)
        {
            rdoBtn_answer1.Checked = false;
            rdoBtn_answer2.Checked = false;
            rdoBtn_answer3.Checked = false;
            rdoBtn_answer4.Checked = false;
            int shuffledCorrectAnswer = 0;
            txtBox_question.Text = studyingQuestions[randomQuestion].question;
            string[] shuffledAnswer = pandQ.RandomizeStrings(studyingQuestions[randomQuestion].answers);
            for (int i = 0; i < 4; i++)
            {
                if (shuffledAnswer[i] == studyingQuestions[randomQuestion].answers[studyingQuestions[randomQuestion].correctAnswer])
                {
                    shuffledCorrectAnswer = i;
                }
            }
            rdoBtn_answer1.Text = shuffledAnswer[0];
            rdoBtn_answer2.Text = shuffledAnswer[1];
            rdoBtn_answer3.Text = shuffledAnswer[2];
            rdoBtn_answer4.Text = shuffledAnswer[3];
            return shuffledCorrectAnswer;
        }
    }
}
