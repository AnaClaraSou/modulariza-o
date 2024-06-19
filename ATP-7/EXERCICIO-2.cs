using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_2
{
    internal class Program
    {
        static double receber (double a, double b)
        {
            double valor = 0;

            valor = Math.Sqrt ( Math.Pow(a,2) + Math.Pow(b,2));
            return valor;

        } 
        static void Main(string[] args)
        {
            double vala, valb, result;
            Console.WriteLine("Informe o valor de a");
            vala = int.Parse(Console.ReadLine());
            Console.WriteLine("Inorme o valor de b");
            valb = int.Parse(Console.ReadLine());

            result = receber(vala, valb);
            Console.WriteLine("O valor da hipotenusA é: " + result);
            Console.ReadLine();
        }
    }
}
