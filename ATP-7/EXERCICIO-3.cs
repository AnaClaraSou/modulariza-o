using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ATP_7
{
    internal class Program
    {
        static int MMC(int num1,int num2)
        {
           int maior = 0;
            int menor = 0;
            int mmc = 0;
            
            if (num1 > num2)
            {
                maior = num1;
                menor = num2;
            }
            else
            {
                maior = num2;
                menor = num1;
            }
            mmc = maior;
            while (mmc % menor != 0)
            {
                mmc += maior;
            }
           
            return mmc;
        }

        static int MDC(int num1,int num2)
        {
            int resto = 0;
            int aux = 0;

            if (num1 < num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            do
            {
                resto = num1 % num2;
                num1 = num2;
                num2 = resto;
            }while (resto != 0);
             return num1;
        }

        static void Main(string[] args)
        {
            int n1, n2, op, result;

            do
            {
                Console.WriteLine("Menu\n1:MMC\n2:MDC\n3:Sair\nEscolha uma opção");
                op=int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("Informe um número");
                        n1=int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um número");
                        n2=int.Parse(Console.ReadLine());
                        result = MMC(n1, n2);
                        Console.WriteLine("O MMC é:" + result);
                    break;

                    case 2:
                        Console.WriteLine("Informe um número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um número");
                        n2 = int.Parse(Console.ReadLine());
                        result = MDC(n1, n2);
                        Console.WriteLine("O MDC é:" + result);
                    break;
                }
            }while (op != 3);
            Console.WriteLine("Você saiu do programa");
            Console.ReadLine();
        }
    }
}
