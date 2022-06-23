using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    public class Directa
    {
        private int[] vector;
        public void Cargar()
        {
            Console.WriteLine("Metodo de insercion directa");
            Console.WriteLine("Longitud del verctor");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese elemento " +(i+1)+": ");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }
        public void InsercionDirecta()
        {

        }
    }
}
