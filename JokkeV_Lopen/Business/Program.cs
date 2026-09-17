using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokkeV_Lopen
{
    internal static class Program
    {
        //jokke van der straeten
        //11/09/2026
        //6AD

        //velden
        static List<Deelnemer> _deelnemers = new List<Deelnemer>();

        //functies
        //inschrijven van deelnemer
        static public void inschrijven(string ontvnaam, int ontvafst, bool ontvbetaald)
        {
            Deelnemer nieuw = new Deelnemer(ontvnaam, ontvafst, ontvbetaald);
            _deelnemers.Add(nieuw);
        }
        //aanpassen van deelnemer
        static public void aanpassen(int ontvindex, string ontvnaam, int ontvafstand, bool ontvbetaald)
        {
            _deelnemers[ontvindex]._naam = ontvnaam;
            _deelnemers[ontvindex]._afstand = ontvafstand;
            _deelnemers[ontvindex]._betaald = ontvbetaald;
        }
        //verwijderen van deelnemer
        static public void verwijderen(int ontvindex)
        {
            _deelnemers.RemoveAt(ontvindex);
        }
        //toevoegen aan list
        static public List<string> Deelnemers()
        {
            List<string> namen = new List<string>();
            foreach (Deelnemer d in _deelnemers)
            {
                namen.Add(d._naam);
            }
            return namen;
        }
        //geef naam van deelnemer
        static public Deelnemer GeefDeelnemer(int index)
        {
            return _deelnemers[index];
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStartLopen());
        }
    }
}