using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursach123
{
    
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
