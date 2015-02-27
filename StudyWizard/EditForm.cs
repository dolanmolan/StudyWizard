using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyWizard
{
    public partial class EditForm : Form
    {
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();
        int selectedPlaylist;
        bool newPlaylist;
        bool textFileSelected;

        public EditForm(MainForm mainForm, PandQ pandQ, bool textFileSelected)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.pandQ = pandQ;
            this.textFileSelected = textFileSelected;
            newPlaylist = true;
        }

        public EditForm(MainForm mainForm, PandQ pandQ, int selectedPlaylist, bool textFileSelected)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.pandQ = pandQ;
            this.selectedPlaylist = selectedPlaylist;
            this.textFileSelected = textFileSelected;
            txtBox_playlistName.Text = pandQ.playlistNames[selectedPlaylist];
            txtBox_subject.Text = pandQ.playlistSubjects[selectedPlaylist];
            txtBox_Sections.Text = pandQ.playlistSections[selectedPlaylist];
            newPlaylist = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SelectEditForm selectEditForm = new SelectEditForm(mainForm, pandQ, textFileSelected);
                selectEditForm.Show();
                this.Close();
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
                MessageBox.Show("Please make sure you are entering in the sections correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newPlaylist)
            {
                pandQ.saveNewPlaylist(txtBox_playlistName.Text, txtBox_subject.Text, txtBox_Sections.Text);
            }
            else
            {
                if (!textFileSelected)
                {
                    Stream stream;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true; if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if ((stream = saveFileDialog.OpenFile()) != null)
                        {
                            pandQ.file = saveFileDialog.FileName;
                            textFileSelected = true;
                            stream.Close();
                        }
                    }
                }
                pandQ.savePlaylist(selectedPlaylist, txtBox_playlistName.Text, txtBox_subject.Text, txtBox_Sections.Text);
            }
            SelectEditForm selectEditForm = new SelectEditForm(mainForm, pandQ, textFileSelected);
            selectEditForm.Show();
            this.Close();
        }
    }
}
