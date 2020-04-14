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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                    || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                    MessageBox.Show("Заполните все поля");
                else
                {
                    int name = Convert.ToInt32(textBox2.Text);
                    string path = "Kurs.txt";
                    Suppliers Sup = new Suppliers();
                    if (Sup.srav(path, name))
                        label9.Text = "этот индекс уже используется";
                    else
                    {
                        Sup.companyName = textBox1.Text;
                        Sup.adresIndex = Convert.ToInt32(textBox2.Text);
                        Sup.agentLastName = textBox3.Text;
                        Sup.agentFirstName = textBox4.Text;
                        Sup.agentMidName = textBox5.Text;
                        Sup.nameProduct = textBox6.Text;
                        Sup.price = Convert.ToDecimal(textBox7.Text);
                        Sup.amount = Convert.ToInt32(textBox8.Text);

                        Sup.WriteFile(path);
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
