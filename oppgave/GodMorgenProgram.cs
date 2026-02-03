/* C# Basic Oppgave 2: Customisert God Morgen program
    I denne oppgaven skal dere designe og implementere et program som returnerer en tilpasset melding (hilsen) 
    tilbake til brukeren, basert på ett eller flere parametere. */


/* - Be brukeren skrive inn Navn
   - navnet blir lest
   - Hent nåværende tidpunkt og finn ut hvilken del av dagen det er (morgen, ettermiddag eller kveld)
   - velg riktig hilsen og skriv den ut til brukeren
*/

using System;
using System.Collections.Generic;

class GodMorgen{

    static void Main(string[] args){

        Console.Write("Navn: ");
        string navn = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(navn)){

            navn = "person";
        }

        DateTime nå = DateTime.Now;
        int time = nå.Hour;

        //Tabell for hilsen
        Dictionary<string, string> hilsner = new Dictionary<string, string>()
        {
            {"morgen", "God Morgen"},
            {"ettermiddag", "God Ettermiddag"},
            {"kveld", "God Kveld"}
        };
        
        string tidspunktPåDagen;

        if (time >= 6 && time < 12){
            tidspunktPåDagen = "morgen";
        }
        else if (time >= 12 && time < 18){
            tidspunktPåDagen = "ettermiddag";
        }
        else{
            tidspunktPåDagen = "kveld";
        }

        Console.WriteLine($"{hilsner[tidspunktPåDagen]}, {navn}!");

    }
}


