using System;

namespace Pitag

{ class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Witaj z poteznie skomplikowanym programie do kwantowych obliczen matematycznych");

            Console.WriteLine("Podaj szerokosc prostokata: ");
            double szerokosc = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc prostokata: ");
            double wysokosc = double.Parse(Console.ReadLine());

            Console.WriteLine("Przekatna prostokata wynosi: " + PrzekatnaProstokata(szerokosc, wysokosc));
        }

        static double PrzekatnaProstokata(double szerokosc, double wysokosc)
        {
            return Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(wysokosc, 2));
        }
    }
}