namespace Wypozyczalnia_Samochodow
{
    partial class DodajKlientow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WyswietlKlientowDataG = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PowrotDoMenu = new System.Windows.Forms.Button();
            this.ZarzadzajKlientami = new System.Windows.Forms.Button();
            this.WypozyczAuto = new System.Windows.Forms.Button();
            this.dodajklienta = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtNumerTelefonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientowDataG)).BeginInit();
            this.SuspendLayout();
            // 
            // WyswietlKlientowDataG
            // 
            this.WyswietlKlientowDataG.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlKlientowDataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WyswietlKlientowDataG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Imie,
            this.Nazwisko,
            this.Telefon});
            this.WyswietlKlientowDataG.Location = new System.Drawing.Point(34, 237);
            this.WyswietlKlientowDataG.Name = "WyswietlKlientowDataG";
            this.WyswietlKlientowDataG.Size = new System.Drawing.Size(443, 172);
            this.WyswietlKlientowDataG.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista wszystkich klientów naszej wypożyczalni:";
            // 
            // PowrotDoMenu
            // 
            this.PowrotDoMenu.Location = new System.Drawing.Point(515, 51);
            this.PowrotDoMenu.Name = "PowrotDoMenu";
            this.PowrotDoMenu.Size = new System.Drawing.Size(124, 46);
            this.PowrotDoMenu.TabIndex = 7;
            this.PowrotDoMenu.Text = "Powrót do Menu Głównego";
            this.PowrotDoMenu.UseVisualStyleBackColor = true;
            // 
            // ZarzadzajKlientami
            // 
            this.ZarzadzajKlientami.Location = new System.Drawing.Point(515, 261);
            this.ZarzadzajKlientami.Name = "ZarzadzajKlientami";
            this.ZarzadzajKlientami.Size = new System.Drawing.Size(124, 52);
            this.ZarzadzajKlientami.TabIndex = 8;
            this.ZarzadzajKlientami.Text = "Modyfikacja danych Klientów";
            this.ZarzadzajKlientami.UseVisualStyleBackColor = true;
            // 
            // WypozyczAuto
            // 
            this.WypozyczAuto.Location = new System.Drawing.Point(515, 335);
            this.WypozyczAuto.Name = "WypozyczAuto";
            this.WypozyczAuto.Size = new System.Drawing.Size(124, 55);
            this.WypozyczAuto.TabIndex = 9;
            this.WypozyczAuto.Text = "Wypożycz samochód dla klienta";
            this.WypozyczAuto.UseVisualStyleBackColor = true;
            // 
            // dodajklienta
            // 
            this.dodajklienta.Location = new System.Drawing.Point(316, 141);
            this.dodajklienta.Name = "dodajklienta";
            this.dodajklienta.Size = new System.Drawing.Size(135, 35);
            this.dodajklienta.TabIndex = 10;
            this.dodajklienta.Text = "Dodaj klienta";
            this.dodajklienta.UseVisualStyleBackColor = true;
            this.dodajklienta.Click += new System.EventHandler(this.dodajklienta_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(176, 25);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(275, 20);
            this.txtImie.TabIndex = 11;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(176, 65);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(275, 20);
            this.txtNazwisko.TabIndex = 12;
            // 
            // txtNumerTelefonu
            // 
            this.txtNumerTelefonu.Location = new System.Drawing.Point(176, 102);
            this.txtNumerTelefonu.Name = "txtNumerTelefonu";
            this.txtNumerTelefonu.Size = new System.Drawing.Size(275, 20);
            this.txtNumerTelefonu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Podaj imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Podaj nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Podaj telefon:";
            // 
            // DodajKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumerTelefonu);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.dodajklienta);
            this.Controls.Add(this.WypozyczAuto);
            this.Controls.Add(this.ZarzadzajKlientami);
            this.Controls.Add(this.PowrotDoMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WyswietlKlientowDataG);
            this.Name = "DodajKlientow";
            this.Text = "WyswietlKlientow";
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientowDataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WyswietlKlientowDataG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.Button PowrotDoMenu;
        private System.Windows.Forms.Button ZarzadzajKlientami;
        private System.Windows.Forms.Button WypozyczAuto;
        private System.Windows.Forms.Button dodajklienta;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtNumerTelefonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
