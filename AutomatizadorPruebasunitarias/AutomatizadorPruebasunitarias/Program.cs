using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch sw = new Stopwatch();
            try
            {
                using (StreamReader sr = new StreamReader("../../Caso de Prueba.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //sw.Reset();
                        sw.Start();
                        //sw.Restart();
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
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + " Exito " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Green);
                                        sw.Restart();
                                    }
                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + " Fallo " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Red);
                                        sw.Restart();
                                    }
                                    break;

                                case "mediaGeometrica":
                                    resultado = Medias.mediaGeometrica(parametros);
                                    resultado *= 10000;
                                    resultado = (Math.Truncate(resultado * 1) / 1);
                                    if (resultado == resultadoViejo)
                                    {
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + ": Exito " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Green);
                                        sw.Restart();
                                    }
                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + ": Fallo " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Red);
                                        sw.Restart();
                                    }
                                    break;

                                case "mediaArmonica":
                                    resultado = Medias.mediaArmonica(parametros);
                                    resultado *= 10000;
                                    resultado = (Math.Truncate(resultado * 1) / 1);
                                    if (resultado == resultadoViejo)
                                    {
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + ": Exito " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Green);
                                        sw.Restart();
                                    }
                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine(separados[0] + ": Fallo " + "T.E. " + sw.ElapsedMilliseconds, Console.ForegroundColor = ConsoleColor.Red);
                                        sw.Restart();
                                    }
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
