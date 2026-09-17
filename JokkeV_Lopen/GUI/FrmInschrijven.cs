using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JokkeV_Lopen
{
    public partial class FrmInschrijven : Form
    {
        public FrmInschrijven()
        {
            InitializeComponent();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            //terug naar startscherm
            Hide();
        }

        private void BtnBevestigen_Click(object sender, EventArgs e)
        {
            //functie oproepen om inputs te valideren
            if (Valideer())
            {
                int afstand = int.Parse(CmbAfstand.SelectedItem.ToString().Replace(" km", ""));
                bool betaald = rbNbetaald.Checked;

                Program.inschrijven(txtnaam.Text, afstand, betaald);
                //begeleiden
                MessageBox.Show("Inschrijving toegevoegd!");
                this.Close();
            }
        }
        /// <summary>
        /// Valideren van inputs
        /// </summary>
        /// <returns></returns>
            public bool Valideer()
        {
            if (string.IsNullOrWhiteSpace(txtnaam.Text))
            {
                //foutmelding
                MessageBox.Show("Vul je naam in!");
                return false;
            }

            if (CmbAfstand.SelectedIndex == -1)
            {
                //foutmelding
                MessageBox.Show("Kies een afstand aub");
                return false;
            }
            //checken of er selectie is gemaakt
            if (!rbNbetaald.Checked && !rbbetaald.Checked)
            {
                MessageBox.Show("Geef aan of je betaald hebt of ni");
                return false;
            }

            return true;
        }
    }
    }
