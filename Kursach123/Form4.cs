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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "Kurs.txt";

            Suppliers sup = new Suppliers();
            if (textBox1.Text == "")
                label10.Text = "Введите id";
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);

                    if (id > sup.Prov(path, id) || (id < 1))
                    {
                        label10.Text = "Нет такого id";
                    }
                    else
                    {
                        label10.Text = "";
                        label10.Text = "";
                        sup.ReadFile(path, id);
                        textBox9.Text = sup.companyName;
                        textBox2.Text = Convert.ToString(sup.adresIndex);
                        textBox3.Text = sup.agentLastName;
                        textBox4.Text = sup.agentFirstName;
                        textBox5.Text = sup.agentMidName;
                        textBox6.Text = sup.nameProduct;
                        textBox7.Text = Convert.ToString(sup.price);
                        textBox8.Text = Convert.ToString(sup.amount);
                    }
                }catch
                {
                    label10.Text = "Вветите корректный id";
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string path = "Kurs.txt";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
               || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    int name = Convert.ToInt32(textBox2.Text);
                    Suppliers sup = new Suppliers(textBox9.Text, Convert.ToInt32(textBox2.Text), textBox3.Text,
                        textBox4.Text, textBox5.Text, textBox6.Text, Convert.ToDecimal(textBox7.Text), Convert.ToInt32(textBox8.Text));

                    string a = sup.companyName;
                    if (sup.srav(path, name))
                    {
                        sup.ReadFile(path, id);
                        if (sup.adresIndex != Convert.ToInt32(textBox2.Text))
                        {
                            MessageBox.Show("этот индекс уже используется");
                        }
                        else
                        {                         
                            sup.companyName = textBox9.Text;
                            sup.adresIndex = Convert.ToInt32(textBox2.Text);
                            sup.agentLastName = textBox3.Text;
                            sup.agentFirstName = textBox4.Text;
                            sup.agentMidName = textBox5.Text;
                            sup.nameProduct = textBox6.Text;
                            sup.price = Convert.ToDecimal(textBox7.Text);
                            sup.amount = Convert.ToInt32(textBox8.Text);

                            sup.change(path, id);
                            this.Close();
                        }
                    }
                    else
                    {
                        sup.companyName = textBox9.Text;
                        sup.adresIndex = Convert.ToInt32(textBox2.Text);
                        sup.agentLastName = textBox3.Text;
                        sup.agentFirstName = textBox4.Text;
                        sup.agentMidName = textBox5.Text;
                        sup.nameProduct = textBox6.Text;
                        sup.price = Convert.ToDecimal(textBox7.Text);
                        sup.amount = Convert.ToInt32(textBox8.Text);

                        sup.change(path, id);
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
