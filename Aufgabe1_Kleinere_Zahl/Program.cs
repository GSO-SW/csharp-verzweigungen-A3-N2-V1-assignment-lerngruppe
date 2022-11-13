// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 1 - Aufgabe 1
/// Die kleinere Zahl
/// </summary>


Aufgabe_1.Aufgabe1();

public static class Aufgabe_1
{
    public static void Aufgabe1()
    {

        //Diese Zeile mit Ihrem Quellcode ersetzen

        double z1,z2;
        string erg;
        Console.WriteLine("Die kleinere Zahl\n");
        
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        double.TryParse(Console.ReadLine(), out z1); 

        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        double.TryParse(Console.ReadLine(), out z2);

        Console.WriteLine("------------------");

        if (z1 == z2) erg = "Gleicher Wert";
        else if (z1 < z2) erg = z1.ToString();
        else erg =z2.ToString();

        Console.WriteLine($"Die kleinere Zahl ist: {erg}");


    }
}