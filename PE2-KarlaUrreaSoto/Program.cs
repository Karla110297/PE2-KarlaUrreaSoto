using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_KarlaUrreaSoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones f = new Operaciones();

            Console.WriteLine("Tamaño de la sucesión");
            int tamanioSucesion = Int32.Parse(Console.ReadLine());

            double[] sucesion = new double[tamanioSucesion];
            double[] sucesionInv = new double[tamanioSucesion];

            double[] mayorMenor = new double[2];

            for (int i = 0; i < tamanioSucesion; i++)
            {
                Console.WriteLine("Numero  " + (i + 1));
                sucesion[i] = double.Parse(Console.ReadLine());

            }

            mayorMenor = f.MaxMin(sucesion, sucesion.Length - 1, mayorMenor);
            Console.WriteLine("Numero mayor= {0} y numero menor = {1}",mayorMenor[0],mayorMenor[1]);

            sucesionInv = f.Inversion(sucesion, sucesion.Length - 1, sucesionInv, 0);

            Console.WriteLine("Sucesion inversa= ");
            foreach (double a in sucesionInv)
            {
                Console.Write(a + " ");
            }

            Console.ReadKey();
        }
    }
}
