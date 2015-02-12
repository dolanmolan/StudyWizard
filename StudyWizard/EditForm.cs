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
        PandQ pandQ = new PandQ();
        int selectedPlaylist;
        bool newPlaylist;

        public EditForm(OpeningForm myOpeningForm, PandQ myPandQ)
        {
            InitializeComponent();
            openingform = myOpeningForm;
            pandQ = myPandQ;
            newPlaylist = true;
        }
        public EditForm(OpeningForm myOpeningForm, PandQ myPandQ, int mySelectedPlaylist)
        {
            InitializeComponent();
            openingform = myOpeningForm;
            pandQ = myPandQ;
            selectedPlaylist = mySelectedPlaylist;
            txtBox_playlistName.Text = pandQ.playlistNames[selectedPlaylist];
            txtBox_subject.Text = pandQ.playlistSubjects[selectedPlaylist];
            txtBox_chapters.Text = pandQ.playlistSections[selectedPlaylist];
            newPlaylist = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                SelectEditForm selectEditForm = new SelectEditForm(openingform, pandQ);
                selectEditForm.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (newPlaylist)
            {
                pandQ.savePlaylist(txtBox_playlistName.Text, txtBox_subject.Text, txtBox_chapters.Text);
            }
            else
            {
                pandQ.savePlaylist(selectedPlaylist, txtBox_playlistName.Text, txtBox_subject.Text, txtBox_chapters.Text);
            }
            SelectEditForm selectEditForm = new SelectEditForm(openingform, pandQ);
            selectEditForm.Show();
            this.Close();
        }
    }
}
