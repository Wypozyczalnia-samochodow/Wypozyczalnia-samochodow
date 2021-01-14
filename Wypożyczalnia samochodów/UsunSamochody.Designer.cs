namespace Wypozyczalnia_Samochodow
{
    partial class UsunSamochody
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
            this.UsunSamochod = new System.Windows.Forms.Button();
            this.txtWejscie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PowrotDoMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WyswietlDG1)).BeginInit();
            this.SuspendLayout();
            // 
            // WyswietlDG1
            // 
            this.WyswietlDG1.AllowUserToAddRows = false;
            this.WyswietlDG1.AllowUserToDeleteRows = false;
            this.WyswietlDG1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.WyswietlDG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WyswietlDG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Marka,
            this.Model,
            this.Kolor,
            this.Rocznik,
            this.CenaZaGodzine});
            this.WyswietlDG1.Location = new System.Drawing.Point(35, 109);
            this.WyswietlDG1.Name = "WyswietlDG1";
            this.WyswietlDG1.ReadOnly = true;
            this.WyswietlDG1.Size = new System.Drawing.Size(645, 315);
            this.WyswietlDG1.TabIndex = 2;
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
            // UsunSamochod
            // 
            this.UsunSamochod.Location = new System.Drawing.Point(379, 29);
            this.UsunSamochod.Name = "UsunSamochod";
            this.UsunSamochod.Size = new System.Drawing.Size(94, 56);
            this.UsunSamochod.TabIndex = 4;
            this.UsunSamochod.Text = "Usuń samochód";
            this.UsunSamochod.UseVisualStyleBackColor = true;
            this.UsunSamochod.Click += new System.EventHandler(this.UsunSamochod_Click);
            // 
            // txtWejscie
            // 
            this.txtWejscie.Location = new System.Drawing.Point(39, 62);
            this.txtWejscie.Name = "txtWejscie";
            this.txtWejscie.Size = new System.Drawing.Size(306, 20);
            this.txtWejscie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj id samochodu który chesz usunąć";
            // 
            // PowrotDoMenu
            // 
            this.PowrotDoMenu.Location = new System.Drawing.Point(537, 29);
            this.PowrotDoMenu.Name = "PowrotDoMenu";
            this.PowrotDoMenu.Size = new System.Drawing.Size(141, 56);
            this.PowrotDoMenu.TabIndex = 8;
            this.PowrotDoMenu.Text = "Powrót do Menu Głównego";
            this.PowrotDoMenu.UseVisualStyleBackColor = true;
            this.PowrotDoMenu.Click += new System.EventHandler(this.PowrotDoMenu_Click);
            // 
            // UsunSamochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 464);
            this.Controls.Add(this.PowrotDoMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWejscie);
            this.Controls.Add(this.UsunSamochod);
            this.Controls.Add(this.WyswietlDG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UsunSamochody";
            this.Text = "UsunSamochody";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsunSamochody_FormClosed_1);
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
        private System.Windows.Forms.Button UsunSamochod;
        private System.Windows.Forms.TextBox txtWejscie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PowrotDoMenu;
    }
}
