namespace Projekt
{
    partial class NowyWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCzyDst = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtObrazek = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.radioBiala = new System.Windows.Forms.RadioButton();
            this.radioStrzel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCzyDst
            // 
            this.txtCzyDst.Location = new System.Drawing.Point(172, 58);
            this.txtCzyDst.Name = "txtCzyDst";
            this.txtCzyDst.Size = new System.Drawing.Size(100, 20);
            this.txtCzyDst.TabIndex = 1;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(172, 84);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(100, 20);
            this.txtWaga.TabIndex = 2;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(172, 110);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 3;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(172, 137);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(100, 20);
            this.txtFirma.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(172, 164);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtObrazek
            // 
            this.txtObrazek.Location = new System.Drawing.Point(172, 191);
            this.txtObrazek.Name = "txtObrazek";
            this.txtObrazek.Size = new System.Drawing.Size(100, 20);
            this.txtObrazek.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.AcceptsReturn = true;
            this.txtOpis.Location = new System.Drawing.Point(12, 240);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(260, 161);
            this.txtOpis.TabIndex = 7;
            // 
            // radioBiala
            // 
            this.radioBiala.AutoSize = true;
            this.radioBiala.Location = new System.Drawing.Point(172, 13);
            this.radioBiala.Name = "radioBiala";
            this.radioBiala.Size = new System.Drawing.Size(74, 17);
            this.radioBiala.TabIndex = 8;
            this.radioBiala.TabStop = true;
            this.radioBiala.Text = "Broń biała";
            this.radioBiala.UseVisualStyleBackColor = true;
            // 
            // radioStrzel
            // 
            this.radioStrzel.AutoSize = true;
            this.radioStrzel.Location = new System.Drawing.Point(172, 37);
            this.radioStrzel.Name = "radioStrzel";
            this.radioStrzel.Size = new System.Drawing.Size(99, 17);
            this.radioStrzel.TabIndex = 9;
            this.radioStrzel.TabStop = true;
            this.radioStrzel.Text = "Broń strzelnicza";
            this.radioStrzel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Czy dostępny: (TAK/NIE)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Firma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ścieżka do obrazka";
            // 
            // NowyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 478);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioStrzel);
            this.Controls.Add(this.radioBiala);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtObrazek);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.txtCzyDst);
            this.Controls.Add(this.button1);
            this.Name = "NowyWindow";
            this.Text = "NOWY PRODUKT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCzyDst;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtObrazek;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.RadioButton radioBiala;
        private System.Windows.Forms.RadioButton radioStrzel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}