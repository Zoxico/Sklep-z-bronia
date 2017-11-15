using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Projekt
{

    public partial class Form1 : Form
    {
        public ArrayList DostepneProdukty = new ArrayList();

        public bool trybAdmina = false;
        public string Nazwa = "";
        public int licznik = 8;
        public int jesliDodano = 0;

        public string Wymiana
        {
            get { return Nazwa; }
            set { Nazwa = value; }
        }

        public Form1()
        {


            #region
            BronBiala mora = new BronBiala(
                "węglowa",
                "z głownią stałą", "0",
                "TAK",
                "150.0",
                "50.0",
                "Mora", "Classic No.1",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/Mora.jpg",
                "Klasyka wśród noży bushcraftowych i myśliwskich. " +
                "Nóż Mora Classic No.1 to szwedzki, praktyczny nóż" +
                " użytkowy wykonany z wysoko węglowej stali, która" +
                " gwarantuje twardość i odporność na tępienie. Rękojeść" +
                " noża wykonana z barwionego i olejowanego drewna brzozy. " +
                "W komplecie pochwa z tworzywa sztucznego.");
            DostepneProdukty.Add(mora);

            BronBiala bm42 = new BronBiala(
                "154CM",
                "motylkowy, balisong", "1",
                "NIE",
                "120.0",
                "1500.0",
                "Benchmade", "42",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/bm42.jpg",
                "Kultowy balisong firmy Benchmade.");
            DostepneProdukty.Add(bm42);

            BronBiala glock78 = new BronBiala(
                "55HRC",
                "z głownią stałą", "2",
                "TAK",
                "206.0",
                "120.0",
                "Glock", "FM78",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/glockfm78.jpg",
                "Duży nóż szturmowy, będący na wyposażeniu wielu armii na świecie," +
                " m.in. Polski i Austrii. Jego producentem jest firma Glock - ta" +
                " sama, która stworzyła legendarną serię pistoletów 9 mm. Nóż został" +
                " opracowany w 1975 roku, a od 1976 roku jest oficjalnym nożem austriackiej armii. ");
            DostepneProdukty.Add(glock78);

            BronBiala sanrenmu = new BronBiala(
                "8Cr13MoV",
                "składany", "3",
                "TAK",
                "92.0",
                "45.0",
                "Sanrenmu", "710", 
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/sanrenmu710.jpg",
                "Kompaktowy, wykonany w całości ze stali nóż z blokadą frame lock." +
                " Atrakcyjne wykończenie i rozmiar pozwalają go zaliczyć do gentlemen" +
                "-folders, jednak jego mocna konstrukcja nie zawiedzie podczas prac" +
                " domowych i outdoorowych");
            DostepneProdukty.Add(sanrenmu);

            BronStrzelnicza glock19 = new BronStrzelnicza(
                "15",
                "pistolet", "4",
                "TAK",
                "600.0",
                "2500.0",
                "Glock", "19",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/glock19.jpg",
                "Pistolet GLOCK jest uniwersalnym rozwiązaniem dla osób " +
                "które szukają prostej i kompaktowej konstrukcji.");
            DostepneProdukty.Add(glock19);

            BronStrzelnicza beretta92 = new BronStrzelnicza(
                "15",
                "pistolet", "5",
                "TAK",
                "950.0",
                "5000.0",
                "Beretta", "92",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/beretta92.jpg",
                "Pistolet Beretta 92FS jest bronią samopowtarzalną. Działa na " +
                "zasadzie krótkiego odrzutu lufy. Zamek ryglowany ryglem wahliwym. " +
                "Mechanizm spustowy SA/DA.");
            DostepneProdukty.Add(beretta92);

            BronStrzelnicza ak47 = new BronStrzelnicza(
                "30",
                "karabin", "6",
                "TAK",
                "3800.0",
                "10800.0",
                "AK", "47",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/ak47.jpg",
                "Potocznie kałasznikow, karabinek automatyczny konstrukcji radzieckiej" +
                " z okresu po II wojnie światowej");
            DostepneProdukty.Add(ak47);





            #endregion
            BronStrzelnicza m16 = new BronStrzelnicza("30", "karabin", "7", "TAK", "3000.0", "11200.0", "M", "16",
                "C:/Users/Zoxico/Documents/Visual Studio 2015/Projects/Projekt/Projekt/m16.png",
                "Amerykański karabin automatyczny skonstruowany przez\n Eugene Stonera.");
            DostepneProdukty.Add(m16);


            //a(int tWielkoscMag, string tTyp, bool tCzyDost, double tWaga,
            //                   double tCena, string tFirma, string tModel, string tObrazek, string tOpis)

            InitializeComponent();
            btnDodaj2.Visible = false;
            btnDodajProdukt.Visible = false;
            btnUsun.Visible = false;
            btnZmienDost.Visible = false;
            btnWyczyscDane.Visible = false;
            txtTyp1.Visible = false;
            txtTyp2.Visible = false;
            txtStalOstrza.Visible = false;
            txtWlkMag.Visible = false;


            // lOpis.Text = Convert.ToString(listaProduktow.SelectedIndex);
            listaProduktow.SelectedIndex = 0;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(listaProduktow.SelectedIndex);
            if (listaProduktow.SelectedIndex > 7) jesliDodano = 1;
            else                                  jesliDodano = 0;

            if (listaProduktow.SelectedIndex >= 0)
                if (DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] is BronBiala)
                {
                    BronBiala tmp = (BronBiala)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                    lOpis.Text = tmp.opis;
                    lNazwa.Text = tmp.firma + " " + tmp.model;
                    lDane.Text = "Stal ostrza: " + tmp.stalOstrza + "\n" +
                                 "Waga: " + tmp.waga + "\n" +
                                 "Typ: " + tmp.typ + "\n" +
                                 "Dostępny: " + tmp.czyDostepny;
                    pictureBox1.ImageLocation = tmp.obrazek;
                    lCena.Text = tmp.cena + "0 ZŁ";
                }
                else
                {
                    BronStrzelnicza tmp = (BronStrzelnicza)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                    lOpis.Text = tmp.opis;
                    lNazwa.Text = tmp.firma + " " + tmp.model;
                    lDane.Text = "Pojemność magazynka: " + Convert.ToString(tmp.wielkoscMag) + "\n" +
                                 "Waga: " + tmp.waga + "\n" +
                                 "Typ: " + tmp.typ + "\n" +
                                 "Dostępny: " + tmp.czyDostepny;
                    pictureBox1.ImageLocation = tmp.obrazek;
                    lCena.Text = tmp.cena + "0 ZŁ";
                }



        }

        private void DodajNowyProdukt(object sender, EventArgs e)
        { 
            NowyWindow okienko = new NowyWindow();
            okienko.ShowDialog();

            if (okienko.b_tmp3)
            {
                okienko.tmp1.id = licznik.ToString();
                DostepneProdukty.Add(okienko.tmp1);
                Nazwa = Convert.ToString(licznik) + ". " + okienko.tmp1.firma + " " + okienko.tmp1.model;
                listaProduktow.Items.Add(Nazwa);
            }
            else
            {
                okienko.tmp2.id = licznik.ToString();
                DostepneProdukty.Add(okienko.tmp2);
                Nazwa = Convert.ToString(licznik) + ". " + okienko.tmp2.firma + " " + okienko.tmp2.model;
                listaProduktow.Items.Add(Nazwa);
            }

            licznik++; 
            jesliDodano = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaProduktow.Items.Add(Nazwa);
        }

        private void btnAdminONOFF_Click(object sender, EventArgs e)
        {
            // kartaDodajNowy.Locked = true;
            trybAdmina = true;
            btnDodaj2.Visible = true;
            btnDodajProdukt.Visible = true;
            btnUsun.Visible = true;
            btnZmienDost.Visible = true;
            btnWyczyscDane.Visible = true;
        }

        private void btnDodaj2_Click(object sender, EventArgs e)
        {
            
            if (radioBronBiala.Checked == true)
            {
                BronBiala nowaBron = new BronBiala(txtStalOstrza.Text, txtTyp2.Text, licznik.ToString(), txtCzyDst.Text,
                                                   txtWaga.Text, txtCena.Text,
                                                   txtFirma.Text, txtModel.Text, txtObrazek.Text.Replace('/','\\'), txtOpis.Text);
                DostepneProdukty.Add(nowaBron);
            }
            else
            {
                BronStrzelnicza nowaBron = new BronStrzelnicza( txtWlkMag.Text, txtTyp1.Text, licznik.ToString(), txtCzyDst.Text,
                                                               txtWaga.Text, txtCena.Text,
                                                               txtFirma.Text, txtModel.Text, txtObrazek.Text, txtOpis.Text);

                DostepneProdukty.Add(nowaBron);
            }

            Nazwa = Convert.ToString(licznik) + ". " + txtFirma.Text + " " + txtModel.Text;
            listaProduktow.Items.Add(Nazwa);
            licznik++;
            jesliDodano = 1;


        }

        private void radioBronBiala_CheckedChanged(object sender, EventArgs e)
        {
            txtTyp1.Visible = false;
            txtTyp2.Visible = true;
            txtStalOstrza.Visible = true;
            txtWlkMag.Visible = false;
        }

        private void radioBronStrzel_CheckedChanged(object sender, EventArgs e)
        {
            txtTyp1.Visible = true;
            txtTyp2.Visible = false;
            txtStalOstrza.Visible = false;
            txtWlkMag.Visible = true;
        }

        private void btnDoPliku_Click(object sender, EventArgs e)
        {
            StreamWriter swBB = new StreamWriter("BronBiala.txt");
            for (int i = 0; i < licznik; i++)
                if (DostepneProdukty[i] is BronBiala)
                    ((BronBiala)(DostepneProdukty[i])).ZapiszDoPliku(swBB);
            swBB.Close();

            StreamWriter swBS = new StreamWriter("BronStrzelnicza.txt");
            for (int i = 0; i < licznik; i++)
                if (DostepneProdukty[i] is BronStrzelnicza) 
                    ((BronStrzelnicza)(DostepneProdukty[i])).ZapiszDoPliku(swBS);
            swBS.Close();

            MessageBox.Show("Zapisano.");

        }

        private void btnZPliku_Click(object sender, EventArgs e)
        {
            StreamReader srBB = new StreamReader("BronBiala.txt");

            while (!srBB.EndOfStream)
            {
                BronBiala bb = new BronBiala(srBB.ReadLine(), srBB.ReadLine(), srBB.ReadLine(),
                                             srBB.ReadLine(), srBB.ReadLine(), srBB.ReadLine(), 
                                             srBB.ReadLine(), srBB.ReadLine(), srBB.ReadLine(), srBB.ReadLine());
                DostepneProdukty.Add(bb);
                listaProduktow.Items.Add(bb.firma + bb.model);
                licznik++;
            }
            srBB.Close();

            StreamReader srBS = new StreamReader("BronStrzelnicza.txt");

            while (!srBS.EndOfStream)
            {
                BronStrzelnicza bs = new BronStrzelnicza(srBS.ReadLine(), srBS.ReadLine(), srBS.ReadLine(),
                                                         srBS.ReadLine(), srBS.ReadLine(), srBS.ReadLine(), 
                                                         srBS.ReadLine(), srBS.ReadLine(), srBS.ReadLine(), srBS.ReadLine());
                listaProduktow.Items.Add(bs.firma + bs.model);
                DostepneProdukty.Add(bs);
                licznik++;
            }
            srBS.Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (listaProduktow.SelectedIndex > 7) jesliDodano = 1;
            else jesliDodano = 0;
            DostepneProdukty.RemoveAt(listaProduktow.SelectedIndex - jesliDodano);
            listaProduktow.Items.RemoveAt(listaProduktow.SelectedIndex);

        }

        private void btnZmienDost_Click(object sender, EventArgs e)
        {
            if (listaProduktow.SelectedIndex > 7) jesliDodano = 1;
            else jesliDodano = 0;
            if (DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] is BronBiala)
            {
                BronBiala tmp = (BronBiala)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                tmp.ZmienDostepnosc();
                DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] = tmp;
                
            }
            else
            {
                BronStrzelnicza tmp = (BronStrzelnicza)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                tmp.ZmienDostepnosc();
                DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] = tmp;
            }

        }

        private void btnWyczyscDane_Click(object sender, EventArgs e)
        {
            if (listaProduktow.SelectedIndex > 7) jesliDodano = 1;
            else jesliDodano = 0;
            if (DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] is BronBiala)
            {
                BronBiala tmp = (BronBiala)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                tmp.WyczyscDane();
                DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] = tmp;

            }
            else
            {
                BronStrzelnicza tmp = (BronStrzelnicza)DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano];
                tmp.WyczyscDane();
                DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] = tmp;
            }
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            if (DostepneProdukty[listaProduktow.SelectedIndex - jesliDodano] is BronBiala)
                MessageBox.Show("KUPIONO " + ((BronBiala)DostepneProdukty[listaProduktow.SelectedIndex]).firma + " "
                                           + ((BronBiala)DostepneProdukty[listaProduktow.SelectedIndex]).model);
            else
                MessageBox.Show("KUPIONO " + ((BronStrzelnicza)DostepneProdukty[listaProduktow.SelectedIndex]).firma + " "
                                           + ((BronStrzelnicza)DostepneProdukty[listaProduktow.SelectedIndex]).model);
        }

        private void btnKup_Enter(object sender, EventArgs e)
        {
            btnKup_Click(sender, e);
        }
    }
}
