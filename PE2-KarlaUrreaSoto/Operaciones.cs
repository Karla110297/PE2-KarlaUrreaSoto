using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_KarlaUrreaSoto
{
    class Operaciones
    {

        public double[] MaxMin(double[] arreglo, int n, double[] Soluciones)
        {

            if (n >= 0)
            {
                if (arreglo[n] >= Soluciones[0])
                {
                    Soluciones[0] = arreglo[n];
                }
                if (n==(arreglo.Length-1)||arreglo[n] <= Soluciones[1])
                {
                    Soluciones[1] = arreglo[n];
                }
                MaxMin(arreglo, n - 1, Soluciones);
            }
            return Soluciones;
        }
        
        public double[] Inversion(double[] arreglo, int n, double[] arregloinv, int i)
        {

            if (n >= 0)
            {
                arregloinv[i] = arreglo[n];

                Inversion(arreglo, n - 1, arregloinv, i + 1);
            }
            return arregloinv;
        }
    }
}
