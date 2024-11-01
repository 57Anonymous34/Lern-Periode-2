



using System.ComponentModel.Design;

string kontieingabe;
int guesses = 0;

Console.WriteLine("Wilkommen beim Quiz-Spiel");




    Console.WriteLine("Wie viele Kontinenten gibt es? ");
    int[] kontiauswahl = { 4, 5, 6, 7, };
    


    for (int i = 0; i < kontiauswahl.Length; i++)
    {
        Console.WriteLine($"Option{i + 1}:{kontiauswahl[i]}  ");
    }

while (true)
{
    Console.WriteLine("Geben sie ihr Antwort ein: ");
    kontieingabe = Console.ReadLine();
    guesses += 1;

    if (kontieingabe == "7")
    {

        Console.WriteLine("RICHTIG!");
        Console.WriteLine("Du hast " + guesses + " Versuche gebraucht");

        if (guesses <= 2)
        {
            Console.WriteLine("Wow, Du bist sehr schlau");
        }
        else if(guesses >= 2)
        {
            Console.WriteLine("Bruder du brauchts Hilfe");
        }
            break;
        
    }

    else if (kontieingabe == "4" || kontieingabe == "5" || kontieingabe == "6")
    {
        Console.WriteLine("Falsche Eingabe versuche es nochmal.");



    }
    else
    {
        Console.WriteLine("Ungültige Eingabe");
    }

}
Console.WriteLine("---------------------------------------------");
string  eingabeR;

Console.WriteLine("Löse diese Matherechnung: 20 * 20");
while (true)
{
    eingabeR = Console.ReadLine();

    if (eingabeR == "400")
    {

        Console.WriteLine("Richtig, mach weiter so.");
        break;
    }
    else if (eingabeR != "400")
    {
        Console.WriteLine("Falsch! Versuche nochmal");
    }
    
    
}

Console.WriteLine("---------------------------------------------");
