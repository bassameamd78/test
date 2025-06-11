
using System;
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public class TestForm : BaseForm
    {
        private DataGridView dgvCodes = new DataGridView();

        public TestForm()
        {
            SetupBaseForm("Test", 580);

            var lblTestCodeID = NewLabel("Test Code ID:", 30);
            var lblTitle = NewLabel("Title:", 70);
            var lblDuration = NewLabel("Duration:", 110);
            var lblPublished = NewLabel("Is Published:", 150);
            var lblSubjectID = NewLabel("Subject ID:", 190);
            var lblQuestionsIDs = NewLabel("Questions IDs:", 230);

            var txtTestCodeID = NewTextBox(30, true);
            var txtTitle = NewTextBox(70);
            var txtDuration = NewTextBox(110);
            var txtPublished = NewTextBox(150);
            var txtSubjectID = NewTextBox(190, true);
            var txtQuestionsIDs = NewTextBox(230);

            dgvCodes.Location = new System.Drawing.Point(30, 280);
            dgvCodes.Size = new System.Drawing.Size(500, 100);
            dgvCodes.ColumnCount = 2;
            dgvCodes.Columns[0].Name = "QR Code";
            dgvCodes.Columns[1].Name = "Bar Code";
            dgvCodes.ReadOnly = true;
            dgvCodes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            groupBoxInfo.Controls.AddRange(new Control[] {
                lblTestCodeID, txtTestCodeID,
                lblTitle, txtTitle,
                lblDuration, txtDuration,
                lblPublished, txtPublished,
                lblSubjectID, txtSubjectID,
                lblQuestionsIDs, txtQuestionsIDs,
                dgvCodes
            });

            btnAdd.Click += (s, e) =>
            {
                txtTestCodeID.Text = "TST_" + DateTime.Now.Ticks.ToString().Substring(10);
                dgvCodes.Rows.Clear();
                dgvCodes.Rows.Add("QR_" + Guid.NewGuid().ToString().Substring(0, 8), "BAR_" + DateTime.Now.Ticks.ToString().Substring(6));
            };
        }
    }
}
