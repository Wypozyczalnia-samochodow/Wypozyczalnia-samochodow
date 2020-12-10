using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace Wypozyczalnia_Samochodow
{
    class BazaDanychPolaczenie
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        #region inicjalizacja połączenia z zewnętrzną bazą danych
        //Constructor
        public BazaDanychPolaczenie()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "bartuszak.pl";
            database = "a_cichurski";
            uid = "a_cichurski";
            password = "BAjE3byDQnjQuZ3L";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        #endregion

        #region otworzenie połączenia z zewnętrzną bazą danych
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Pobrano dane! \nZostales polaczony z serwerem");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        #endregion

        #region Zamknięcie połączenia z zewnętrzną Bazą danych
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Wyswietlenie danych z tabeli dla przycisku Ford
        public List<string>[] SelectFord()
        {
            string query = "SELECT * FROM NaszeSamochody where Marka='Ford'";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Wyswietlenie danych z tabeli dla przycisku Nissan
        public List<string>[] SelectNissan()
        {
            string query = "SELECT * FROM NaszeSamochody where Marka='Nissan'";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Wyswietlenie danych z tabeli dla przycisku Lamborghini
        public List<string>[] SelectLamborghini()
        {
            string query = "SELECT * FROM NaszeSamochody where Marka='Lamborghini'";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Wyswietlenie danych z tabeli dla przycisku Ferrari
        public List<string>[] SelectFerrari()
        {
            string query = "SELECT * FROM NaszeSamochody where Marka='Ferrari'";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Wyswietlenie danych z tabeli dla przycisku Porsche
        public List<string>[] SelectPorsche()
        {
            string query = "SELECT * FROM NaszeSamochody where Marka='Porsche'";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Wyswietlanie wszystkich samochodow
        public List<string>[] SelectWszystkie()
        {
            string query = "SELECT * FROM NaszeSamochody";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idSamochodu"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                    list[2].Add(dataReader["Model"] + "");
                    list[3].Add(dataReader["Kolor"] + "");
                    list[4].Add(dataReader["Rocznik"] + "");
                    list[5].Add(dataReader["CenaZaGodzine"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Dodawanie nowych samochodów
        public void DodawanieSamochodow(string marka, string model, string kolor, int rocznik, float cena)
        {
            string query = "INSERT INTO NaszeSamochody (Marka,Model,Kolor,Rocznik,CenaZaGodzine) VALUES('" + marka + "','" + model + "','" + kolor + "'," + rocznik + "," + cena + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        } 
        #endregion

        #region Usuwanie samochodów
        public void UsuwanieSamochodow(int MDK)
        {
            string query = "delete from NaszeSamochody WHERE idSamochodu=('" + MDK + "')";
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion 

        #region Wyswietlanie wszystkich Klientow
        public List<string>[] SelectALLKlienci()
        {
            string query = "SELECT * FROM Klienci";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idKlienta"] + "");
                    list[1].Add(dataReader["Imie"] + "");
                    list[2].Add(dataReader["Nazwisko"] + "");
                    list[3].Add(dataReader["NumerTelefonu"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        #region Dodawanie nowych Klientów
        public void DodawanieKlientow(string imie, string nazwisko, string telefon)
        {
            string query = "INSERT INTO Klienci (Imie,Nazwisko,NumerTelefonu) VALUES('" + imie + "','" + nazwisko + "','" + telefon + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion

        #region Usuwanie klientów z bazy
        public void UsuwanieKlientow(int idKlientaUsuwanego)
        {
            string query = "delete from Klienci WHERE idKlienta=('" + idKlientaUsuwanego + "')";
            
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion
        public void AktualizacjaDanych(int IdZmiany, string imie, string nazwisko, string telefon)
        {
            string query = "UPDATE Klienci SET Imie=('"+imie+"') , Nazwisko=('"+nazwisko+"'), NumerTelefonu=('"+telefon+"') WHERE idKlienta=('" + IdZmiany + "')";
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
