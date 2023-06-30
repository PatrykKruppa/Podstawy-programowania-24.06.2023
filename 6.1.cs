using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;

        for (int wiersz = 0; wiersz < 10; wiersz++)
        {
            if (wiersz % 2 == 0)
            {
                for (int kolumna = 0; kolumna < 10; kolumna++)
                {
                    tablica[wiersz, kolumna] = liczba;
                    liczba++;
                }
            }
            else
            {
                for (int kolumna = 9; kolumna >= 0; kolumna--)
                {
                    tablica[wiersz, kolumna] = liczba;
                    liczba++;
                }
            }
        }

  
        for (int wiersz = 0; wiersz < 10; wiersz++)
        {
            for (int kolumna = 0; kolumna < 10; kolumna++)
            {
                Console.Write(tablica[wiersz, kolumna] + "\t");
            }
            Console.WriteLine();
        }
    }
}