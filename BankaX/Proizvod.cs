using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Proizvod
    {

        protected string naziv;
        protected double cena;


        public Proizvod(string naziv, double cena)
        {
            this.naziv = naziv;
            this.cena = cena;
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public double Cena
        {
            get { return cena; }
            set {cena = value; }
        }

        public string ToStringProizvod()
        {
            return "Proizvod naziv: " + naziv + " Cena : " + cena;
        }
    }
}
