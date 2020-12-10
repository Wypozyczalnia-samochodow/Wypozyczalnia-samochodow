namespace Wypozyczalnia_Samochodow
{
    partial class ModyfikacjaKlientow
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
            this.txtImieZmiany = new System.Windows.Forms.TextBox();
            this.txtIdZmiany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwiskoZmiany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonZmiany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdUsuwane = new System.Windows.Forms.TextBox();
            this.usunKlienta = new System.Windows.Forms.Button();
            this.modyfikacjadanych = new System.Windows.Forms.Button();
            this.txtpokapoka = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PowrotDoMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientowDataG)).BeginInit();
            this.SuspendLayout();
            // 
            // WyswietlKlientowDataG
            // 
            this.WyswietlKlientowDataG.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlKlientowDataG.ColumnHeadersHeight = 26;
            this.WyswietlKlientowDataG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Imie,
            this.Nazwisko,
            this.Telefon});
            this.WyswietlKlientowDataG.Location = new System.Drawing.Point(583, 114);
            this.WyswietlKlientowDataG.Name = "WyswietlKlientowDataG";
            this.WyswietlKlientowDataG.Size = new System.Drawing.Size(440, 249);
            this.WyswietlKlientowDataG.TabIndex = 3;
            this.WyswietlKlientowDataG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WyswietlKlientowDataG_CellContentClick);
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
            // txtImieZmiany
            // 
            this.txtImieZmiany.Location = new System.Drawing.Point(219, 114);
            this.txtImieZmiany.Name = "txtImieZmiany";
            this.txtImieZmiany.Size = new System.Drawing.Size(275, 20);
            this.txtImieZmiany.TabIndex = 14;
            // 
            // txtIdZmiany
            // 
            this.txtIdZmiany.Location = new System.Drawing.Point(410, 63);
            this.txtIdZmiany.Name = "txtIdZmiany";
            this.txtIdZmiany.Size = new System.Drawing.Size(84, 20);
            this.txtIdZmiany.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Podaj id klienta którego dane chcesz zmienić:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Podaj nowe imie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Podaj nowe nazwisko:";
            // 
            // txtNazwiskoZmiany
            // 
            this.txtNazwiskoZmiany.Location = new System.Drawing.Point(219, 155);
            this.txtNazwiskoZmiany.Name = "txtNazwiskoZmiany";
            this.txtNazwiskoZmiany.Size = new System.Drawing.Size(275, 20);
            this.txtNazwiskoZmiany.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Podaj nowy telefon:";
            // 
            // txtTelefonZmiany
            // 
            this.txtTelefonZmiany.Location = new System.Drawing.Point(219, 196);
            this.txtTelefonZmiany.Name = "txtTelefonZmiany";
            this.txtTelefonZmiany.Size = new System.Drawing.Size(275, 20);
            this.txtTelefonZmiany.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Modyfikacja danych klienta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Usuwanie klienta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Podaj id klienta którego dane chcesz usunąć:";
            // 
            // txtIdUsuwane
            // 
            this.txtIdUsuwane.Location = new System.Drawing.Point(410, 369);
            this.txtIdUsuwane.Name = "txtIdUsuwane";
            this.txtIdUsuwane.Size = new System.Drawing.Size(84, 20);
            this.txtIdUsuwane.TabIndex = 27;
            // 
            // usunKlienta
            // 
            this.usunKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.usunKlienta.Location = new System.Drawing.Point(12, 407);
            this.usunKlienta.Name = "usunKlienta";
            this.usunKlienta.Size = new System.Drawing.Size(135, 35);
            this.usunKlienta.TabIndex = 28;
            this.usunKlienta.Text = "Usuń klienta";
            this.usunKlienta.UseVisualStyleBackColor = true;
            this.usunKlienta.Click += new System.EventHandler(this.usunKlienta_Click);
            // 
            // modyfikacjadanych
            // 
            this.modyfikacjadanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.modyfikacjadanych.Location = new System.Drawing.Point(25, 239);
            this.modyfikacjadanych.Name = "modyfikacjadanych";
            this.modyfikacjadanych.Size = new System.Drawing.Size(182, 54);
            this.modyfikacjadanych.TabIndex = 29;
            this.modyfikacjadanych.Text = "Wykonaj modyfikację danych";
            this.modyfikacjadanych.UseVisualStyleBackColor = true;
            this.modyfikacjadanych.Click += new System.EventHandler(this.modyfikacjadanych_Click);
            // 
            // txtpokapoka
            // 
            this.txtpokapoka.AutoSize = true;
            this.txtpokapoka.Location = new System.Drawing.Point(420, 331);
            this.txtpokapoka.Name = "txtpokapoka";
            this.txtpokapoka.Size = new System.Drawing.Size(0, 13);
            this.txtpokapoka.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(690, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Modyfikacja danych klienta:";
            // 
            // PowrotDoMenu
            // 
            this.PowrotDoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PowrotDoMenu.Location = new System.Drawing.Point(312, 239);
            this.PowrotDoMenu.Name = "PowrotDoMenu";
            this.PowrotDoMenu.Size = new System.Drawing.Size(182, 54);
            this.PowrotDoMenu.TabIndex = 32;
            this.PowrotDoMenu.Text = "Powrót do Menu Głównego";
            this.PowrotDoMenu.UseVisualStyleBackColor = true;
            this.PowrotDoMenu.Click += new System.EventHandler(this.PowrotDoMenu_Click);
            // 
            // ModyfikacjaKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 465);
            this.Controls.Add(this.PowrotDoMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpokapoka);
            this.Controls.Add(this.modyfikacjadanych);
            this.Controls.Add(this.usunKlienta);
            this.Controls.Add(this.txtIdUsuwane);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefonZmiany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazwiskoZmiany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdZmiany);
            this.Controls.Add(this.txtImieZmiany);
            this.Controls.Add(this.WyswietlKlientowDataG);
            this.Name = "ModyfikacjaKlientow";
            this.Text = "ModyfikacjaKlientow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModyfikacjaKlientow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlKlientowDataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WyswietlKlientowDataG;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.TextBox txtImieZmiany;
        private System.Windows.Forms.TextBox txtIdZmiany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwiskoZmiany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonZmiany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdUsuwane;
        private System.Windows.Forms.Button usunKlienta;
        private System.Windows.Forms.Button modyfikacjadanych;
        private System.Windows.Forms.Label txtpokapoka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PowrotDoMenu;
    }
}
