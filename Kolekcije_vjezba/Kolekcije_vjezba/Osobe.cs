using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_vjezba
{
    internal class Osobe
    {
        string ime;
        string prezime;
        string godRod;
        string spol;
 
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string GodRod { get => godRod; set => godRod = value; }
        public string Spol { get => spol; set => spol = value; }

        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t"
                + this.godRod + "\t" + this.spol;
            return ispis;
        }

        public Osobe(string ime, string prezime,string godRod, string spol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.GodRod = godRod;
            this.Spol = spol;
        }
    }
}
