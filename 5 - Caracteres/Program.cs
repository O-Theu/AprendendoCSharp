using System;
class Program
{
    static void Main(string[] args)
    {
        char letra = (char)79; // Converter int em char
        string nome = "Mateus"; // Cadeia de caracteres

        string frase = "meu nome é: ";

        string cursos = @"Cursos disponiveis: 
    - Go
    - C#
    - Python
    ";

        Console.WriteLine(cursos);
        Console.WriteLine(letra + " " + frase + " " + nome);
    }
}
