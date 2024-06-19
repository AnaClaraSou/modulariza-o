using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    internal class Program
    {
        static int receber(char[] vet)
        {
            int contvog = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == 'a' || vet[i] == 'e' || vet[i] == 'i' || vet[i] == 'o' || vet[i] == 'u')
                {
                    contvog++;
                }
             
            }
            return contvog;
        }
        static void Main(string[] args)
        {
            int tam, quant;
         

            Console.WriteLine("Informe a quantidade desejada");
            tam = int.Parse(Console.ReadLine());

            char[] vetor = new char[tam];
            for (int i = 0;i < vetor.Length; i++)
            {
                Console.WriteLine("Informe a letra");
                vetor[i] = char.Parse(Console.ReadLine());
            }
            quant = receber(vetor);
            Console.WriteLine("A quantidade de vogais é: " + quant);
            Console.ReadLine();
        }
    }
}
