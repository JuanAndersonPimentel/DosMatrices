using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DosMatrices
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] matriz1 = new int[matriz1];
            int[] matriz2 = new int[matriz2];

            try
            {
                Console.WriteLine("ingrese los elementos de la primera matriz: ");



                for (int i = 0; i < matriz1.Length; i++)
                {
                    matriz1[i] = i;
                    matriz1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("ingrese los elementos de la segunda matriz: ");
                for (int i = 0;i < matriz2.Length; i++)
                {
                    Console.WriteLine($"elemento {i + 1}: ");
                    matriz2[i] = Convert.ToInt32(Console.ReadLine());
                }
                bool soniguales = true;

                for (int i = 0; i <= matriz1.Length; i++)
                
                    if (matriz1[i] != matriz2[i])
                    {
                        soniguales = false;
                        break;
                    }
                Console.WriteLine(soniguales ? "las matrices son iguales. " : "las matrices no son iguales.");
                
            }
            catch (Exception)
            {
                Console.WriteLine("error: ingrese solo numeros validos.");
                
            }


        }
    }
}
