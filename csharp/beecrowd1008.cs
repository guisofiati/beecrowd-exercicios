using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int codigo, horasTrabalhadas;
        double valorPorHora, salario;

        codigo = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        valorPorHora = double.Parse(Console.ReadLine(), CI);

        salario = horasTrabalhadas * valorPorHora;

        Console.WriteLine("NUMBER = " + codigo);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CI));
    }
}