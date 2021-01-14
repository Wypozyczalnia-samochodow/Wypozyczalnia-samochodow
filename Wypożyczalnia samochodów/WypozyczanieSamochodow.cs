using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia_Samochodow
{
    public partial class WypozyczanieSamochodow : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public int idSamochodu, idKlienta, ileGodzin;
        public WypozyczanieSamochodow()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            //Wyswietlenie listy samochodow
            List<string>[] list;
            list = dbConnect.SelectDostepne();

            WyswietlDostepne.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDostepne.Rows.Add();
                WyswietlDostepne.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDostepne.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDostepne.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDostepne.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDostepne.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDostepne.Rows[number].Cells[5].Value = list[5][i];
            }

            //Wyswietlenie listy klientow
            List<string>[] list2;
            list2 = dbConnect.SelectALLKlienci();

            WyswietlKlientow.Rows.Clear();
            for (int i = 0; i < list2[0].Count; i++)
            {
                int number = WyswietlKlientow.Rows.Add();
                WyswietlKlientow.Rows[number].Cells[0].Value = list2[0][i];
                WyswietlKlientow.Rows[number].Cells[1].Value = list2[1][i];
                WyswietlKlientow.Rows[number].Cells[2].Value = list2[2][i];
                WyswietlKlientow.Rows[number].Cells[3].Value = list2[3][i];

            }
        }

        private void Wypozycz_Click(object sender, EventArgs e)
        {
            idSamochodu = int.Parse(txtIdAuta.Text);
            idKlienta = int.Parse(txtIdKlienta.Text);
            ileGodzin = int.Parse(txtIle.Text);
            dbConnect.WypozyczanieSamochodow(idKlienta, idSamochodu, ileGodzin);
        }

        private void MenuGlowne_Click(object sender, EventArgs e)
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void ZarzadzajWypozyczeniami_Click(object sender, EventArgs e)
        {
            ZarządzanieWypozyczeniami z1 = new ZarządzanieWypozyczeniami();
            this.Hide();//
            z1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void WypozyczanieSamochodow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
