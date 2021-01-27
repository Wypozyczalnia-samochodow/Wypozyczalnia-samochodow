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
    public partial class DodajSamochody : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public string marka, model, kolor;
        public float cena;
        public int rocznik;
        public DodajSamochody()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            //Stworzenie polączenia przy wejściu w formularz i wypisanie wszystkich rekordów z bazy
            List<string>[] list;
            list = dbConnect.SelectWszystkie();

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDG1.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDG1.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDG1.Rows[number].Cells[5].Value = list[5][i];
            }
        }

        private void WyswietlDG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DodajSamochod_Click(object sender, EventArgs e)
        {
            marka = txtMarka.Text;
            model = txtModel.Text;
            kolor = txtKolor.Text;
            rocznik = int.Parse(txtRocznik.Text);
            cena = float.Parse(txtCena.Text);
            dbConnect.DodawanieSamochodow(marka, model, kolor, rocznik, cena);//Przekazuje zmienne do metody dodającej rekord do bazy danych
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectWszystkie();

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDG1.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDG1.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDG1.Rows[number].Cells[5].Value = list[5][i];
            }
            
        }

        private void DodajSamochody_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Zamkniecie aplikacji po zamknieciu formularza
        }

        private void MenuGlowne_Click(object sender, EventArgs e)
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }
    }
}
//
