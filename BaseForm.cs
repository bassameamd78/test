
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnifiedFormsApp
{
    public class BaseForm : Form
    {
        protected GroupBox groupBoxInfo = new GroupBox();
        protected Button btnAdd = new Button();
        protected Button btnClear = new Button();
        protected Button btnDelete = new Button();

        protected void SetupBaseForm(string title, int height = 500)
        {
            this.Text = title;
            this.Size = new Size(600, height);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Font = new Font("Segoe UI", 10);
            this.MaximizeBox = false;

            groupBoxInfo.Location = new Point(20, 20);
            groupBoxInfo.Size = new Size(540, 300);
            groupBoxInfo.Text = title + " Information";

            btnAdd.Text = "Add";
            btnAdd.Size = new Size(120, 40);
            btnAdd.Location = new Point(70, height - 100);
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;

            btnClear.Text = "Clear";
            btnClear.Size = new Size(120, 40);
            btnClear.Location = new Point(220, height - 100);
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;

            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.Location = new Point(370, height - 100);
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;

            this.Controls.Add(groupBoxInfo);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnDelete);
        }

        protected Label NewLabel(string text, int y) => new Label() { Text = text, Location = new Point(20, y), AutoSize = true };
        protected TextBox NewTextBox(int y, bool readOnly = false) => new TextBox() { Location = new Point(160, y - 5), Width = 360, ReadOnly = readOnly };
    }
}
