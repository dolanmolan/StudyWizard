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
    public partial class SelectStudyForm : Form
    {
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();
        Questions questions = new Questions();

        public SelectStudyForm(MainForm myMainForm, PandQ myPlaylist, Questions myQuestions)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPlaylist;
            questions = myQuestions;
            lsbx_StudyListBox.DataSource = pandQ.playlistNames;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void btn_study_Click(object sender, EventArgs e)
        {
            StudyForm studyForm = new StudyForm(mainForm, pandQ, lsbx_StudyListBox.SelectedIndex);
            studyForm.Show();
            this.Close();
        }
    }
}
