using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Kolcsonzes
    {
        private string konyvID;
        private int kolcsonzoID;
        private DateTime kivitelDatum;
        private decimal peldany;
        Konyv kony;
        Berlo berlo;

        public string KonyvID { get => konyvID; set => konyvID = value; }
        public int KolcsonzoID { get => kolcsonzoID; set => kolcsonzoID = value; }
        public DateTime KivitelDatum { get => kivitelDatum; set => kivitelDatum = value; }
        public decimal Peldany { get => peldany; set => peldany = value; }
        internal Konyv Kony { get => kony; set => kony = value; }
        internal Berlo Berlo { get => berlo; set => berlo = value; }

        public Kolcsonzes(string konyvID, int kolcsonzoID, DateTime kivitelDatum, decimal peldany)
        {
            this.konyvID = konyvID;
            this.kolcsonzoID = kolcsonzoID;
            this.kivitelDatum = kivitelDatum;
            this.peldany = peldany;
        }
        public void addKonyv(Konyv konyv)
        {
            this.Kony = konyv;
            konyvID = konyv.Kod;

        }
        public void addBerlo(Berlo berlo)
        {
            this.Berlo = berlo;
            this.kolcsonzoID = berlo.Id;
        }
        public override string ToString()
        {
            return Berlo.Nev + "->" + Kony.Szerzo + ":" + Kony.Cim+" " +(+this.peldany+" db");
        }
    }
}
