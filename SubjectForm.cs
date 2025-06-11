
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public class SubjectForm : BaseForm
    {
        public SubjectForm()
        {
            SetupBaseForm("Subject");

            var lblCodeID = NewLabel("Subject Code ID:", 40);
            var lblName = NewLabel("Name:", 80);
            var lblDesc = NewLabel("Description:", 120);
            var lblInstructor = NewLabel("Instructor ID:", 160);
            var lblQBank = NewLabel("Questions Banks:", 200);

            var txtCodeID = NewTextBox(40);
            var txtName = NewTextBox(80);
            var txtDesc = NewTextBox(120);
            var txtInstructor = NewTextBox(160, true);
            var txtQBank = NewTextBox(200, true);

            groupBoxInfo.Controls.AddRange(new Control[] {
                lblCodeID, txtCodeID,
                lblName, txtName,
                lblDesc, txtDesc,
                lblInstructor, txtInstructor,
                lblQBank, txtQBank
            });
        }
    }
}
