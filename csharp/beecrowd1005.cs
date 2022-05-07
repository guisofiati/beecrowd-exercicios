using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        double A, B, MEDIA;

        A = double.Parse(Console.ReadLine(), CI);
        B = double.Parse(Console.ReadLine(), CI);

        MEDIA = (A * 3.5 + B * 7.5) / 11.0;

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CI));
    }
}