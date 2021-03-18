using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Konyv
    {
        private string kod;
        private string szerzo;
        private string cim;
        private int kiadaseve;
        private int ar;
        private string isbn;

        public string Kod { get => kod; set => kod = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Kiadaseve { get => kiadaseve; set => kiadaseve = value; }
        public int Ar { get => ar; set => ar = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public Konyv(string kod, string szerzo, string cim, int kiadaseve, int ar, string isbn)
        {
            this.kod = kod;
            this.szerzo = szerzo;
            this.cim = cim;
            this.kiadaseve = kiadaseve;
            this.ar = ar;
            this.isbn = isbn;
        }
        public override string ToString()
        {
            return szerzo + ":" + cim;
        }
    }
}
