
using System;
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserForm()); // يمكن تغييره إلى SubjectForm() أو غيره لتجربة نموذج آخر.
        }
    }
}
