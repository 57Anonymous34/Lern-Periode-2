using System;

class Taschenrechner
{
    static void Main(string[] args)
    {
        bool weiter = true;

        Console.WriteLine("Willkommen zum Taschenrechner!");
        Console.WriteLine("Dieser Taschenrechner unterstützt die folgenden Operationen:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraktion (-)");
        Console.WriteLine("3. Multiplikation (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("5. Potenz (a^b)");
        Console.WriteLine("6. Wurzel (√a)");

        while (weiter)
        {
            try
            {
                Console.WriteLine("\nBitte wählen Sie eine Operation aus (1-6):");
                int auswahl = int.Parse(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraktion();
                        break;
                    case 3:
                        Multiplikation();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Potenz();
                        break;
                    case 6:
                        Wurzel();
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Zahl zwischen 1 und 6.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            }

            Console.WriteLine("\nMöchten Sie eine weitere Berechnung durchführen? (j/n)");
            string antwort = Console.ReadLine();
            if (antwort.ToLower() != "j")
            {
                weiter = false;
                Console.WriteLine("Vielen Dank, dass Sie den Taschenrechner genutzt haben!");
            }
        }
    }

    static void Addition()
    {
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ergebnis: {a} + {b} = {a + b}");
    }

    static void Subtraktion()
    {
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ergebnis: {a} - {b} = {a - b}");
    }

    static void Multiplikation()
    {
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ergebnis: {a} * {b} = {a * b}");
    }

    static void Division()
    {
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        double b = double.Parse(Console.ReadLine());
        if (b != 0)
        {
            Console.WriteLine($"Ergebnis: {a} / {b} = {a / b}");
        }
        else
        {
            Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt!");
        }
    }

    static void Potenz()
    {
        Console.WriteLine("Geben Sie die Basis ein:");
        double basis = double.Parse(Console.ReadLine());
        Console.WriteLine("Geben Sie den Exponenten ein:");
        double exponent = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ergebnis: {basis}^{exponent} = {Math.Pow(basis, exponent)}");
    }

    static void Wurzel()
    {
        Console.WriteLine("Geben Sie die Zahl ein, aus der die Wurzel gezogen werden soll:");
        double zahl = double.Parse(Console.ReadLine());
        if (zahl >= 0)
        {
            Console.WriteLine($"Ergebnis: √{zahl} = {Math.Sqrt(zahl)}");
        }
        else
        {
            Console.WriteLine("Fehler: Wurzeln von negativen Zahlen sind im Bereich der reellen Zahlen nicht definiert.");
        }
    }
}
