
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public class UserForm : BaseForm
    {
        public UserForm()
        {
            SetupBaseForm("User");

            var lblName = NewLabel("Name:", 40);
            var lblEmail = NewLabel("Email:", 80);
            var lblPhone = NewLabel("Phone Number:", 120);
            var lblRole = NewLabel("Role:", 160);

            var txtName = NewTextBox(40);
            var txtEmail = NewTextBox(80);
            var txtPhone = NewTextBox(120);
            var txtRole = NewTextBox(160);

            groupBoxInfo.Controls.AddRange(new Control[] {
                lblName, txtName,
                lblEmail, txtEmail,
                lblPhone, txtPhone,
                lblRole, txtRole
            });
        }
    }
}
