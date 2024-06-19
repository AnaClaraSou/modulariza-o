using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int[] EncontrarIntersecao(int[] vet1, int[] vet2)
    {
        int[] intersecao = new int[10];
        for (int i = 0; i < intersecao.Length; i++)
        {
            intersecao[i] = int.MinValue; 
        }

        int cont = 0;

        for (int i = 0; i < vet1.Length; i++)
        {
            for (int j = 0; j < vet2.Length; j++)
            {
                if (vet1[i] == vet2[j] && !Contem(intersecao, vet1[i], cont))
                {
                    intersecao[cont] = vet1[i];
                    cont++;
                    break;
                }
            }
        }

        return intersecao;
    }

    static bool Contem(int[] vet, int val, int tam)
    {
        for (int i = 0; i < tam; i++)
        {
            if (vet[i] == val)
            {
                return true;
            }
        }
        return false;
    }

    static void LerVet(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"Informe a matrícula do aluno {i + 1}: ");
            vet[i] = int.Parse(Console.ReadLine());
        }
    }

    static void Main(string[] args)
    {
        int[] ATP = new int[10];
        int[] DIW = new int[10];

        Console.WriteLine("Informe as matrículas dos alunos de ATP:");
        LerVet(ATP);

        Console.WriteLine("Informe as matrículas dos alunos de DIW:");
        LerVet(DIW);

        int[] intersecao = EncontrarIntersecao(ATP, DIW);

        Console.WriteLine("Alunos matriculados nas duas disciplinas:");
        bool T = false;
        foreach (int matricula in intersecao)
        {
            if (matricula != int.MinValue) 
            {
                Console.WriteLine(matricula);
                T = true;
            }
        }

        if (!T)
        {
            Console.WriteLine("Nenhum aluno está matriculado nas duas disciplinas.");
        }
        Console.ReadLine();
    }

}
    

   

