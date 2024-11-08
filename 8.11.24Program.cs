




string eingabe;
string eingabe1;
int punktzahl = 0;
Console.WriteLine("Wilkommen bei Schere Stein Papier");
Console.WriteLine("Willst du die Regeln wissen [y, n]?");

while (true)
{
    eingabe = Console.ReadLine();

    if (eingabe == "y")
    {
        Console.WriteLine("Die Regeln lauten:");
        Console.WriteLine("1. Der Benutzer hat eine Auswahl von Schere, Stein und Papier");
        Console.WriteLine("2. Für jede gewonne Runde gibt es einen Punkt");
        Console.WriteLine("3. Für jede verlorene Runde wird ein Punkt abgezogen");
        Console.WriteLine("4. Unentschieden wird wiederholt");
        Console.WriteLine("5. Stein gewinnt gegen Schere");
        Console.WriteLine("6. Schere gewinnt gegen Papier");
        Console.WriteLine("7. Papier gewinnt gegen Stein");
        break;
    }
    else if (eingabe == "n")
    {
        Console.WriteLine("Alles klar, zeig dein Können!");
        break;
    }
    else
    {
        Console.WriteLine("Gebe [y, n] ein");
    }
}

Console.WriteLine("--------------------------------------------");

while (true)
{
    Random random = new Random();
    int zufallszahl = random.Next(1, 4);

    string zahl;
    int zahl1 = 0;

    Console.WriteLine("Gebe entweder [1] für Schere, [2] für Stein oder [3] für Papier ein");

    while (true)
    {
        zahl = Console.ReadLine();

        if (int.TryParse(zahl, out zahl1))
        {
           switch (zahl1)
            {
                case 1:
                    Console.WriteLine("Du Schere");
                    break;

                case 2:
                    Console.WriteLine("Du: Stein");
                    break;

                    case 3:
                    Console.WriteLine("Du: Papier");
                    break;

                    default:
                    Console.WriteLine("Deine Zahl muss zwischen 1 und 3 liegen");


                    continue;

            }
            break;
        }

            
            
            

    }

    Console.WriteLine("vs");

    switch (zufallszahl)
    {
        case 1: Console.WriteLine("Gegner: Schere");
            break;


        case 2: Console.WriteLine("Gegner: Stein");
            break;

        case 3: Console.WriteLine("Gegner: Papier");
            break;
    }




    if (zahl1 == zufallszahl)
    {
        Console.WriteLine("Knappes Duell, aber unentschieden");
    }
    else if ((zahl1 == 1 && zufallszahl == 3) || // Schere schlägt Papier
             (zahl1 == 2 && zufallszahl == 1) || // Stein schlägt Schere
             (zahl1 == 3 && zufallszahl == 2))   // Papier schlägt Stein
    {
        punktzahl += 1;
        Console.WriteLine("Du hast gewonnen");
    }
    else
    {
        punktzahl -= 1;
        Console.WriteLine("Du hast verloren");
    }


    Console.WriteLine("Drücke [e] um erneut zu spielen oder [q] zum Beenden");
    eingabe1 = Console.ReadLine();

    if (eingabe1 == "q")
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Endgültige Punktzahl: {punktzahl}");
        Console.WriteLine("--------------------------------------------");
        break; // Beendet das Spiel
    }
    else if (eingabe1 != "e")
    {
        Console.WriteLine("Ungültige Eingabe. Drücke [e] zum Weiterspielen oder [q] zum Beenden.");
    }
} 