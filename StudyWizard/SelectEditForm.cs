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
        OpeningForm openingForm = new OpeningForm();
        PandQ pandQ = new PandQ();

        public SelectEditForm(OpeningForm myOpeningForm, PandQ myPlaylist)
        {
            InitializeComponent();
            openingForm = myOpeningForm;
            pandQ = myPlaylist;
            lsbx_EditListBox.DataSource = pandQ.playlistNames;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(openingForm, pandQ, lsbx_EditListBox.SelectedIndex);
            editForm.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            openingForm.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            pandQ.deletePlaylist(lsbx_EditListBox.SelectedIndex);
            lsbx_EditListBox.ClearSelected();
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            ViewAllQuestionsForm viewAllQuestionsForm = new ViewAllQuestionsForm(openingForm, pandQ);
            viewAllQuestionsForm.Show();
            this.Close();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(openingForm, pandQ);
            editForm.Show();
            this.Close();
        }
    }
}
