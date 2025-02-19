﻿using System.Linq.Expressions;

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

        // Dit is het hoofdprogramma
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
            string uitkomst = Berekenen(waarde1, waarde2, bewerking);
            Console.WriteLine("De uitkomst van " + waarde1 + " " + bewerking + " " + waarde2 + " = " + uitkomst);
         }

        private static string Berekenen(string w1, string w2, string bewerk)
        {
            string resultaat = "";
            switch (bewerk)
            {
                case "+":
                    // code block
                    int uitkomst = Int32.Parse(w1) + Int32.Parse(w2);
                    resultaat = uitkomst.ToString();
                    break;
                default:
                    // Geef vawd
                    resultaat = "oei";
                    break;
            }
            return resultaat;

        }

    }
}