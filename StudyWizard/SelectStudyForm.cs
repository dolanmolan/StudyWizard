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
        OpeningForm openingForm = new OpeningForm();
        PandQ playlist = new PandQ();
        Questions questions = new Questions();

        public SelectStudyForm(OpeningForm myOpeningForm, PandQ myPlaylist, Questions myQuestions)
        {
            InitializeComponent();
            openingForm = myOpeningForm;
            playlist = myPlaylist;
            questions = myQuestions;
            lsBx_StudyListBox.DataSource = playlist.playlistNames;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            openingForm.Show();
            this.Close();
        }

        private void btn_study_Click(object sender, EventArgs e)
        {
            StudyForm studyForm = new StudyForm();
            studyForm.Show();
            this.Close();
        }
    }
}
