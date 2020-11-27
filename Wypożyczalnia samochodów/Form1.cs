using System
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            //System.Data.SqlClient.SqlConnection DB = new SqlConnection("Server=tcp:testowa.database.windows.net,1433;Initial Catalog=Projekt;Persist Security Info=False;User ID=DataManager;Password=mt8b8uMoOj;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            System.Data.SqlClient.SqlConnection connection = new SqlConnection("Server = tcp:testowy.database.windows.net,1433; Initial Catalog = WypozyczalniaSamochodow; Persist Security Info = False; User ID = jArecki; Password = mt8b8uMoOj; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open ! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Connection Fail ! ");
            }
        }
    }
}
