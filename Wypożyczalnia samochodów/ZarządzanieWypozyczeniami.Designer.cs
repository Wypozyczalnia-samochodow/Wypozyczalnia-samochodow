namespace Wypozyczalnia_Samochodow
{
    partial class ZarządzanieWypozyczeniami
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
            this.WyswietlWypo = new System.Windows.Forms.DataGridView();
            this.idWypozyczenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaIleGodzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakonczonoWyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdZmiany = new System.Windows.Forms.TextBox();
            this.txtZakonczono = new System.Windows.Forms.TextBox();
            this.MenuGlowne = new System.Windows.Forms.Button();
            this.wyswietlquerry = new System.Windows.Forms.Label();
            this.AktualizacjaDanych = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlWypo)).BeginInit();
            this.SuspendLayout();
            // 
            // WyswietlWypo
            // 
            this.WyswietlWypo.AllowUserToAddRows = false;
            this.WyswietlWypo.AllowUserToDeleteRows = false;
            this.WyswietlWypo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlWypo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WyswietlWypo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWypozyczenia,
            this.Marka,
            this.Model,
            this.Imie,
            this.Nazwisko,
            this.NaIleGodzin,
            this.ZakonczonoWyp});
            this.WyswietlWypo.Location = new System.Drawing.Point(27, 62);
            this.WyswietlWypo.Name = "WyswietlWypo";
            this.WyswietlWypo.ReadOnly = true;
            this.WyswietlWypo.Size = new System.Drawing.Size(743, 234);
            this.WyswietlWypo.TabIndex = 60;
            // 
            // idWypozyczenia
            // 
            this.idWypozyczenia.HeaderText = "id Wypożyczenia";
            this.idWypozyczenia.Name = "idWypozyczenia";
            this.idWypozyczenia.ReadOnly = true;
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
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // NaIleGodzin
            // 
            this.NaIleGodzin.HeaderText = "NaileGodzin";
            this.NaIleGodzin.Name = "NaIleGodzin";
            this.NaIleGodzin.ReadOnly = true;
            // 
            // ZakonczonoWyp
            // 
            this.ZakonczonoWyp.HeaderText = "Zakończono Wypożyczenie?";
            this.ZakonczonoWyp.Name = "ZakonczonoWyp";
            this.ZakonczonoWyp.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(232, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Podaj id wypozyczenia którego status chcesz zmienić:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(335, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Wypożyczenie zakończone? (tak lub nie):";
            // 
            // txtIdZmiany
            // 
            this.txtIdZmiany.Location = new System.Drawing.Point(687, 330);
            this.txtIdZmiany.Name = "txtIdZmiany";
            this.txtIdZmiany.Size = new System.Drawing.Size(84, 20);
            this.txtIdZmiany.TabIndex = 63;
            // 
            // txtZakonczono
            // 
            this.txtZakonczono.Location = new System.Drawing.Point(687, 367);
            this.txtZakonczono.Name = "txtZakonczono";
            this.txtZakonczono.Size = new System.Drawing.Size(84, 20);
            this.txtZakonczono.TabIndex = 64;
            // 
            // MenuGlowne
            // 
            this.MenuGlowne.Location = new System.Drawing.Point(484, 419);
            this.MenuGlowne.Name = "MenuGlowne";
            this.MenuGlowne.Size = new System.Drawing.Size(122, 53);
            this.MenuGlowne.TabIndex = 65;
            this.MenuGlowne.Text = "Powrót do Menu Głównego";
            this.MenuGlowne.UseVisualStyleBackColor = true;
            this.MenuGlowne.Click += new System.EventHandler(this.MenuGlowne_Click);
            // 
            // wyswietlquerry
            // 
            this.wyswietlquerry.AutoSize = true;
            this.wyswietlquerry.Location = new System.Drawing.Point(85, 413);
            this.wyswietlquerry.Name = "wyswietlquerry";
            this.wyswietlquerry.Size = new System.Drawing.Size(0, 13);
            this.wyswietlquerry.TabIndex = 66;
            // 
            // AktualizacjaDanych
            // 
            this.AktualizacjaDanych.Location = new System.Drawing.Point(636, 419);
            this.AktualizacjaDanych.Name = "AktualizacjaDanych";
            this.AktualizacjaDanych.Size = new System.Drawing.Size(135, 53);
            this.AktualizacjaDanych.TabIndex = 67;
            this.AktualizacjaDanych.Text = "Dokonaj aktualizacji danych";
            this.AktualizacjaDanych.UseVisualStyleBackColor = true;
            this.AktualizacjaDanych.Click += new System.EventHandler(this.AktualizacjaDanych_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Lista wypożyczeń samochodów:";
            // 
            // ZarządzanieWypozyczeniami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AktualizacjaDanych);
            this.Controls.Add(this.wyswietlquerry);
            this.Controls.Add(this.MenuGlowne);
            this.Controls.Add(this.txtZakonczono);
            this.Controls.Add(this.txtIdZmiany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WyswietlWypo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZarządzanieWypozyczeniami";
            this.Text = "ZarządzanieWypozyczeniami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZarządzanieWypozyczeniami_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlWypo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WyswietlWypo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdZmiany;
        private System.Windows.Forms.TextBox txtZakonczono;
        private System.Windows.Forms.Button MenuGlowne;
        private System.Windows.Forms.Label wyswietlquerry;
        private System.Windows.Forms.Button AktualizacjaDanych;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWypozyczenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaIleGodzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakonczonoWyp;
    }
}
