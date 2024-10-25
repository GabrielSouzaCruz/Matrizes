using System;

class Matrizes
{ 
    public static void leia(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Digite para [{i}, {j}]");
                mat[i, j] = int.Parse(Console.ReadLine());
            }//fim j
        }//fim i

    }//fim leia
    public static void gera(int[,] mat)
    {
        Random random = new Random();
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mat[i, j] = random.Next(1, 100);
            }
        }
    }

    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mat[i, j], 3} |");
            }//fim j
            Console.WriteLine();//Pular a Linha da Matriz
        }//fim i
    }//fim mostra

    static void Main()
    {
        int linhas, cols;

        Console.WriteLine("**** Matrizes ****");

        Console.WriteLine("Qtde de Linhas e Colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];

        Console.WriteLine("Dados para a Matriz: ");
        gera(matriz);

        Console.WriteLine("Dados da Matriz: ");
        mostra(matriz);
        
        Console.ReadKey();

    }
}


