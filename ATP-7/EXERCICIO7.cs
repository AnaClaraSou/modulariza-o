using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO7
{
    internal class Program
    {
        static double Soma (int n)
        {
            double soma = 0.0;
            if(n <= 0)
            {
                Console.WriteLine("Erro! Valor Inválido");
            }

            for (int i = 1; i <= n; i++)
            {
                soma +=  1.0 / i ;
            }
            return soma;
        }
        static void Main(string[] args)
        {
            double s = 0;
            int n;

            Console.WriteLine("Informe o valor de n");
            n = int.Parse(Console.ReadLine());

            s = Soma(n);
            Console.WriteLine("O valor da soma é: " + s);
            Console.ReadLine();
        }
    }
}
