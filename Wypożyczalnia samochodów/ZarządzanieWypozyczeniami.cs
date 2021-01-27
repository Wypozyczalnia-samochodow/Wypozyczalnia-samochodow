using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
--
namespace Wypozyczalnia_Samochodow
{
    public partial class ZarządzanieWypozyczeniami : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public int IdZmiany;
        public string Status;
        public ZarządzanieWypozyczeniami()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            //Wyswietlenie listy wypozyczen
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();

            WyswietlWypo.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlWypo.Rows.Add();
                WyswietlWypo.Rows[number].Cells[0].Value = list[0][i];
                WyswietlWypo.Rows[number].Cells[1].Value = list[1][i];
                WyswietlWypo.Rows[number].Cells[2].Value = list[2][i];
                WyswietlWypo.Rows[number].Cells[3].Value = list[3][i];
                WyswietlWypo.Rows[number].Cells[4].Value = list[4][i];
                WyswietlWypo.Rows[number].Cells[5].Value = list[5][i];
                WyswietlWypo.Rows[number].Cells[6].Value = list[6][i];
            }

        }

        private void AktualizacjaDanych_Click(object sender, EventArgs e)
        {
            IdZmiany = int.Parse(txtIdZmiany.Text);
            Status = txtZakonczono.Text;
            dbConnect.ZmianaStatusu(IdZmiany, Status);
            //Poniżej wyświetlam listę wypożyczeń
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();

            WyswietlWypo.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlWypo.Rows.Add();
                WyswietlWypo.Rows[number].Cells[0].Value = list[0][i];
                WyswietlWypo.Rows[number].Cells[1].Value = list[1][i];
                WyswietlWypo.Rows[number].Cells[2].Value = list[2][i];
                WyswietlWypo.Rows[number].Cells[3].Value = list[3][i];
                WyswietlWypo.Rows[number].Cells[4].Value = list[4][i];
                WyswietlWypo.Rows[number].Cells[5].Value = list[5][i];
                WyswietlWypo.Rows[number].Cells[6].Value = list[6][i];
            }
        }

        private void MenuGlowne_Click(object sender, EventArgs e) //Powrot do menu głownego
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void ZarządzanieWypozyczeniami_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
