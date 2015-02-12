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
    public partial class ViewAllQuestionsForm : Form
    {
        OpeningForm openingForm = new OpeningForm();
        PandQ pandQ = new PandQ();

        public ViewAllQuestionsForm(OpeningForm myOpeningForm, PandQ myPlaylist)
        {
            InitializeComponent();
            openingForm = myOpeningForm;
            pandQ = myPlaylist;
            txtBox_Questions.Lines = pandQ.viewAllQuestions();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SelectEditForm selectEditForm = new SelectEditForm(openingForm, pandQ);
            selectEditForm.Show();
            this.Close();
        }
    }
}
