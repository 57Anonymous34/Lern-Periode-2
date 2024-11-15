using System;

class EssenKaufenSpiel
{
    static void Main(string[] args)
    {
        double geld = 20.0; 
        bool spielen = true;

        Console.WriteLine("Willkommen beim Essen-Kaufen-Spiel!");
        Console.WriteLine("Du startest mit 20 Münzen. Kaufe Essen oder verdiene mehr Geld, um noch mehr kaufen zu können!");
        Console.WriteLine("------------------------------------------------------------------------------------");

        while (spielen)
        {
            Console.WriteLine($"Du hast {geld:F2} Münzen.");
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("1. Essen kaufen");
            Console.WriteLine("2. Arbeiten (verdiene Geld)");
            Console.WriteLine("3. Inventar anzeigen");
            Console.WriteLine("4. Spiel beenden");
            Console.Write("Wähle eine Option (1-4): ");

            string wahl = Console.ReadLine();

            switch (wahl)
            {
                case "1":
                    geld = EssenKaufen(geld);
                    break;
                case "2":
                    geld = Arbeiten(geld);
                    break;
                case "3":
                    ZeigeInventar();
                    break;
                case "4":
                    spielen = false;
                    Console.WriteLine("Danke fürs Spielen! Bis bald.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Option zwischen 1 und 4.");
                    break;
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }

    static double EssenKaufen(double geld)
    {
        string[] essen = { "Apfel", "Banane", "Pizza", "Burger", "Sushi" };
        double[] preise = { 2.0, 3.5, 8.0, 5.0, 10.0 };

        Console.WriteLine("Willkommen im Laden! Hier ist, was du kaufen kannst:");
        for (int i = 0; i < essen.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {essen[i]} - {preise[i]:F2} Münzen");
        }
        Console.WriteLine("6. Zurück");

        Console.Write("Wähle ein Essen (1-6): ");
        string auswahl = Console.ReadLine();

        if (int.TryParse(auswahl, out int index) && index >= 1 && index <= essen.Length)
        {
            index -= 1; 
            if (geld >= preise[index])
            {
                geld -= preise[index];
                HinzufuegenZumInventar(essen[index]);
                Console.WriteLine($"Du hast {essen[index]} gekauft! Du hast noch {geld:F2} Münzen.");
            }
            else
            {
                Console.WriteLine("Du hast nicht genug Geld, um das zu kaufen!");
            }
        }
        else if (auswahl == "6")
        {
            Console.WriteLine("Du verlässt den Laden.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe.");
        }

        return geld;
    }

    static double Arbeiten(double geld)
    {
        Random random = new Random();
        double verdienst = random.Next(5, 16); 
        geld += verdienst;
        Console.WriteLine($"Du hast gearbeitet und {verdienst:F2} Münzen verdient! Du hast jetzt {geld:F2} Münzen.");
        return geld;
    }

    static System.Collections.Generic.List<string> inventar = new System.Collections.Generic.List<string>();

    static void HinzufuegenZumInventar(string essen)
    {
        inventar.Add(essen);
    }

    static void ZeigeInventar()
    {
        Console.WriteLine("Dein Inventar:");
        if (inventar.Count > 0)
        {
            foreach (var item in inventar)
            {
                Console.WriteLine($"- {item}");
            }
        }
        else
        {
            Console.WriteLine("Dein Inventar ist leer.");
        }
    }
}
