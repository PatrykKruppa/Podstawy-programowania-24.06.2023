using System;

//Napisz funkcję, której zadaniem będzie formatowanie czasu na ekranie
//w formacie HH::MM:SS (godziny, minuty, sekundy, 2 znaki na każdą pozycję).
// Funkcja powinna przyjmować jako argument liczbę całkowitą wyrażacącą
// czas jaki upłynął od godzinny 00:00:00 w samych sekundach np.: dla 3
//32 wypisze 00:05:32.

class Program
{
    static void Main()
    {
        int czas = 332;
        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine(sformatowanyCzas);
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("D2");
        string sMinuty = minuty.ToString("D2");
        string sSekundy = sekundy.ToString("D2");

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}