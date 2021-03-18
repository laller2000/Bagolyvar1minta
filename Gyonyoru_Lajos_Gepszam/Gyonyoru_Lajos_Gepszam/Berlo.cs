using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Berlo
    {
        private int id;
        private string nev;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }

        public Berlo(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
