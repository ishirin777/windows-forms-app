using System.Windows.Forms;

namespace StudentCrudOperations
{
    class ClearFields
    {
        public static void clearAllFields(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Text = null;
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.CustomFormat = " ";
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.Checked = false;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if(control is CheckedListBox)
                {
                    CheckedListBox checkedListBox = (CheckedListBox)control;

                    for (int i = 0; i < checkedListBox.Items.Count; i++)
                    {
                        checkedListBox.SetItemChecked(i, false);
                    }

                }
            }
        }
    }
}
