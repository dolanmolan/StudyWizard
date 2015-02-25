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
    public partial class SelectEditForm : Form
    {
        MainForm mainForm = new MainForm();
        PandQ pandQ = new PandQ();
        bool textFileSelected;

        public SelectEditForm(MainForm myMainForm, PandQ myPandQ, bool myTextFileSelected)
        {
            InitializeComponent();
            mainForm = myMainForm;
            pandQ = myPandQ;
            lsbx_EditListBox.DataSource = pandQ.playlistNames;
            textFileSelected = myTextFileSelected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(mainForm, pandQ, lsbx_EditListBox.SelectedIndex, textFileSelected);
            editForm.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.textFileSelected = textFileSelected;
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            pandQ.deletePlaylist(lsbx_EditListBox.SelectedIndex);
            lsbx_EditListBox.ClearSelected();
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            ViewAllQuestionsForm viewAllQuestionsForm = new ViewAllQuestionsForm(mainForm, pandQ, textFileSelected);
            viewAllQuestionsForm.Show();
            this.Close();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm(mainForm, pandQ, textFileSelected);
            addQuestionForm.Show();
            this.Close();
        }

        private void btn_newPlaylist_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(mainForm, pandQ, textFileSelected);
            editForm.Show();
            this.Close();
        }
    }
}
