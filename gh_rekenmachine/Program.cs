using System.Linq.Expressions;

/*
Van:    Jeroen Wilmes
        Februari 2025

V1.0:   Rechttoerechtaan (zie pdf in de map)
V1.1:   Rekenen in een functie opgenomen
 */

namespace RekenMachine
{
    class RekenMachine
    {
        // Rudimentaire rekenmachine die de basisbewerkingen +-/* kan uitvoeren
        // Opdracht 15 MBOGodigital
        // Het gebruik van if is niet toegestaan

        // 1: hoe moet deze rekenmachine gaan werken (ontwerp) en welke technieken worden gebruikt
        // 2: zoek de te gebruiken technieken op zodat je weet hoe ze moeten werken
        // 3: begin met programmeren en debuggen
        // 4: maak een exe
        static void Main(string[] args)
        {
            // Voer het eerste getal in
            Console.WriteLine("Wat is het eerste getal:");
            string waarde1 = Console.ReadLine();
            // Voer het tweede getal in
            Console.WriteLine("Wat is het tweede getal:");
            string waarde2 = Console.ReadLine();
            // Voer de bewerking in
            Console.WriteLine("Wat is de bewerking:");
            string bewerking = Console.ReadLine();
            switch (bewerking)
            {
                case "+":
                    // code block
                    int Uitkomst = Int32.Parse(waarde1) + Int32.Parse(waarde2);
                    Console.WriteLine("de uitkomst is: " + Uitkomst.ToString());
                    break;
                default:
                    // Geef vawd
                    Console.WriteLine("öei");
                    break;
            }
        }

    }
}