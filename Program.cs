using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());

            imprimir(1, n);


        }
        static void imprimir(int actual, int n)
        {
            if (actual > n) return;
            Console.WriteLine(actual);

            imprimir(actual + 1, n);

            Console.ReadKey();
        }
    }
}
