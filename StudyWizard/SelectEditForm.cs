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
        Questions questions = new Questions();

        public SelectEditForm() { }
        public SelectEditForm(OpeningForm myOpeningForm, PandQ myPlaylist, Questions myQuestions)
        {
            InitializeComponent();
            openingForm = myOpeningForm;
            pandQ = myPlaylist;
            questions = myQuestions;
            lsbx_EditListBox.DataSource = pandQ.playlistNames;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(openingForm, this, pandQ, questions, lsbx_EditListBox.SelectedIndex);
            editForm.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            openingForm.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}
