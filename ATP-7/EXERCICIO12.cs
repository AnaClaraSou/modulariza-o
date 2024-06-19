using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EXERCICIO12
{
    internal class Program
    {
        static int K(int[,] mat)
        {
            int k = int.MinValue;

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    if (mat[linha, coluna] > k)
                    {
                        k = mat[linha, coluna];
                    }
                }
            }
            return k;
        }

        static int Lin(int[,] mat)
        {
            int k = K(mat); // Encontra o maior elemento da matriz
            int lin = 0;

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    if (mat[linha, coluna] == k)
                    {
                        lin = linha;
                        return lin; // Retorna a primeira linha onde o maior elemento é encontrado
                    }
                }
            }
            return lin;
        }

        static int Col(int[,] mat)
        {
            int k = K(mat); // Encontra o maior elemento da matriz
            int col = 0;

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    if (mat[linha, coluna] == k)
                    {
                        col = coluna;
                        return col; // Retorna a primeira coluna onde o maior elemento é encontrado
                    }
                }
            }
            return col;
        }
        static void ImprimirMatriz(int[,] mat)
        {
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine(); 
            }
        }
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];

            Console.WriteLine("Preencha a matriz");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    Console.Write($"Preencha [{linha},{coluna}]:");
                    mat[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz:");
            ImprimirMatriz(mat);
            int resulK = K(mat);

            Console.WriteLine($"O maior elemento da matriz é: {resulK}");

            int resulLin = Lin(mat);
            Console.WriteLine($"A linha do maior elemento da matriz é: {resulLin}");

            int resulCol = Col(mat);
            Console.WriteLine($"A coluna do maior elemento da matriz é: {resulCol}");

            Console.ReadLine();
        }
    }
}
