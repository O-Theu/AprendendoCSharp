using System;
class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3008.12;

        int salarioInteiro;
        salarioInteiro = (int)salario; //Conversão de double para int

        float altura;
        altura = 1.71f; // float

        Console.WriteLine(salario + " " + salarioInteiro + " " + altura);
    }
}
