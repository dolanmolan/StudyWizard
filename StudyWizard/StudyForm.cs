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
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();
        int selectedPlaylist;
        List<Questions> studyingQuestions = new List<Questions>();

        public StudyForm(MainForm myMainForm, PandQ myPandQ, int mySelectedPlaylist)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPandQ;
            selectedPlaylist = mySelectedPlaylist;
            studyingQuestions = pandQ.findQuestions(selectedPlaylist);
            addNewQuestion();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MainForm openingForm = new MainForm();
                openingForm.Show();
                this.Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            addNewQuestion();
        }

        private void addNewQuestion()
        {
            string[] shuffledAnswer = new string[4];
            int[] shuffledAnswerIndex = new int[4];
            int randomQuestion = random.Next(studyingQuestions.Count);
            txtBox_question.Text = studyingQuestions[randomQuestion].question;
            for (int i = 0; i < 4; i++)
            {
                bool validAnswer = false;
                do
                {
                    int randomAnswer = random.Next(3);
                    if (!shuffledAnswerIndex.Contains(randomAnswer))
                    {
                        shuffledAnswer[i] = studyingQuestions[randomQuestion].answers[randomAnswer];
                        shuffledAnswerIndex[i] = randomAnswer;
                        switch (i)
                        {
                            case 0:
                                rdoBtn_answer1.Text = shuffledAnswer[i];
                                break;
                            case 1:
                                rdoBtn_answer2.Text = shuffledAnswer[i];
                                break;
                            case 2:
                                rdoBtn_answer3.Text = shuffledAnswer[i];
                                break;
                            case 3:
                                rdoBtn_answer4.Text = shuffledAnswer[i];
                                break;
                            default: break;
                        }
                        validAnswer = true;
                    }
                } while (!validAnswer);
            }

        }
    }
}
