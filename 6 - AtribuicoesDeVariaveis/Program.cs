using System;
class Program
{
    static void Main(string[] args)
    {
        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine(idade + ", " + idadeAna);
    }
}
