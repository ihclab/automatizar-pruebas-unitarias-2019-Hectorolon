using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizadorPruebasunitarias
{
    class Medias
    {
        public static double mediaAritmetica(params int[] vals)
        {
            int valores = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                valores += vals[i];
            }
            return valores / vals.Length;
        }
        
        private static double raizEnesima(double x, int n)
        {
            return Math.Pow(x, 1 / n);
        }
        
        public double mediaGeometrica(params int[] vals)
        {
            int valores = 1;
            for (int i = 0; i < vals.Length; i++)
            {
                valores *= vals[i];
            }
            return raizEnesima(valores, vals.Length);
        }
        
        public static double mediaArmonica(params int[] vals)
        {
            double valores = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                valores += 1 / vals[i];
            }
            return vals.Length / valores;
        }
    }
}
