using System;

class Program
{
    static void Main()
    {
        int rozmiar;

        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
        } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0);

        int[,] tablica = new int[rozmiar, rozmiar];


        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i * rozmiar) + j + 1;
                }
            }
            else
            {
                for (int j = rozmiar - 1; j >= 0; j--)
                {
                    tablica[i, j] = (i * rozmiar) + (rozmiar - j);
                }
            }
        }


        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
