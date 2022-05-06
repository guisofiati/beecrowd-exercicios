using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double area, raio;

        raio = double.Parse(Console.ReadLine(), CI);

        area = Math.Pow(raio, 2) * 3.14159;

        Console.WriteLine("A=" + area.ToString("F4", CI));
    }
}