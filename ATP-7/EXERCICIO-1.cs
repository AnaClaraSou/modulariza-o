using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_7
{
    internal class Program
    {
        static int receber (int n1,int n2,int n3,int n4)
        {
            int nummenor = 0;
            if (n1 < n2 && n1 < n3 && n1 < n4)
                nummenor = n1;
            else if (n2 < n1 && n2 < n3 && n2 < n4)
                nummenor = n2;
            else if (n3 < n1 && n3 < n2 && n3 < n4)
                nummenor = n3;
            else
                nummenor = n4;

            return nummenor;

        }

        static void Main(string[] args)
        {
            int num1,num2,num3,num4,menor;
            Console.WriteLine("Informe um número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            num4 = int.Parse(Console.ReadLine());

            menor = receber(num1, num2, num3, num4);
            Console.WriteLine("O número menor é: " + menor);
            Console.ReadLine();

        }
    }
}
