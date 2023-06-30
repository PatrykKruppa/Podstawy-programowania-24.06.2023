using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double x1 = 3.5;
            double y1 = 4.5;
            double x2 = 5.5;
            double y2 = 8.5;
            double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + dlugosc);
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dlugosc = Math.Sqrt(dx * dx + dy * dy);
            return dlugosc;
        }
    }
}