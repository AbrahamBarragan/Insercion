using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    public class Directa
    {
        private int[] arreglo;
        public void Cargar()
        {
            Console.WriteLine("Metodo de insercion directa");
            Console.WriteLine("Longitud del verctor");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            arreglo = new int[cant];
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Ingrese elemento " +(i+1)+": ");
                linea = Console.ReadLine();
                arreglo[i] = int.Parse(linea);
            }
        }
        public void InsercionDirecta()
        {
            int auxili;
            int d;
            for (int i = 0; i < arreglo.Length; i++)
            {
                auxili = arreglo[i];
                d = i - 1;
                while(d >= 0 && arreglo[d] > auxili)
                {
                    arreglo[d + 1] = arreglo[d];
                    d--;
                }
                arreglo[d + 1] = auxili;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("vector ordenados en forma ascendente");
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]+"  ");
            }
            Console.ReadKey();
        }

    }
}
