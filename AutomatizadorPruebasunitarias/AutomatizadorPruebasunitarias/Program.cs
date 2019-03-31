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
                using (StreamReader sr = new StreamReader("../../Problema 01.txt"))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] separados = linea.Split(':');
                        string[] var = separados[2].Split(' ');
                        double resultado;
                        double resultadoViejo = Convert.ToDouble(separados[3]);
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
                        }
                        switch (separados[1])
                        {
                            case "mediaAritmetica":
                                resultado = Medias.mediaAritmetica(parametros);
                                resultado *= 10000;
                                resultado = (Math.Truncate(resultado * 1) / 1);
                                if (resultado == resultadoViejo)
                                {
                                    Console.WriteLine(separados[0] + " Exito");
                                }
                                else
                                    Console.WriteLine(separados[0] + " Fallo");
                                break;

                            case "mediaGeometrica":
                                resultado = Medias.mediaGeometrica(parametros);
                                resultado *= 10000;
                                resultado = (Math.Truncate(resultado * 1) / 1);
                                if (resultado == resultadoViejo)
                                {
                                    Console.WriteLine(separados[0] + ": Exito");
                                }
                                else
                                    Console.WriteLine(separados[0] + ": Fallo");
                                break;

                            case "mediaArmonica":
                                resultado = Medias.mediaArmonica(parametros);
                                resultado *= 10000;
                                resultado = (Math.Truncate(resultado * 1) / 1);
                                if (resultado == resultadoViejo)
                                {
                                    Console.WriteLine(separados[0] + ": Exito");
                                }
                                else
                                    Console.WriteLine(separados[0] + ": Fallo");
                                break;

                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Console.WriteLine("El archivo no se puede leer");
                // Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
