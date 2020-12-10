using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Wypozyczalnia_Samochodow
{
    
    public partial class UsunSamochody : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public int idUsuwane;
        public UsunSamochody()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
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

        private void PokazWszystkie_Click(object sender, EventArgs e)
        {
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void UsunSamochod_Click(object sender, EventArgs e)
        {
          
            txtWyjscie.Text = "Id do usunięcia: " + (txtWejscie.Text);
            idUsuwane = int.Parse(txtWejscie.Text);
            dbConnect.UsuwanieSamochodow(idUsuwane);//Przekazuje zmienna idUsuwane do metody usuwającej rekord o danym id z bazy danych
        }

        private void UsunSamochody_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
