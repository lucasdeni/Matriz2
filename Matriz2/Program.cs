using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas: "); // Definir o número de linhas
            int n = int.Parse(Console.ReadLine()); 
            Console.Write("Número de colunas: "); // Definir o número de colunas
            int m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            Console.WriteLine();
            for (int i = 0; i < n; i++) // Colocar os valores dentro da matriz
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Valor [" + i + ", " + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatriz [" + n + ", " + m + "]"); // Imprime a matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
            Console.Write("\nNúmero para procura: "); // Procurar número na matriz
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Se achar o valor ele imprimirá os valores ao redor
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição [" + i + ", " + j + "]: ");
                        if ((j - 1) >= 0) Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        if ((j + 1) < m) Console.WriteLine("Direita: " + mat[i, j + 1]);
                        if ((i - 1) >= 0) Console.WriteLine("Acima: " + mat[i - 1, j]);
                        if ((i + 1) < n) Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
