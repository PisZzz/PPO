using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Kursach123
{
    public partial class chengeForm : Form
    {
        public chengeForm()
        {
            InitializeComponent();
        }

        private void vvodButton_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers();
            if (indexLineTextBox.Text == "")
                messageLabel.Text = "Введите индекс";
            else
            {
                try
                {
                    int index = Convert.ToInt32(indexLineTextBox.Text);
                    int id = sup.sravneniya(MainForm.path, index);

                    if (id == 0)
                    {
                        messageLabel.Text = "Нет такого индекса";
                    }
                    else
                    {
                        messageLabel.Text = "";
                        messageLabel.Text = "";
                        sup.ReadFile(MainForm.path, id);
                        nameTextBox.Text = sup.companyName;
                        indexTextBox.Text = Convert.ToString(sup.adresIndex);
                        agentLastNameTextBox.Text = sup.agentLastName;
                        agentFirstNameTextBox.Text = sup.agentFirstName;
                        agentMidNameTextBox.Text = sup.agentMidName;
                        nameProductTextBox.Text = sup.nameProduct;
                        priceTextBox.Text = Convert.ToString(sup.price);
                        amoutTextBox.Text = Convert.ToString(sup.amount);
                    }
                }catch
                {
                    messageLabel.Text = "Вветите корректный индекс";
                }
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            if (indexLineTextBox.Text == "" || indexTextBox.Text == "" || agentLastNameTextBox.Text == "" || agentFirstNameTextBox.Text == ""
               || agentMidNameTextBox.Text == "" || nameProductTextBox.Text == "" || priceTextBox.Text == "" || amoutTextBox.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                try
                {
                    int index = Convert.ToInt32(indexLineTextBox.Text);
                    int name = Convert.ToInt32(indexTextBox.Text);
                    Suppliers sup = new Suppliers(nameTextBox.Text, Convert.ToInt32(indexTextBox.Text), agentLastNameTextBox.Text,
                        agentFirstNameTextBox.Text, agentMidNameTextBox.Text, nameProductTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(amoutTextBox.Text));
                    int id = sup.sravneniya(MainForm.path, index);

                    string a = sup.companyName;
                    if (sup.srav(MainForm.path, name))
                    {
                        sup.ReadFile(MainForm.path, id);
                        if (sup.adresIndex != Convert.ToInt32(indexTextBox.Text))
                        {
                            MessageBox.Show("этот индекс уже используется");
                        }
                        else
                        {                         
                            sup.companyName = nameTextBox.Text;
                            sup.adresIndex = Convert.ToInt32(indexTextBox.Text);
                            sup.agentLastName = agentLastNameTextBox.Text;
                            sup.agentFirstName = agentFirstNameTextBox.Text;
                            sup.agentMidName = agentMidNameTextBox.Text;
                            sup.nameProduct = nameProductTextBox.Text;
                            sup.price = Convert.ToDecimal(priceTextBox.Text);
                            sup.amount = Convert.ToInt32(amoutTextBox.Text);

                            sup.change(MainForm.path, id);
                            this.Close();
                        }
                    }
                    else
                    {
                        sup.companyName = nameTextBox.Text;
                        sup.adresIndex = Convert.ToInt32(indexTextBox.Text);
                        sup.agentLastName = agentLastNameTextBox.Text;
                        sup.agentFirstName = agentFirstNameTextBox.Text;
                        sup.agentMidName = agentMidNameTextBox.Text;
                        sup.nameProduct = nameProductTextBox.Text;
                        sup.price = Convert.ToDecimal(priceTextBox.Text);
                        sup.amount = Convert.ToInt32(amoutTextBox.Text);

                        sup.change(MainForm.path, id);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
        }
    }
}
