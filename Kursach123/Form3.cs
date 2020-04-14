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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Введите id";
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    string path = "Kurs.txt";

                    Suppliers sup = new Suppliers();

                    if (id > sup.Prov(path, id) || (id < 1))
                    {
                        label2.Text = "Нет такого id";
                    }
                    else
                    {
                        label2.Text = "";
                        sup.deleteLine(path, id);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Введите корректно");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = "Kurs.txt";
            if (textBox2.Text == "")
            {
                label4.Text = "Введите индекс";
            }
            else
            {
                try
                {
                    int name = Convert.ToInt32(textBox2.Text);
                    Suppliers sup = new Suppliers();
                    try
                    {
                        sup.deleteLineCompany(path, name);
                        this.Close();
                    }
                    catch
                    {
                        label4.Text = "Нет совпадений";
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
