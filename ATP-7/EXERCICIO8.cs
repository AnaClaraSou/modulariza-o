using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO8
{
    internal class Program
    {
        static double Soma(int n)
        {
            
            double soma = 0;

            for (int i = 1; i <= n; i++)
            {
               double num = Math.Pow(i, 2) + 1;
               double dem = i + 3;
                soma += num / dem;

            }
            return soma;
        }
        static void Main(string[] args)
        {
            int n;
            double s = 0;

            Console.WriteLine("Informe o valor de n");
            n = int.Parse(Console.ReadLine());

            s = Soma(n);

            Console.WriteLine("A soma é: " + s);
            Console.ReadLine();
        }
    }
}
