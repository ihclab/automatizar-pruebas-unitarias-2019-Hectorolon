using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizadorPruebasunitarias
{
    class Program
    {
        static void Main(string[] args)
        {

            Medias medias = new Medias();
            
            try
            {                
                using (StreamReader sr =
                    new StreamReader("../../Problema 01.txt"))
                {
                    string linea;
                    

                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] separados = linea.Split(':');

                        foreach (string separado in separados)
                        {
                            string[] var = separados[2].Split(' ');
                            Console.WriteLine(separado);
                            int[] parametros = new int[var.Length];

                            try
                            {
                                for (int i = 0; i < parametros.Length; i++)
                                {
                                    parametros[i] = int.Parse(var[i]);
                                }
                            }
                            catch (Exception e)
                            {
                                if (separados[2] == "NULL")
                                    parametros = null;
                                //Console.WriteLine(e.Message);
                            }
                        }
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
