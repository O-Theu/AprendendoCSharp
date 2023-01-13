using System;

class Program
{
    static void Main(string[] args)
    {
        for (int linhas = 0; linhas <10; linhas++)
        {
            for (int colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");

                if (colunas >= linhas) break; // ou colunas < linhas na condição de parada do for
            }
            Console.WriteLine();
        }
    }
}