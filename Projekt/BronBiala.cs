using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    public class BronBiala : Bron
    {
     // friend class Produkt;
        public string stalOstrza;
        public string typ;

        public BronBiala(string tStalOstrza, string tTyp, string tId, string tCzyDost, string tWaga,
                         string tCena, string tFirma, string tModel, string tObrazek, string tOpis) 
            : base(tId, tCzyDost, tWaga, tCena, tFirma, tModel, tObrazek, tOpis)
        {
         
            stalOstrza = tStalOstrza;
            typ = tTyp;

        }

        public void ZapiszDoPliku(StreamWriter sw)
        {
            sw.WriteLine(stalOstrza);
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

        public   BronBiala() : base ()
        {

        }
                ~BronBiala() { }
    }
}
