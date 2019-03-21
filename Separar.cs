using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separar
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr =
                    new StreamReader("C:/Users/hrolo/Desktop/automatizar-pruebas-unitarias-2019-Hectorolon/Problema 01.txt"))
            {
                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] separados = linea.Split(':');
                    foreach (string separado in separados)
                    {
                        Console.WriteLine(separado);
                    }

                }
            }
            Console.ReadKey();
        }
    }
}


