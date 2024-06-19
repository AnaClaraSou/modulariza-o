using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO9
{
    internal class Program
    {
        static void ObterMaioreMenor(float[]vet,out float menor,out float maior)
        {
            maior = float.MinValue;
            menor = float.MaxValue;

            for(int i=0;i<vet.Length;i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
        }
        static void Main(string[] args)
        {
            float Maior, Menor; int tam;

            Console.WriteLine("Informe o tamanho do vetor");
            tam = int.Parse(Console.ReadLine());

            float[] vet = new float[tam];

            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Informe um número");
                vet[i] = float.Parse(Console.ReadLine());

            }

           ObterMaioreMenor(vet,out Menor, out Maior);

            Console.WriteLine("O menor número é: " + Menor);
            Console.WriteLine("O maior número é: " + Maior);

            Console.ReadLine();


        }
    }
}
