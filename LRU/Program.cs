using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arreglo = { { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, };

            Console.WriteLine("Ingrese 5 digitos de estado en binario");
            string temp = Console.ReadLine();
            int e = temp.Length;
            int[] estado = new int[e];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '1')
                    estado[i] = 1;
                else if (temp[i] == '0')
                    estado[i] = 0;
            }
            
            Console.Write(Environment.NewLine);
            for (int j = 0; j < 5; j++)
            {
                for (int c = 6; c > 0; c--)
                    arreglo[j, c] = arreglo[j, c - 1];
                arreglo[j, 0] = estado[j];
                for (int v = 0; v < 8; v++)
                    Console.Write("{0}", arreglo[j, v]);

                Console.Write(Environment.NewLine);
            }


            Console.ReadLine();

			}
        }
}

