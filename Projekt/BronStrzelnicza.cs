using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    public class BronStrzelnicza : Bron
    {
        public string wielkoscMag;
        public string typ;

        //(Convert.ToInt32(txtWlkMag.Text), txtTyp1.Text, true,
        //Convert.ToDouble(txtWaga.Text), Convert.ToDouble(txtCena.Text),
        //txtFirma.Text, txtModel.Text, txtObrazek.Text, txtOpis.Text);
        
        public BronStrzelnicza(string tWielkoscMag, string tTyp, string tId, string tCzyDost, string tWaga,
                               string tCena, string tFirma, string tModel, string tObrazek, string tOpis) 
            : base(tId, tCzyDost, tWaga, tCena, tFirma, tModel, tObrazek, tOpis)
        {
            typ = tTyp;
            wielkoscMag = tWielkoscMag;

        }

        public void ZapiszDoPliku(StreamWriter sw)
        {
            sw.WriteLine(wielkoscMag);
            sw.WriteLine(typ);
            sw.WriteLine(id);
            sw.WriteLine(czyDostepny);
            sw.WriteLine(waga);
            sw.WriteLine(cena);
            sw.WriteLine(firma);
            sw.WriteLine(model);
            sw.WriteLine(obrazek);
            sw.WriteLine(opis);

        }
        public BronStrzelnicza() : base() { }
              ~BronStrzelnicza() { }
    }
}
