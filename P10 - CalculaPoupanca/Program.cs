﻿using System;
class Program
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 1;

        //rendimento de 0.5% (0.005) ao mês
        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            mes++;
        }

        Console.WriteLine(investimento);
    }
}
