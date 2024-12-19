using System.Drawing;
using System.Windows.Forms;

namespace InternetProviderMenu
{
    public static class CustomStyles
    {
        public static void StyleForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Color.White;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(0, 122, 204);
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            button.FlatAppearance.BorderSize = 1;
            button.Cursor = Cursors.Hand;
        }

        public static void StyleListView(ListView listView)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void StyleLabel(Label label)
        {
            label.ForeColor = Color.Black;
        }

        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}