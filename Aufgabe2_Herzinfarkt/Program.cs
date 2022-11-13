// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 1 - Aufgabe 2
/// Herzinfarkt-Risiko-Test
/// </summary>


Aufgabe_2.Aufgabe2();

public static class Aufgabe_2
{
    public static void Aufgabe2()
    {

        Console.WriteLine("Herzinfarkt-Risiko-Test\n");
        Console.WriteLine("Sind Sie übergewichtig?(true/false):");
        bool frage_1;
        bool.TryParse(Console.ReadLine(), out frage_1);
        Console.WriteLine("Haben Sie häufiger Stress?(true/false):");
        bool frage_2;
        bool.TryParse(Console.ReadLine(), out frage_2);

        int erg;

        if (frage_1 == true & frage_2 == true) erg = 62;
        else if (frage_1 == true & frage_2 == false) erg = 18;
        else if (frage_1 == false & frage_2 == true) erg = 15;
        else erg = 5;

        Console.WriteLine("------------------");

        Console.WriteLine($"Ihr Risiko für einen Herzinfarkt liegt bei: {erg}%");

    }
}