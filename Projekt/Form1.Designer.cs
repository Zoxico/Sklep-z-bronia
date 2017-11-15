namespace Projekt
{
    partial class Form1
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
            this.listaProduktow = new System.Windows.Forms.ListBox();
            this.lNazwa = new System.Windows.Forms.Label();
            this.lDane = new System.Windows.Forms.Label();
            this.btnKup = new System.Windows.Forms.Button();
            this.btnDodajProdukt = new System.Windows.Forms.Button();
            this.btnAdminONOFF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kartaSklep = new System.Windows.Forms.TabPage();
            this.lOpis = new System.Windows.Forms.TextBox();
            this.lCena = new System.Windows.Forms.Label();
            this.kartaDodajNowy = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWlkMag = new System.Windows.Forms.TextBox();
            this.txtTyp1 = new System.Windows.Forms.TextBox();
            this.txtStalOstrza = new System.Windows.Forms.TextBox();
            this.txtTyp2 = new System.Windows.Forms.TextBox();
            this.btnDodaj2 = new System.Windows.Forms.Button();
            this.radioBronStrzel = new System.Windows.Forms.RadioButton();
            this.radioBronBiala = new System.Windows.Forms.RadioButton();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtObrazek = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.txtCzyDst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDoPliku = new System.Windows.Forms.Button();
            this.btnZPliku = new System.Windows.Forms.Button();
            this.btnWyczyscDane = new System.Windows.Forms.Button();
            this.btnZmienDost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.kartaSklep.SuspendLayout();
            this.kartaDodajNowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProduktow
            // 
            this.listaProduktow.FormattingEnabled = true;
            this.listaProduktow.Items.AddRange(new object[] {
            "0. Mora Classic No.1",
            "1. Benchmade 42",
            "2. Glock FM 78",
            "3. Sanrenmu 710",
            "4. Glock 19",
            "5. Beretta 92FS",
            "6. AK-47",
            "7. M16"});
            this.listaProduktow.Location = new System.Drawing.Point(12, 9);
            this.listaProduktow.Name = "listaProduktow";
            this.listaProduktow.Size = new System.Drawing.Size(143, 277);
            this.listaProduktow.TabIndex = 0;
            this.listaProduktow.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lNazwa
            // 
            this.lNazwa.AutoSize = true;
            this.lNazwa.Location = new System.Drawing.Point(6, 3);
            this.lNazwa.Name = "lNazwa";
            this.lNazwa.Size = new System.Drawing.Size(35, 13);
            this.lNazwa.TabIndex = 1;
            this.lNazwa.Text = "label1";
            // 
            // lDane
            // 
            this.lDane.AutoSize = true;
            this.lDane.Location = new System.Drawing.Point(215, 19);
            this.lDane.Name = "lDane";
            this.lDane.Size = new System.Drawing.Size(35, 13);
            this.lDane.TabIndex = 2;
            this.lDane.Text = "label2";
            // 
            // btnKup
            // 
            this.btnKup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKup.Location = new System.Drawing.Point(199, 334);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(157, 42);
            this.btnKup.TabIndex = 4;
            this.btnKup.Text = "KUP";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            this.btnKup.Enter += new System.EventHandler(this.btnKup_Enter);
            // 
            // btnDodajProdukt
            // 
            this.btnDodajProdukt.Location = new System.Drawing.Point(12, 377);
            this.btnDodajProdukt.Name = "btnDodajProdukt";
            this.btnDodajProdukt.Size = new System.Drawing.Size(143, 40);
            this.btnDodajProdukt.TabIndex = 6;
            this.btnDodajProdukt.Text = "Dodaj nowy produkt";
            this.btnDodajProdukt.UseVisualStyleBackColor = true;
            this.btnDodajProdukt.Click += new System.EventHandler(this.DodajNowyProdukt);
            // 
            // btnAdminONOFF
            // 
            this.btnAdminONOFF.Location = new System.Drawing.Point(438, 424);
            this.btnAdminONOFF.Name = "btnAdminONOFF";
            this.btnAdminONOFF.Size = new System.Drawing.Size(114, 37);
            this.btnAdminONOFF.TabIndex = 7;
            this.btnAdminONOFF.Text = "Włącz tryb Admina";
            this.btnAdminONOFF.UseVisualStyleBackColor = true;
            this.btnAdminONOFF.Click += new System.EventHandler(this.btnAdminONOFF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt.Properties.Resources.mefe;
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kartaSklep);
            this.tabControl1.Controls.Add(this.kartaDodajNowy);
            this.tabControl1.Location = new System.Drawing.Point(179, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 408);
            this.tabControl1.TabIndex = 8;
            // 
            // kartaSklep
            // 
            this.kartaSklep.Controls.Add(this.lOpis);
            this.kartaSklep.Controls.Add(this.lCena);
            this.kartaSklep.Controls.Add(this.lNazwa);
            this.kartaSklep.Controls.Add(this.lDane);
            this.kartaSklep.Controls.Add(this.pictureBox1);
            this.kartaSklep.Controls.Add(this.btnKup);
            this.kartaSklep.Location = new System.Drawing.Point(4, 22);
            this.kartaSklep.Name = "kartaSklep";
            this.kartaSklep.Padding = new System.Windows.Forms.Padding(3);
            this.kartaSklep.Size = new System.Drawing.Size(362, 382);
            this.kartaSklep.TabIndex = 0;
            this.kartaSklep.Text = "SKLEP";
            this.kartaSklep.UseVisualStyleBackColor = true;
            // 
            // lOpis
            // 
            this.lOpis.Location = new System.Drawing.Point(9, 156);
            this.lOpis.Multiline = true;
            this.lOpis.Name = "lOpis";
            this.lOpis.ReadOnly = true;
            this.lOpis.Size = new System.Drawing.Size(350, 139);
            this.lOpis.TabIndex = 8;
            // 
            // lCena
            // 
            this.lCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCena.AutoSize = true;
            this.lCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCena.Location = new System.Drawing.Point(22, 334);
            this.lCena.Name = "lCena";
            this.lCena.Size = new System.Drawing.Size(86, 31);
            this.lCena.TabIndex = 7;
            this.lCena.Text = "label2";
            this.lCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kartaDodajNowy
            // 
            this.kartaDodajNowy.Controls.Add(this.label10);
            this.kartaDodajNowy.Controls.Add(this.label9);
            this.kartaDodajNowy.Controls.Add(this.label8);
            this.kartaDodajNowy.Controls.Add(this.label7);
            this.kartaDodajNowy.Controls.Add(this.label6);
            this.kartaDodajNowy.Controls.Add(this.label5);
            this.kartaDodajNowy.Controls.Add(this.label4);
            this.kartaDodajNowy.Controls.Add(this.txtWlkMag);
            this.kartaDodajNowy.Controls.Add(this.txtTyp1);
            this.kartaDodajNowy.Controls.Add(this.txtStalOstrza);
            this.kartaDodajNowy.Controls.Add(this.txtTyp2);
            this.kartaDodajNowy.Controls.Add(this.btnDodaj2);
            this.kartaDodajNowy.Controls.Add(this.radioBronStrzel);
            this.kartaDodajNowy.Controls.Add(this.radioBronBiala);
            this.kartaDodajNowy.Controls.Add(this.txtOpis);
            this.kartaDodajNowy.Controls.Add(this.txtObrazek);
            this.kartaDodajNowy.Controls.Add(this.txtModel);
            this.kartaDodajNowy.Controls.Add(this.txtFirma);
            this.kartaDodajNowy.Controls.Add(this.txtCena);
            this.kartaDodajNowy.Controls.Add(this.txtWaga);
            this.kartaDodajNowy.Controls.Add(this.txtCzyDst);
            this.kartaDodajNowy.Location = new System.Drawing.Point(4, 22);
            this.kartaDodajNowy.Name = "kartaDodajNowy";
            this.kartaDodajNowy.Padding = new System.Windows.Forms.Padding(3);
            this.kartaDodajNowy.Size = new System.Drawing.Size(362, 382);
            this.kartaDodajNowy.TabIndex = 1;
            this.kartaDodajNowy.Text = "DODAJ NOWY";
            this.kartaDodajNowy.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Opis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ścieżka do obrazka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Firma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Waga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Czy dostępny: (TAK/NIE)";
            // 
            // txtWlkMag
            // 
            this.txtWlkMag.Location = new System.Drawing.Point(133, 235);
            this.txtWlkMag.Name = "txtWlkMag";
            this.txtWlkMag.Size = new System.Drawing.Size(115, 20);
            this.txtWlkMag.TabIndex = 24;
            this.txtWlkMag.Text = "Wielkośc Magazynka";
            // 
            // txtTyp1
            // 
            this.txtTyp1.Location = new System.Drawing.Point(6, 235);
            this.txtTyp1.Name = "txtTyp1";
            this.txtTyp1.Size = new System.Drawing.Size(121, 20);
            this.txtTyp1.TabIndex = 23;
            this.txtTyp1.Text = "Typ";
            // 
            // txtStalOstrza
            // 
            this.txtStalOstrza.Location = new System.Drawing.Point(133, 261);
            this.txtStalOstrza.Name = "txtStalOstrza";
            this.txtStalOstrza.Size = new System.Drawing.Size(115, 20);
            this.txtStalOstrza.TabIndex = 22;
            this.txtStalOstrza.Text = "Stal ostrza";
            // 
            // txtTyp2
            // 
            this.txtTyp2.Location = new System.Drawing.Point(6, 261);
            this.txtTyp2.Name = "txtTyp2";
            this.txtTyp2.Size = new System.Drawing.Size(121, 20);
            this.txtTyp2.TabIndex = 21;
            this.txtTyp2.Text = "Typ";
            // 
            // btnDodaj2
            // 
            this.btnDodaj2.Location = new System.Drawing.Point(255, 284);
            this.btnDodaj2.Name = "btnDodaj2";
            this.btnDodaj2.Size = new System.Drawing.Size(100, 92);
            this.btnDodaj2.TabIndex = 20;
            this.btnDodaj2.Text = "Dodaj";
            this.btnDodaj2.UseVisualStyleBackColor = true;
            this.btnDodaj2.Click += new System.EventHandler(this.btnDodaj2_Click);
            // 
            // radioBronStrzel
            // 
            this.radioBronStrzel.AutoSize = true;
            this.radioBronStrzel.Location = new System.Drawing.Point(256, 31);
            this.radioBronStrzel.Name = "radioBronStrzel";
            this.radioBronStrzel.Size = new System.Drawing.Size(99, 17);
            this.radioBronStrzel.TabIndex = 19;
            this.radioBronStrzel.TabStop = true;
            this.radioBronStrzel.Text = "Broń strzelnicza";
            this.radioBronStrzel.UseVisualStyleBackColor = true;
            this.radioBronStrzel.CheckedChanged += new System.EventHandler(this.radioBronStrzel_CheckedChanged);
            // 
            // radioBronBiala
            // 
            this.radioBronBiala.AutoSize = true;
            this.radioBronBiala.Location = new System.Drawing.Point(256, 7);
            this.radioBronBiala.Name = "radioBronBiala";
            this.radioBronBiala.Size = new System.Drawing.Size(74, 17);
            this.radioBronBiala.TabIndex = 18;
            this.radioBronBiala.TabStop = true;
            this.radioBronBiala.Text = "Broń biała";
            this.radioBronBiala.UseVisualStyleBackColor = true;
            this.radioBronBiala.CheckedChanged += new System.EventHandler(this.radioBronBiala_CheckedChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.AcceptsReturn = true;
            this.txtOpis.Location = new System.Drawing.Point(6, 311);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(244, 65);
            this.txtOpis.TabIndex = 17;
            // 
            // txtObrazek
            // 
            this.txtObrazek.Location = new System.Drawing.Point(256, 185);
            this.txtObrazek.Name = "txtObrazek";
            this.txtObrazek.Size = new System.Drawing.Size(100, 20);
            this.txtObrazek.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(256, 158);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 15;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(256, 131);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(100, 20);
            this.txtFirma.TabIndex = 14;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(256, 104);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 13;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(256, 78);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(100, 20);
            this.txtWaga.TabIndex = 12;
            // 
            // txtCzyDst
            // 
            this.txtCzyDst.Location = new System.Drawing.Point(256, 52);
            this.txtCzyDst.Name = "txtCzyDst";
            this.txtCzyDst.Size = new System.Drawing.Size(100, 20);
            this.txtCzyDst.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(13, 424);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(142, 37);
            this.btnUsun.TabIndex = 9;
            this.btnUsun.Text = "Usuń produkt";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDoPliku
            // 
            this.btnDoPliku.Location = new System.Drawing.Point(183, 424);
            this.btnDoPliku.Name = "btnDoPliku";
            this.btnDoPliku.Size = new System.Drawing.Size(94, 37);
            this.btnDoPliku.TabIndex = 6;
            this.btnDoPliku.Text = "Do pliku";
            this.btnDoPliku.UseVisualStyleBackColor = true;
            this.btnDoPliku.Click += new System.EventHandler(this.btnDoPliku_Click);
            // 
            // btnZPliku
            // 
            this.btnZPliku.Location = new System.Drawing.Point(283, 424);
            this.btnZPliku.Name = "btnZPliku";
            this.btnZPliku.Size = new System.Drawing.Size(89, 37);
            this.btnZPliku.TabIndex = 7;
            this.btnZPliku.Text = "Z pliku";
            this.btnZPliku.UseVisualStyleBackColor = true;
            this.btnZPliku.Click += new System.EventHandler(this.btnZPliku_Click);
            // 
            // btnWyczyscDane
            // 
            this.btnWyczyscDane.Location = new System.Drawing.Point(13, 332);
            this.btnWyczyscDane.Name = "btnWyczyscDane";
            this.btnWyczyscDane.Size = new System.Drawing.Size(142, 39);
            this.btnWyczyscDane.TabIndex = 9;
            this.btnWyczyscDane.Text = "Wyczyść dane tego produktu";
            this.btnWyczyscDane.UseVisualStyleBackColor = true;
            this.btnWyczyscDane.Click += new System.EventHandler(this.btnWyczyscDane_Click);
            // 
            // btnZmienDost
            // 
            this.btnZmienDost.Location = new System.Drawing.Point(13, 293);
            this.btnZmienDost.Name = "btnZmienDost";
            this.btnZmienDost.Size = new System.Drawing.Size(142, 33);
            this.btnZmienDost.TabIndex = 10;
            this.btnZmienDost.Text = "Zmień dostępność";
            this.btnZmienDost.UseVisualStyleBackColor = true;
            this.btnZmienDost.Click += new System.EventHandler(this.btnZmienDost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 472);
            this.Controls.Add(this.btnZmienDost);
            this.Controls.Add(this.btnWyczyscDane);
            this.Controls.Add(this.btnZPliku);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoPliku);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdminONOFF);
            this.Controls.Add(this.btnDodajProdukt);
            this.Controls.Add(this.listaProduktow);
            this.Name = "Form1";
            this.Text = "SKLEP Z BRONIĄ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.kartaSklep.ResumeLayout(false);
            this.kartaSklep.PerformLayout();
            this.kartaDodajNowy.ResumeLayout(false);
            this.kartaDodajNowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaProduktow;
        private System.Windows.Forms.Label lNazwa;
        private System.Windows.Forms.Label lDane;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodajProdukt;
        private System.Windows.Forms.Button btnAdminONOFF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kartaSklep;
        private System.Windows.Forms.TabPage kartaDodajNowy;
        private System.Windows.Forms.RadioButton radioBronStrzel;
        private System.Windows.Forms.RadioButton radioBronBiala;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtObrazek;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.TextBox txtCzyDst; 
        private System.Windows.Forms.Button btnDodaj2;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtStalOstrza;
        private System.Windows.Forms.TextBox txtTyp2;
        private System.Windows.Forms.TextBox txtWlkMag;
        private System.Windows.Forms.TextBox txtTyp1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDoPliku;
        private System.Windows.Forms.Button btnZPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCena;
        private System.Windows.Forms.TextBox lOpis;
        private System.Windows.Forms.Button btnWyczyscDane;
        private System.Windows.Forms.Button btnZmienDost;
    }
}

