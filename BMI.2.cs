using System;
using System.Collections.Generic;

class Kalorienrechner
{
    static void Main()
    {
        // Codes für die verschiedenen Farben (Ansi)
        const string RESET = "\u001b[0m";
        const string RED = "\u001b[31m";
        const string GREEN = "\u001b[32m";

        // Namenabfrage
        string name;
        Console.WriteLine("Wilkommen beim Kalorienrechner!");
        Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
        name = Console.ReadLine();

        // Informationenabfrage
        double gewicht = AbfrageDouble("Geben Sie Ihr Gewicht ein (in kg, zwischen 1 und 250):", 1, 250);
        int grösse = AbfrageInt("Geben Sie Ihre Größe ein (in cm, zwischen 26 und 219):", 26, 219);
        int alter = AbfrageInt("Geben Sie Ihr Alter ein (zwischen 1 und 99):", 1, 99);
        double aktivitätsfaktor = AbfrageAktivitaetsfaktor();
        int zielKalorien = AbfrageZiel(out bool willZunehmen);

        double kalorienbedarf = ((10 * gewicht) + (6.25 * grösse) - (5 * alter)) * aktivitätsfaktor + zielKalorien;
        Console.WriteLine($"Dein täglicher Kalorienbedarf beträgt: {kalorienbedarf} kcal");
        Console.WriteLine("-----------------------------------------------------------------------------");

        // Sammlung der daten
        List<double> gewichtsdaten = new List<double>();
        List<double> kaloriendaten = new List<double>();

        for (int tag = 1; tag <= 7; tag++)
        {
            Console.WriteLine($"Tag {tag}:");
            double tagGewicht = AbfrageDouble("Geben Sie Ihr aktuelles Gewicht ein (in kg):", 1, 250);
            double tagKalorien = AbfrageDouble("Geben Sie Ihre tägliche Kalorienzufuhr ein (in kcal):", 500, 7000);

            gewichtsdaten.Add(tagGewicht);
            kaloriendaten.Add(tagKalorien);
        }


        bool zielErreicht = (willZunehmen && gewichtsdaten[6] > gewichtsdaten[0]) || (!willZunehmen && gewichtsdaten[6] <= gewichtsdaten[0]);

        if (zielErreicht)
        {
            Console.WriteLine($"{GREEN}Glückwunsch! Sie haben Ihr Ziel erreicht!{RESET}");
        }
        else
        {
            Console.WriteLine($"{RED}Leider haben Sie Ihr Ziel nicht erreicht.{RESET}");
            if (willZunehmen)
            {
                Console.WriteLine("Hier sind 3 Lebensmittel, die beim Zunehmen helfen könnten:");
                Console.WriteLine("- Nüsse");
                Console.WriteLine("- Avocados");
                Console.WriteLine("- Reis");
            }
            else
            {
                Console.WriteLine("Hier sind 3 Lebensmittel, die beim Abnehmen helfen könnten:");
                Console.WriteLine("- Gurken");
                Console.WriteLine("- Hähnchenbrust");
                Console.WriteLine("- Magerquark");
            }
        }

        // Ausgabe der Daten
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("Ihre Daten der letzten Woche:");
        Console.WriteLine("Tag | Gewicht (kg) | Kalorienzufuhr (kcal)");
        for (int i = 0; i < gewichtsdaten.Count; i++)
        {
            Console.WriteLine($"{i + 1,3} | {gewichtsdaten[i],12} | {kaloriendaten[i]}");
        }

        Console.WriteLine("Vielen Dank, dass Sie den Kalorienrechner verwendet haben!");
    }

    static double AbfrageDouble(string message, double min, double max)
    {
        double value;
        while (true)
        {
            Console.WriteLine(message);
            if (double.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine($"Ungültige Eingabe. Bitte geben Sie einen Wert zwischen {min} und {max} ein.");
        }
    }

    static int AbfrageInt(string message, int min, int max)
    {
        int value;
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine($"Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen {min} und {max} ein.");
        }
    }

    static double AbfrageAktivitaetsfaktor()
    {
        Console.WriteLine("Wie aktiv sind Sie?");
        Console.WriteLine("1. Sitzend (wenig Bewegung)");
        Console.WriteLine("2. Leicht aktiv (Sport an 1-3 Tagen)");
        Console.WriteLine("3. Moderat aktiv (Sport an 3-5 Tagen)");
        Console.WriteLine("4. Sehr aktiv (Sport an 6-7 Tagen)");
        Console.WriteLine("5. Extrem aktiv (Hochleistungssportler)");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int auswahl) && auswahl >= 1 && auswahl <= 5)
            {
                return auswahl switch
                {
                    1 => 1.2,
                    2 => 1.375,
                    3 => 1.55,
                    4 => 1.725,
                    5 => 1.9,
                    _ => 1.2
                };
            }
            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
        }
    }

    static int AbfrageZiel(out bool willZunehmen)
    {
        Console.WriteLine("Was ist Ihr Ziel?");
        Console.WriteLine("1. Abnehmen");
        Console.WriteLine("2. Gewicht halten");
        Console.WriteLine("3. Zunehmen");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int auswahl) && auswahl >= 1 && auswahl <= 3)
            {
                willZunehmen = auswahl == 3;
                return auswahl switch
                {
                    1 => -500,
                    2 => 0,
                    3 => 500,
                    _ => 0
                };
            }
            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 3.");
        }
    }
}









