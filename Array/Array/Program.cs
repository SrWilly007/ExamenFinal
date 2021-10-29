using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, c;
            int[] a;
            Console.WriteLine("Ingrese el tamaño de array...: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero para sacar los multiplos...: ");
            c = int.Parse(Console.ReadLine());
            a = new int[b];
            for (int f = 0; f < b; f++)
            {
                a[f] = (f + 1) * c;
                Console.WriteLine("Los multiplos son....: " + a[f]);
            }
            Console.ReadKey();
        }
    }
}