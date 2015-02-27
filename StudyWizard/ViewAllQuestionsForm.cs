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
        PandQ pandQ = new PandQ();
        bool textFileSelected;

        public ViewAllQuestionsForm(PandQ pandQ, bool textFileSelected)
        {
            InitializeComponent();
            this.pandQ = pandQ;
            this.textFileSelected = textFileSelected;
            chdlsbx_questions.DataSource = pandQ.viewAllQuestions();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SelectEditForm selectEditForm = new SelectEditForm(pandQ, textFileSelected);
            selectEditForm.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            pandQ.deleteQuestion(chdlsbx_questions.CheckedIndices);
            chdlsbx_questions.ClearSelected();
            chdlsbx_questions.DataSource = pandQ.viewAllQuestions();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
