using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kursach123
{
    class Suppliers
    {
        public string companyName;
        public int adresIndex;
        public string agentLastName;
        public string agentFirstName;
        public string agentMidName;

        public string nameProduct;
        public decimal price;

        public int amount;

        public Suppliers()
        {
            companyName = "";
            adresIndex = 0;
            agentLastName = "";
            agentFirstName = "";
            agentMidName = "";

            nameProduct = "";
            price = 0;

            amount = 0;
        }
        public Suppliers(string companyName, int adresIndex, string agentLastName,
            string agentFirstName, string agentMidName, string nameProduct, decimal price, int amount)
        {
            this.companyName = companyName;
            this.adresIndex = adresIndex;
            this.agentLastName = agentLastName;
            this.agentFirstName = agentFirstName;
            this.agentMidName = agentMidName;
            this.nameProduct = nameProduct;
            this.price = price;
            this.amount = amount;
        }
        public void WriteFile(string path)                             //запись
        {
            string buffer = companyName + ";" + adresIndex + ";" + agentLastName + ";" +
               agentFirstName + ";" + agentMidName + ";" + nameProduct + ";" +
                price + ";" + amount;
            File.AppendAllText(path, buffer + '\n');
        }
        public void ReadFile(string path, int id)                        //чтение
        {
            string[] file = File.ReadAllLines(path);
            string[] buffer = file[id - 1].Split(';');

            companyName = buffer[0];
            adresIndex = Convert.ToInt32(buffer[1]);
            agentLastName = buffer[2];
            agentFirstName = buffer[3];
            agentMidName = buffer[4];
            nameProduct = buffer[5];
            price = Convert.ToDecimal(buffer[6]);
            amount = Convert.ToInt32(buffer[7]);
        }
        public void print()                                 //Вывод на экран
        {
            Console.WriteLine(companyName + ";" + adresIndex + ";" + agentLastName + ";" +
               agentFirstName + ";" + agentMidName + ";" + nameProduct + ";" +
                price + ";" + amount);
        }

        public void change(string path, int id)                         //изменение строки
        {

            string[] file = File.ReadAllLines(path);

            //input();

            string buff = companyName + ";" + adresIndex + ";" + agentLastName + ";" +
              agentFirstName + ";" + agentMidName + ";" + nameProduct + ";" +
               price + ";" + amount;
            file[id - 1] = buff;

            File.WriteAllLines(path, file);
        }
        public void deleteLine(string path, int id)                          //Удаление строки
        {
            string[] file = File.ReadAllLines(path);
            string[] file2 = new string[file.Length - 1];

            for (int i = id; i < file.Length; i++)
            {
                file[i - 1] = file[i];
            }
            for (int i = 0; i < file.Length - 1; i++)
                file2[i] = file[i];
            File.WriteAllLines(path, file2);
        }
        public int Prov(string path, int id)                         //изменение строки
        {
            string[] file = File.ReadAllLines(path);
            return file.Length;
        }
        public int sravneniya(string path, int index)
        {
            string[] file = File.ReadAllLines(path);
            string[] file2 = new string[file.Length - 1];
            int id = 0;
            for (int i = 0; i < file.Length; i++)
            {
                ReadFile(path, i + 1);
                if (adresIndex == index)
                {
                    id = i + 1;
                }
            }
            return id;
        }

        public void deleteLineCompany(string path, int name)          //Удаление по индексу
        {
            string[] file = File.ReadAllLines(path);
            string[] file2 = new string[file.Length - 1];

            int id = 0;
            for(int i = 0; i < file.Length; i++)
             {
                ReadFile(path, i+1);
                if (adresIndex == name)
                {
                    id = i+1;
                }
            }
                for (int i = id; i < file.Length; i++)
            {
                file[i - 1] = file[i];
            }
            for (int i = 0; i < file.Length - 1; i++)
                file2[i] = file[i];
            File.WriteAllLines(path, file2);
        }
        public bool srav(string path, int name)
        {
            string[] file = File.ReadAllLines(path);
            string[] file2 = new string[file.Length - 1];
            for (int i = 0; i < file.Length; i++)
            {
                ReadFile(path, i + 1);
                if(name == adresIndex)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
