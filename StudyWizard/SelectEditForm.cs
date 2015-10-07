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

        public SelectEditForm(MainForm mainForm, PandQ pandQ)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.pandQ = pandQ;
            lsbx_EditListBox.DataSource = pandQ.playlistNames;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // If a playlist is not selected, lsbx_EditListBox.SelectedIndex = -1. So, check if a playlist is selected. If one is, open up EditForm with the data from the selected index.
            if (lsbx_EditListBox.SelectedIndex != -1)
            {
                EditForm editForm = new EditForm(mainForm, pandQ, lsbx_EditListBox.SelectedIndex);
                editForm.Show();
                this.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // If a playlist is not selected, lsbx_EditListBox.SelectedIndex = -1. So, check if a playlist is selected. If one is, delete it.
            if (lsbx_EditListBox.SelectedIndex != -1) pandQ.deletePlaylist(lsbx_EditListBox.SelectedIndex);
            // Clear the selected index
            lsbx_EditListBox.ClearSelected();
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            ViewAllQuestionsForm viewAllQuestionsForm = new ViewAllQuestionsForm(mainForm, pandQ);
            viewAllQuestionsForm.Show();
            this.Close();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm(mainForm, pandQ);
            addQuestionForm.Show();
            this.Close();
        }

        private void btn_newPlaylist_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(mainForm, pandQ);
            editForm.Show();
            this.Close();
        }
    }
}
