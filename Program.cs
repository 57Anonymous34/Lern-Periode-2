
string gewicht;
double gewicht1;

string grösse;
double grösse1;

string alter;
int alter1;

string aktiv;
double aktiv1;

double ergebnis = 0;





Console.WriteLine("Willkommen beim Kalorienbedarf-Rechner!");




while (true)
{
    Console.WriteLine("Gebe dein Gewicht in kg ein:");
    gewicht = Console.ReadLine();

    if (double.TryParse(gewicht, out gewicht1))
    {
        if (gewicht1 > 0 && gewicht1 < 250)
        {
            break;
        }
        else
        {
            Console.WriteLine("Deine Eingabe ist ungültig. Bitte gib ein Gewicht zwischen 1 und 250 ein.");
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
    }
}






Console.WriteLine("-----------------------------------------------------------------------------");

while (true)
{
    Console.WriteLine("Gebe deine Größe in cm ein:");
    grösse = Console.ReadLine();

    if (double.TryParse(grösse, out grösse1))
    {
        if (grösse1 > 25 && grösse1 < 220)
        {
            break;
        }
        else
        {
            Console.WriteLine("Deine Eingabe ist ungültig. Bitte gib eine Größe zwischen 25 und 220 ein.");
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
    }
}






Console.WriteLine("-----------------------------------------------------------------------------");

while (true)
{
    Console.WriteLine("Gebe dein Alter in Jahren ein:");
    alter = Console.ReadLine();

    if (int.TryParse(alter, out alter1))
    {
        if (alter1 > 0 && alter1 < 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Deine Eingabe ist ungültig. Bitte gib ein Alter zwischen 0 und 100 ein.");
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
    }
}





Console.WriteLine("-----------------------------------------------------------------------------");

while (true)
{
    Console.WriteLine("Wie aktiv bist du (1, 2, 3, 4, 5):");
    Console.WriteLine("1. Sitzend (wenig Bewegung)");
    Console.WriteLine("2. Leicht aktiv (Sport an 1-3 Tagen)");
    Console.WriteLine("3. Moderat aktiv (Sport an 3-5 Tagen)");
    Console.WriteLine("4. Sehr aktiv (Sport an 6-7 Tagen)");
    Console.WriteLine("5. Extrem aktiv (Hochleistungssportler)");

    aktiv = Console.ReadLine();

    if (double.TryParse(aktiv, out aktiv1) && aktiv1 >= 1 && aktiv1 <= 5)
    {
        switch (aktiv1)
        {
            case 1:
                aktiv1 = 1.2;
                break;
            case 2:
                aktiv1 = 1.375;
                break;
            case 3:
                aktiv1 = 1.55;
                break;
            case 4:
                aktiv1 = 1.725;
                break;
            case 5:
                aktiv1 = 1.9;
                break;
        }
        break;
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 5 ein.");
    }
}





Console.WriteLine("-----------------------------------------------------------------------------");


ergebnis = ((10 * gewicht1) + (6.25 * grösse1) - (5 * alter1)) * aktiv1;

Console.WriteLine($"Dein täglicher Kalorienbedarf beträgt: {ergebnis:F2} kcal");
