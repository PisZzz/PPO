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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "Kurs.txt";
            string[] file = File.ReadAllLines(path);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < file.Length; i++)
            {
                string[] buffer = file[i].Split(';');
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i+1;
                dataGridView1.Rows[i].Cells[1].Value = buffer[0];
                dataGridView1.Rows[i].Cells[2].Value = buffer[1];
                dataGridView1.Rows[i].Cells[3].Value = buffer[2];
                dataGridView1.Rows[i].Cells[4].Value = buffer[3];
                dataGridView1.Rows[i].Cells[5].Value = buffer[4];
                dataGridView1.Rows[i].Cells[6].Value = buffer[5];
                dataGridView1.Rows[i].Cells[7].Value = buffer[6];
                dataGridView1.Rows[i].Cells[8].Value = buffer[7];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }
    }
}
