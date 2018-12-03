using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("control de veresiones1");
            Console.WriteLine("control de veresiones2");
            Console.WriteLine("control de veresiones3");
            Console.WriteLine("control de veresiones4");
            Console.WriteLine("control de veresiones5");
            Console.WriteLine("Probando Control");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            Console.WriteLine("Probando control de veresiones");
            vectorInicializar();
            Console.ReadKey();
        }
        public static void vectorInicializar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir el vector 
            Console.WriteLine("/nELEMENTOS DEL VECTOR\n===========/n");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Elementos indice {0} --> {1}", (i + 1), x[i]);
            }

            //sumatoria de los elementos del vector
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }
            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("El promedio es {0}", (double)suma / x.Length);
        }
    }
}
