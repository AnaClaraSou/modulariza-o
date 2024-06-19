using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO6
{
    internal class Program
    {
        static void MultEscalar(int[,] mat,int n)
        {
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] *= n;
                }
            }
        }

        static void ImprimirMatriz(int[,]mat)
        {
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    Console.Write(mat[linha,coluna] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] A = new int[2,2];
            int n;

            Console.WriteLine("Preencha a matriz");

            for (int linha = 0; linha < A.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < A.GetLength(1); coluna++)
                {
                    Console.Write($"Preencha [{linha},{coluna}]:");
                    A[linha,coluna] = int.Parse(Console.ReadLine());
                }
               
            }
           
            Console.WriteLine("Matriz Original");
            ImprimirMatriz(A);

            Console.WriteLine("Informe o número para multiplicar a matriz");
            n = int.Parse(Console.ReadLine());

            MultEscalar(A, n);

            Console.WriteLine("\nMatriz Alterada" + " " + n + ":");
            ImprimirMatriz(A);

            Console.ReadLine();
        }
    }
}
