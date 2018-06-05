using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Trafika : ProdavnicaX
    {

        protected string naziv;
        protected string adresa;



        public Trafika(string naziv, string adresa)
        {
            this.naziv = naziv;
            this.adresa = adresa;
        }


    }
}
