// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 1 - Aufgabe3
/// Reisezeit Rechner
/// </summary>


Aufgabe_3.Aufgabe3();

public static class Aufgabe_3
{
    public static void Aufgabe3()
    {
        double w1,w2;
        int ausw;
        string erg;

        Console.WriteLine("Rechner\n");
        Console.WriteLine("Geben Sie den ersten Wert ein:");
        double.TryParse(Console.ReadLine(), out w1);

        Console.WriteLine("Geben Sie den zweiten Wert ein:");
        double.TryParse(Console.ReadLine(), out w2);

        Console.WriteLine("1 Addition");
        Console.WriteLine("2 Subraktion");
        Console.WriteLine("3 Multiplikation");
        Console.WriteLine("4 Divison");
        Console.WriteLine("5 Potenz");
        Console.WriteLine("Wählen Sie einen Operator:");
        int.TryParse(Console.ReadLine(), out ausw);


        switch (ausw)
        {
            case 1:
                erg =(w1 + w2).ToString();
                break;

            case 2:
                erg = (w1 - w2).ToString();
                break;
            case 3:
                erg = (w1 * w2).ToString();
                break;
            case 4:
                erg = (w1 / w2).ToString();
                break;
            case 5:
                erg = Math.Pow(w1, w2).ToString();
                break;
            default:
                erg = "Error";
                break;
        }

        Console.WriteLine("------------------");
        Console.WriteLine($"Ihr Ergebnis ist: {erg}");

    }
}