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
            this.PokazWszystkie = new System.Windows.Forms.Button();
            this.UsunSamochod = new System.Windows.Forms.Button();
            this.txtWejscie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWyjscie = new System.Windows.Forms.Label();
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
            this.WyswietlDG1.Location = new System.Drawing.Point(62, 165);
            this.WyswietlDG1.Name = "WyswietlDG1";
            this.WyswietlDG1.Size = new System.Drawing.Size(645, 155);
            this.WyswietlDG1.TabIndex = 2;
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
            // PokazWszystkie
            // 
            this.PokazWszystkie.Location = new System.Drawing.Point(86, 55);
            this.PokazWszystkie.Name = "PokazWszystkie";
            this.PokazWszystkie.Size = new System.Drawing.Size(94, 56);
            this.PokazWszystkie.TabIndex = 3;
            this.PokazWszystkie.Text = "Odśwież listę";
            this.PokazWszystkie.UseVisualStyleBackColor = true;
            this.PokazWszystkie.Click += new System.EventHandler(this.PokazWszystkie_Click);
            // 
            // UsunSamochod
            // 
            this.UsunSamochod.Location = new System.Drawing.Point(540, 55);
            this.UsunSamochod.Name = "UsunSamochod";
            this.UsunSamochod.Size = new System.Drawing.Size(94, 56);
            this.UsunSamochod.TabIndex = 4;
            this.UsunSamochod.Text = "Usuń samochód";
            this.UsunSamochod.UseVisualStyleBackColor = true;
            this.UsunSamochod.Click += new System.EventHandler(this.UsunSamochod_Click);
            // 
            // txtWejscie
            // 
            this.txtWejscie.Location = new System.Drawing.Point(209, 88);
            this.txtWejscie.Name = "txtWejscie";
            this.txtWejscie.Size = new System.Drawing.Size(306, 20);
            this.txtWejscie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(205, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj id samochodu który chesz usunąć";
            // 
            // txtWyjscie
            // 
            this.txtWyjscie.AutoSize = true;
            this.txtWyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtWyjscie.Location = new System.Drawing.Point(205, 120);
            this.txtWyjscie.Name = "txtWyjscie";
            this.txtWyjscie.Size = new System.Drawing.Size(0, 20);
            this.txtWyjscie.TabIndex = 7;
            this.txtWyjscie.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsunSamochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 380);
            this.Controls.Add(this.txtWyjscie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWejscie);
            this.Controls.Add(this.UsunSamochod);
            this.Controls.Add(this.PokazWszystkie);
            this.Controls.Add(this.WyswietlDG1);
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
        private System.Windows.Forms.Button PokazWszystkie;
        private System.Windows.Forms.Button UsunSamochod;
        private System.Windows.Forms.TextBox txtWejscie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtWyjscie;
    }
}
