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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Przycisk do przejscia miedzy formularzami
        {
            WyswietlSamochody w1 = new WyswietlSamochody();
            this.Hide();//
            w1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.


        }
    }
}
