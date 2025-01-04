using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kariproj
{
    internal class Ajandek
    {
        //Ajándék neve: "RC autó"
        //Ár: 12 000 Ft
        //Kategória: "játék"

        private string nev;
        private int ar;
        private string kategoria;

        public Ajandek(string nev, int ar, string kategoria)
        {
            this.nev = nev;
            this.ar = ar;
            this.kategoria = kategoria;
        }

     
        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }

        public override string ToString()
        {
            return $"{this.nev} {this.ar} Ft {this.kategoria}";
        }



    }
}
