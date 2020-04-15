using System;
using System.Windows.Forms;


namespace Kursach123
{

    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (indexTextBox.Text == "")
            {
                messageLabel.Text = "Введите индекс";
            }
            else
            {
                try
                {
                    int name = Convert.ToInt32(indexTextBox.Text);
                    Suppliers sup = new Suppliers();
                    try
                    {
                        sup.deleteLineCompany(MainForm.path, name);
                        this.Close();
                    }
                    catch
                    {
                        messageLabel.Text = "Нет совпадений";
                    }
                }
                catch
                {
                    MessageBox.Show("Введите корректно");
                }
            }
        }
    }
}
