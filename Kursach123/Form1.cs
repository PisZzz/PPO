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
    public partial class MainForm : Form
    {
        public static string path = "Kurs.txt";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] file = File.ReadAllLines(path);
            TableDataGridView.Rows.Clear();
            for (int i = 0; i < file.Length; i++)
            {
                string[] buffer = file[i].Split(';');
                TableDataGridView.Rows.Add();
                TableDataGridView.Rows[i].Cells[0].Value = i+1;
                TableDataGridView.Rows[i].Cells[1].Value = buffer[0];
                TableDataGridView.Rows[i].Cells[2].Value = buffer[1];
                TableDataGridView.Rows[i].Cells[3].Value = buffer[2];
                TableDataGridView.Rows[i].Cells[4].Value = buffer[3];
                TableDataGridView.Rows[i].Cells[5].Value = buffer[4];
                TableDataGridView.Rows[i].Cells[6].Value = buffer[5];
                TableDataGridView.Rows[i].Cells[7].Value = buffer[6];
                TableDataGridView.Rows[i].Cells[8].Value = buffer[7];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteForm deleteForm = new deleteForm();
            deleteForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chengeForm chengeForm = new chengeForm();
            chengeForm.Show();
        }
    }
}
