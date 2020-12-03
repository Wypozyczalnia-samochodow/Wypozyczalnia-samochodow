namespace Wypozyczalnia_Samochodow
{
    partial class DodajSamochody
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
            this.WyswietlDG1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rocznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaZaGodzine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.dodanieSamochodu = new System.Windows.Forms.Label();
            this.DodajSamochod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKolor = new System.Windows.Forms.TextBox();
            this.txtRocznik = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlDG1)).BeginInit();
            this.SuspendLayout();
            // 
            // WyswietlDG1
            // 
            this.WyswietlDG1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlDG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WyswietlDG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Marka,
            this.Model,
            this.Kolor,
            this.Rocznik,
            this.CenaZaGodzine});
            this.WyswietlDG1.Location = new System.Drawing.Point(283, 245);
            this.WyswietlDG1.Name = "WyswietlDG1";
            this.WyswietlDG1.Size = new System.Drawing.Size(645, 324);
            this.WyswietlDG1.TabIndex = 3;
            this.WyswietlDG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WyswietlDG1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Kolor
            // 
            this.Kolor.HeaderText = "Kolor";
            this.Kolor.Name = "Kolor";
            // 
            // Rocznik
            // 
            this.Rocznik.HeaderText = "Rocznik";
            this.Rocznik.Name = "Rocznik";
            // 
            // CenaZaGodzine
            // 
            this.CenaZaGodzine.HeaderText = "Cena za godzinę";
            this.CenaZaGodzine.Name = "CenaZaGodzine";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(369, 60);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(559, 20);
            this.txtMarka.TabIndex = 6;
            // 
            // dodanieSamochodu
            // 
            this.dodanieSamochodu.AutoSize = true;
            this.dodanieSamochodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dodanieSamochodu.Location = new System.Drawing.Point(12, 91);
            this.dodanieSamochodu.Name = "dodanieSamochodu";
            this.dodanieSamochodu.Size = new System.Drawing.Size(351, 20);
            this.dodanieSamochodu.TabIndex = 7;
            this.dodanieSamochodu.Text = "Podaj model samochodu, który chcesz dodać:";
            // 
            // DodajSamochod
            // 
            this.DodajSamochod.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajSamochod.Location = new System.Drawing.Point(60, 346);
            this.DodajSamochod.Name = "DodajSamochod";
            this.DodajSamochod.Size = new System.Drawing.Size(175, 102);
            this.DodajSamochod.TabIndex = 8;
            this.DodajSamochod.Text = "Dodaj samochód";
            this.DodajSamochod.UseVisualStyleBackColor = true;
            this.DodajSamochod.Click += new System.EventHandler(this.DodajSamochod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Podaj markę samochodu, który chcesz dodać:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Podaj kolor samochodu, który chcesz dodać:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Podaj rocznik samochodu, który chcesz dodać:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Podaj Cenę za godzinę wypożyczenia samochodu, który chcesz dodać:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(369, 91);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(559, 20);
            this.txtModel.TabIndex = 13;
            // 
            // txtKolor
            // 
            this.txtKolor.Location = new System.Drawing.Point(369, 126);
            this.txtKolor.Name = "txtKolor";
            this.txtKolor.Size = new System.Drawing.Size(559, 20);
            this.txtKolor.TabIndex = 14;
            // 
            // txtRocznik
            // 
            this.txtRocznik.Location = new System.Drawing.Point(369, 157);
            this.txtRocznik.Name = "txtRocznik";
            this.txtRocznik.Size = new System.Drawing.Size(559, 20);
            this.txtRocznik.TabIndex = 15;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(558, 192);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(370, 20);
            this.txtCena.TabIndex = 16;
            // 
            // DodajSamochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 604);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtRocznik);
            this.Controls.Add(this.txtKolor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajSamochod);
            this.Controls.Add(this.dodanieSamochodu);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.WyswietlDG1);
            this.Name = "DodajSamochody";
            this.Text = "DodajSamochody";
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlDG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WyswietlDG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rocznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaZaGodzine;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label dodanieSamochodu;
        private System.Windows.Forms.Button DodajSamochod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKolor;
        private System.Windows.Forms.TextBox txtRocznik;
        private System.Windows.Forms.TextBox txtCena;
    }
}
