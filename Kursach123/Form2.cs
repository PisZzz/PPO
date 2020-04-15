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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" || indexTextBox.Text == "" || agentLastNameTextBox.Text == "" || agentFirstNameTextBox.Text == ""
                    || agentMidNameTextBox.Text == "" || nameProductTextBox.Text == "" || priceTextBox.Text == "" || amoutTextBox.Text == "")
                    MessageBox.Show("Заполните все поля");
                else
                {
                    int name = Convert.ToInt32(indexTextBox.Text);
                    Suppliers Sup = new Suppliers();
                    if (Sup.srav(MainForm.path, name))
                        messageLabel.Text = "этот индекс уже используется";
                    else
                    {
                        Sup.companyName = nameTextBox.Text;
                        Sup.adresIndex = Convert.ToInt32(indexTextBox.Text);
                        Sup.agentLastName = agentLastNameTextBox.Text;
                        Sup.agentFirstName = agentFirstNameTextBox.Text;
                        Sup.agentMidName = agentMidNameTextBox.Text;
                        Sup.nameProduct = nameProductTextBox.Text;
                        Sup.price = Convert.ToDecimal(priceTextBox.Text);
                        Sup.amount = Convert.ToInt32(amoutTextBox.Text);

                        Sup.WriteFile(MainForm.path);
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

    }
}
