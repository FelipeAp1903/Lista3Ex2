using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;


            Console.WriteLine("insira um valor");

            n1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo valor (tem que ser maior que o primeiro valor)");

            n2 = Double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("insira o segundo valor (tem que ser maior que o primeiro valor)");

                n2 = Double.Parse(Console.ReadLine());
            }

            while (n2 < n1);
            {
                Console.WriteLine("{0} é menor que {1}.", n1, n2);
            }

            







            





        }
    }
}
