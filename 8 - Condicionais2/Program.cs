using System;
class Program
{
    static void Main(string[] args)
    {
        int idadeJoao = 18;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18 || quantidadePessoas > 0)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
    }
}
