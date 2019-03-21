using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace LeerArchivo
{
    class Leer
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr =
                    new StreamReader("C:/Users/hrolo/Desktop/automatizar-pruebas-unitarias-2019-Hectorolon/Problema 01.txt"))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El archivo no se puede leer");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}


