using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        double A, B, C, MEDIA;

        A = double.Parse(Console.ReadLine(), CI);
        B = double.Parse(Console.ReadLine(), CI);
        C = double.Parse(Console.ReadLine(), CI);

        MEDIA = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CI));
    }
}