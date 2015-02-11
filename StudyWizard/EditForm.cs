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
    public partial class EditForm : Form
    {
        OpeningForm openingform = new OpeningForm();
        SelectEditForm selectEditForm = new SelectEditForm();
        PandQ pandQ = new PandQ();
        Questions questions = new Questions();
        int selectedPlaylist;

        public EditForm(OpeningForm myOpeningForm, SelectEditForm mySelectEditForm, PandQ myPandQ, Questions myQuestions, int mySelectedPlaylist)
        {
            InitializeComponent();
            openingform = myOpeningForm;
            selectEditForm = mySelectEditForm;
            pandQ = myPandQ;
            questions = myQuestions;
            selectedPlaylist = mySelectedPlaylist;
            txtBox_playlistName.Text = pandQ.playlistNames[selectedPlaylist];
            txtBox_subject.Text = pandQ.playlistSubjects[selectedPlaylist];
            txtBox_chapters.Text = pandQ.playlistSections[selectedPlaylist];
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                selectEditForm.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            pandQ.savePlaylist(selectedPlaylist, txtBox_playlistName.Text, txtBox_subject.Text, txtBox_chapters.Text);
            selectEditForm.Show();
            this.Close();
        }
    }
}
