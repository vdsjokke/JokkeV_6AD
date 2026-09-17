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
    public partial class FrmStartLopen : Form
    {
        public FrmStartLopen()
        {
            InitializeComponent();
        }

        private void FrmStartLopen_Load(object sender, EventArgs e)
        {

        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            //afsluiten
            Close();
        }

        private void BtnInschrijven_Click(object sender, EventArgs e)
        {

            //form aanmaken
            FrmInschrijven Frminschrijvn = new FrmInschrijven();

            //form hiden
            this.Hide();

            //form tonen
            Frminschrijvn.ShowDialog();

            //FrmStart terug tonen na sluiten
            this.Show();
        }

        private void BtnBewerken_Click(object sender, EventArgs e)
        {
            //form aanmaken
            FrmAanpassen Frmaan = new FrmAanpassen();

            //form hiden
            this.Hide();

            //form tonen
            Frmaan.ShowDialog();

            //FrmStart terug tonen na sluiten
            this.Show();
        }
    }
}
