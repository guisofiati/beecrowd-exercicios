using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        string nome;
        double salario, totalVendas, totalReceber;

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CI);
        totalVendas = double.Parse(Console.ReadLine(), CI);

        totalReceber = salario + totalVendas * 0.15;

        Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CI));
    }
}