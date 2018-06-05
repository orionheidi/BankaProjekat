using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class PravnoLice : Klijent
    {

        protected string pib;

        protected string naziv;


        public PravnoLice(string naziv, string adresa, string pib) : base(adresa)
        {
            this.naziv = naziv;
            this.pib = pib;
        }


        public string Pib
        {
            get { return pib; }
            set { pib = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

    }
}
