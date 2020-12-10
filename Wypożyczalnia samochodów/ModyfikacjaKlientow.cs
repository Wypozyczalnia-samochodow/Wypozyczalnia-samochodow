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
    public partial class ModyfikacjaKlientow : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public string imie, nazwisko, telefon;
        public int idKlientaUsuwanego;
        public int IdZmiany;
        public ModyfikacjaKlientow()
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

        private void WyswietlKlientowDataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modyfikacjadanych_Click(object sender, EventArgs e)
        {
            IdZmiany = int.Parse(txtIdZmiany.Text);
            imie = txtImieZmiany.Text;
            nazwisko = txtNazwiskoZmiany.Text;
            telefon = txtTelefonZmiany.Text;

            dbConnect.AktualizacjaDanych(IdZmiany,imie, nazwisko, telefon);//Przekazuje zmienne do metody dodającej rekord do bazy danych
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

        private void usunKlienta_Click(object sender, EventArgs e)
        {
            idKlientaUsuwanego = int.Parse(txtIdUsuwane.Text);
            txtpokapoka.Text = "Id do usunięcia: " + (idKlientaUsuwanego);
            dbConnect.UsuwanieKlientow(idKlientaUsuwanego);
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

        private void PowrotDoMenu_Click(object sender, EventArgs e)
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void ModyfikacjaKlientow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Zamknięcie całej aplikacji po wyłączeniu formularza
        }
    }
}
