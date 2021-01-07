namespace Wypozyczalnia_Samochodow
{
    partial class WypozyczanieSamochodow
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WyswietlKlientow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdKlienta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIle = new System.Windows.Forms.TextBox();
            this.MenuGlowne = new System.Windows.Forms.Button();
            this.Wypozycz = new System.Windows.Forms.Button();
            this.ZarzadzajWypozyczeniami = new System.Windows.Forms.Button();
            this.WyswietlDostepne = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rocznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaZaGodzine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlDostepne)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(8, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "Lista dostępnych samochodów:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Podaj id samochodu który chesz wypożyczyć:";
            // 
            // txtIdAuta
            // 
            this.txtIdAuta.Location = new System.Drawing.Point(404, 24);
            this.txtIdAuta.Name = "txtIdAuta";
            this.txtIdAuta.Size = new System.Drawing.Size(84, 20);
            this.txtIdAuta.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Lista klientów:";
            // 
            // WyswietlKlientow
            // 
            this.WyswietlKlientow.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlKlientow.ColumnHeadersHeight = 26;
            this.WyswietlKlientow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.WyswietlKlientow.Location = new System.Drawing.Point(12, 377);
            this.WyswietlKlientow.Name = "WyswietlKlientow";
            this.WyswietlKlientow.Size = new System.Drawing.Size(436, 165);
            this.WyswietlKlientow.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Podaj id klienta który chce wypożyczyć:";
            // 
            // txtIdKlienta
            // 
            this.txtIdKlienta.Location = new System.Drawing.Point(404, 55);
            this.txtIdKlienta.Name = "txtIdKlienta";
            this.txtIdKlienta.Size = new System.Drawing.Size(84, 20);
            this.txtIdKlienta.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Na ile godzin wypożyczyć samochód?:";
            // 
            // txtIle
            // 
            this.txtIle.Location = new System.Drawing.Point(404, 85);
            this.txtIle.Name = "txtIle";
            this.txtIle.Size = new System.Drawing.Size(84, 20);
            this.txtIle.TabIndex = 54;
            // 
            // MenuGlowne
            // 
            this.MenuGlowne.Location = new System.Drawing.Point(662, 12);
            this.MenuGlowne.Name = "MenuGlowne";
            this.MenuGlowne.Size = new System.Drawing.Size(99, 53);
            this.MenuGlowne.TabIndex = 56;
            this.MenuGlowne.Text = "Powrót do Menu Głównego";
            this.MenuGlowne.UseVisualStyleBackColor = true;
            this.MenuGlowne.Click += new System.EventHandler(this.MenuGlowne_Click);
            // 
            // Wypozycz
            // 
            this.Wypozycz.Location = new System.Drawing.Point(526, 36);
            this.Wypozycz.Name = "Wypozycz";
            this.Wypozycz.Size = new System.Drawing.Size(89, 56);
            this.Wypozycz.TabIndex = 57;
            this.Wypozycz.Text = "Wypożycz samochód";
            this.Wypozycz.UseVisualStyleBackColor = true;
            this.Wypozycz.Click += new System.EventHandler(this.Wypozycz_Click);
            // 
            // ZarzadzajWypozyczeniami
            // 
            this.ZarzadzajWypozyczeniami.Location = new System.Drawing.Point(662, 85);
            this.ZarzadzajWypozyczeniami.Name = "ZarzadzajWypozyczeniami";
            this.ZarzadzajWypozyczeniami.Size = new System.Drawing.Size(99, 56);
            this.ZarzadzajWypozyczeniami.TabIndex = 58;
            this.ZarzadzajWypozyczeniami.Text = "Zarządzaj wypożyczeniami";
            this.ZarzadzajWypozyczeniami.UseVisualStyleBackColor = true;
            // 
            // WyswietlDostepne
            // 
            this.WyswietlDostepne.AllowUserToAddRows = false;
            this.WyswietlDostepne.AllowUserToDeleteRows = false;
            this.WyswietlDostepne.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlDostepne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WyswietlDostepne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Marka,
            this.Model,
            this.Kolor,
            this.Rocznik,
            this.CenaZaGodzine});
            this.WyswietlDostepne.Location = new System.Drawing.Point(12, 176);
            this.WyswietlDostepne.Name = "WyswietlDostepne";
            this.WyswietlDostepne.ReadOnly = true;
            this.WyswietlDostepne.Size = new System.Drawing.Size(641, 155);
            this.WyswietlDostepne.TabIndex = 59;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Kolor
            // 
            this.Kolor.HeaderText = "Kolor";
            this.Kolor.Name = "Kolor";
            this.Kolor.ReadOnly = true;
            // 
            // Rocznik
            // 
            this.Rocznik.HeaderText = "Rocznik";
            this.Rocznik.Name = "Rocznik";
            this.Rocznik.ReadOnly = true;
            // 
            // CenaZaGodzine
            // 
            this.CenaZaGodzine.HeaderText = "Cena za godzinę";
            this.CenaZaGodzine.Name = "CenaZaGodzine";
            this.CenaZaGodzine.ReadOnly = true;
            // 
            // WypozyczanieSamochodow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 558);
            this.Controls.Add(this.WyswietlDostepne);
            this.Controls.Add(this.ZarzadzajWypozyczeniami);
            this.Controls.Add(this.Wypozycz);
            this.Controls.Add(this.MenuGlowne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdKlienta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WyswietlKlientow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAuta);
            this.Name = "WypozyczanieSamochodow";
            this.Text = "WypozyczanieSamochodow";
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlDostepne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WyswietlKlientow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdKlienta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIle;
        private System.Windows.Forms.Button MenuGlowne;
        private System.Windows.Forms.Button Wypozycz;
        private System.Windows.Forms.Button ZarzadzajWypozyczeniami;
        private System.Windows.Forms.DataGridView WyswietlDostepne;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rocznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaZaGodzine;
    }
}
