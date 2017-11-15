using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public abstract class Bron 
    {
        public string id;
        public string czyDostepny;
        public string waga;
        public string cena;
        public string firma;
        public string model;
        public string obrazek;
        public string opis;

        public Bron(string tId, string tCzyDost, string tWaga, string tCena, string tFirma, string tModel, string tObrazek, string tOpis)
        {
            id = tId;
            czyDostepny = tCzyDost;
            waga = tWaga;
            cena = tCena;
            firma = tFirma;
            model = tModel;
            obrazek = tObrazek;
            opis = tOpis;

        }

        public Bron() { }
              ~Bron() { }

        public void ZmienDostepnosc()
        {
            if  (czyDostepny == "TAK")
                 czyDostepny =  "NIE";
            else czyDostepny =  "TAK";
        }

        public void WyczyscDane()
        {
            czyDostepny = "";
            waga = "";
            cena = "";
            firma = "";
            model = "";
            obrazek = "";
            opis = "";
        }
    }
    
}
