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
    public partial class DodajKlientow : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public string imie, nazwisko, telefon;
        public DodajKlientow()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectALLKlienci();

            WyswietlKlientowDataG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlKlientowDataG.Rows.Add();
                WyswietlKlientowDataG.Rows[number].Cells[0].Value = list[0][i];
                WyswietlKlientowDataG.Rows[number].Cells[1].Value = list[1][i];
                WyswietlKlientowDataG.Rows[number].Cells[2].Value = list[2][i];
                WyswietlKlientowDataG.Rows[number].Cells[3].Value = list[3][i];
                
            }
        }

        private void dodajklienta_Click(object sender, EventArgs e)
        {
            imie = txtImie.Text;
            nazwisko = txtNazwisko.Text;
            telefon = txtNumerTelefonu.Text;

            dbConnect.DodawanieKlientow(imie, nazwisko, telefon);//Przekazuje zmienne do metody dodającej rekord do bazy danych
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectALLKlienci();

            WyswietlKlientowDataG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlKlientowDataG.Rows.Add();
                WyswietlKlientowDataG.Rows[number].Cells[0].Value = list[0][i];
                WyswietlKlientowDataG.Rows[number].Cells[1].Value = list[1][i];
                WyswietlKlientowDataG.Rows[number].Cells[2].Value = list[2][i];
                WyswietlKlientowDataG.Rows[number].Cells[3].Value = list[3][i];
                
            }
            
        }
        }
    }
