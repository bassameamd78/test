
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public class QuestionForm : BaseForm
    {
        public QuestionForm()
        {
            SetupBaseForm("Question Banks");

            var lblSubjects = NewLabel("Subjects:", 60);
            var lblQBank = NewLabel("Questions Banks:", 100);
            var lblTBank = NewLabel("Tests Banks:", 140);

            var txtSubjects = NewTextBox(60);
            var txtQBank = NewTextBox(100);
            var txtTBank = NewTextBox(140);

            groupBoxInfo.Controls.AddRange(new Control[] {
                lblSubjects, txtSubjects,
                lblQBank, txtQBank,
                lblTBank, txtTBank
            });
        }
    }
}
