using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokkeV_Lopen
{
    internal class Deelnemer
    {
        //jokke van der straeten
        //11/09/2026
        // project lopen

        //velden + properties
        public String _naam { get; set; } = "";
        public int _afstand { get; set; } = 0;
        public bool _betaald { get; set; } = false;
        //functies
        //toont alles gegevens van de deelnemer
        public string AlleGegevens()
        {
            string antwoord = "";
            antwoord = $"Naam: {_naam}\nAfstand: {_afstand}\n";
            if (_betaald)
            {
                antwoord += "\nDeelnemer heeft betaald.";
            }
            else
            {
                antwoord += "\nDeelnemer heeft nog niet betaald.";
            }
            return antwoord;
        }
        //toont afstand en of de deelnemer betaald heeft
        public string AfstEnBetaald()
        {
            string antwoord = "";
            
            antwoord = $"De afstand die uw loopt is: {_afstand}\n";
            if (_betaald)
            {
                antwoord += "\n, uw heeft betaald.";
            }
            else
            {
                antwoord += "\n, uw heeft nog niet betaald.";
            }
            return antwoord;
        }
        //Constructors
        //default constructor
        public Deelnemer(string ontvnaam, int ontvafstand, bool ontvbetaald)
        {
            _naam = ontvnaam;
            _afstand = ontvafstand;
            _betaald = ontvbetaald;
        }
    }
}
