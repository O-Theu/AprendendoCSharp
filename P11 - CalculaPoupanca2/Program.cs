using System;
class Program
{
    static void Main(string[] args)
    {
        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
        }

        Console.WriteLine(investimento);
    }
}
