using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    internal class Program
    {
        static void Calcular(int num1, int num2, int num3, char op)
        {


            switch (op)
            {
                case 'A':
                    double ma = (num1 + num2 + num3) / 3.0;
                    Console.WriteLine($"A Média Aritmética é:{ma}");
                    break;
                case 'a':
                    double MA = (num1 + num2 + num3) / 3.0;
                    Console.WriteLine($"A Média Aritmética é:{MA}");

                break;
                   
                case 'P':
                    double mp = (num1 * 5 + num2 * 3 + num3 * 2) / 10.0;
                    Console.WriteLine($"A média ponderada é:{mp}");
                    break;
                case 'p':
                    double MP = (num1 * 5 + num2 * 3 + num3 * 2) / 10.0;
                    Console.WriteLine($"A média ponderada é:{MP}");
                    break;

                default:

                    Console.WriteLine("Erro! Não é possível fazer nenhum cálculo");

                break;

            }


        }
        static void Main(string[] args)
        {
            int n1, n2, n3; char opção;

            Console.WriteLine("Informe um número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informw um número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome uma letra (A para média aritmética, P para média ponderada):");
            opção = char.Parse(Console.ReadLine());

            Calcular(n1, n2, n3, opção);
            Console.ReadLine();

        }
    }
}
