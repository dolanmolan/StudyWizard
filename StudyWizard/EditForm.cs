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
        DialogResult dialogResult = new DialogResult();
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();
        int selectedPlaylist;
        bool newPlaylist;

        public EditForm(MainForm myMainForm, PandQ myPandQ)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPandQ;
            newPlaylist = true;
        }
        public EditForm(MainForm myMainForm, PandQ myPandQ, int mySelectedPlaylist)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPandQ;
            selectedPlaylist = mySelectedPlaylist;
            txtBox_playlistName.Text = pandQ.playlistNames[selectedPlaylist];
            txtBox_subject.Text = pandQ.playlistSubjects[selectedPlaylist];
            txtBox_Sections.Text = pandQ.playlistSections[selectedPlaylist];
            newPlaylist = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                SelectEditForm selectEditForm = new SelectEditForm(mainForm, pandQ);
                selectEditForm.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<string> tempSections = new List<string>();
            try
            {
                tempSections = pandQ.splitString(txtBox_Sections.Text);
            }
            catch
            {
                dialogResult = MessageBox.Show("Please make sure you are entering in the sections correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newPlaylist)
            {
                pandQ.saveNewPlaylist(txtBox_playlistName.Text, txtBox_subject.Text, txtBox_Sections.Text);
            }
            else
            {
                pandQ.savePlaylist(selectedPlaylist, txtBox_playlistName.Text, txtBox_subject.Text, txtBox_Sections.Text);
            }
            SelectEditForm selectEditForm = new SelectEditForm(mainForm, pandQ);
            selectEditForm.Show();
            this.Close();
        }
    }
}
