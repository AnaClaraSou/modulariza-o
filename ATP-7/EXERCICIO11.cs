using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO11
{
    internal class Program
    {
        static void Convert (int Tseg,out int hora,out int min,out int seg)
        {
            hora = Tseg / 3600;
            Tseg %= 3600;
            min = Tseg / 60;
            seg = Tseg % 60;
        }
        static void Main(string[] args)
        {
            int segundos, minutos, horas, totalS;

            Console.WriteLine("Informe os segundos");
            totalS = int.Parse(Console.ReadLine());

            Convert(totalS, out horas, out minutos, out segundos);

            Console.WriteLine($"O tempo em segundos é: {horas:D2}, {minutos:D2}, {segundos:D2}");
            Console.ReadLine();
        }
    }
}
