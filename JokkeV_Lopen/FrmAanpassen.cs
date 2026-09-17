using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokkeV_Lopen
{
    public partial class FrmAanpassen : Form
    {
        public FrmAanpassen()
        {
            InitializeComponent();
        }
        //items toevoegen aan lijst
        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
            CmbAanpassen.Items.AddRange(Program.Deelnemers().ToArray());
        }
        /// <summary>
        /// laden van gegevens van de geselecteerde deelnemer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbAanpassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CmbAanpassen.SelectedIndex;
            if (index == -1) return;

            Deelnemer d = Program.GeefDeelnemer(index);

            txtnaam.Text = d._naam;
            CmbAfstand.SelectedItem = d._afstand + " km";
            rbbetaald.Checked = d._betaald;
            rbNbetaald.Checked = !d._betaald;
        }

      
        /// <summary>
        ///aanpassen van de gegevens van een gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAanpasse_Click(object sender, EventArgs e)
        {
            //checken of persoon geselcteerd is
            int index = CmbAanpassen.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Kies eerst een person");
                return;
            }

            int afstand = int.Parse(CmbAfstand.SelectedItem.ToString().Replace(" km", ""));
            bool betaald = rbbetaald.Checked;
            //aanpassen
            Program.aanpassen(index, txtnaam.Text, afstand, betaald);
            //begeleiden
            MessageBox.Show("Gegevens aangepast!");
            this.Close();
        }
        /// <summary>
        /// Verwijdert de geselecteerde deelnemer uit de lijst van deelnemers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            int index = CmbAanpassen.SelectedIndex;
           //checken of er selectie is gemaakt
            if (index == -1)
            {
                MessageBox.Show("Kies eerst een persoon.");
                return;
            }
            //verwijderen
            Program.verwijderen(index);
            //begeleiden
            MessageBox.Show("Deelnemer verwijderd!");
            this.Close();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            //form sluiten
            this.Close();
        }

        private void btnterug_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
