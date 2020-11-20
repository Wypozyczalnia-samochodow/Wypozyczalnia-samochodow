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
    public partial class WyswietlSamochody : Form
    {
        private BazaDanychPolaczenie dbConnect;

        public WyswietlSamochody()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void WyswietlSamochody_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Ta instrukcja jest do zamknięcia aplikacji gdy przejdziemy do drugiego formularza
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectFord();

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e) //Przycisk Ford
        {
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectFord(); //Select Ford

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Przycisk Nissan
        {
            //Select button is clicked
            List<string>[] list;
            list = dbConnect.SelectNissan();

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
            }
        }
    }
}
