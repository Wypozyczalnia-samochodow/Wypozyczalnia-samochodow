using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wypozyczalnia_Samochodow
{
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Wyswietl samochody
        {
            WyswietlSamochody w1 = new WyswietlSamochody();
            this.Hide();//
            w1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Usun_Click(object sender, EventArgs e)
        {
            UsunSamochody u1 = new UsunSamochody();
            this.Hide();//
            u1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DodajSamochody d1 = new DodajSamochody();
            this.Hide();//
            d1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        
    }
}
