using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class FizickoLice : Klijent
    {

        protected int brLicne;
        protected string imePrezime;

        public FizickoLice(string imePrezime, string adresa, int BrLicne) : base (adresa)
        {
            this.imePrezime = imePrezime;
            this.brLicne = BrLicne;
        }

       

        public int BrLicneKarte
        {
            get { return brLicne; }
            set { brLicne = value; }
        }

        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; }
        }


        public override string ToStringKlijent()
        {
            return this.imePrezime + " " + this.Adreasa;
        }

    }
}
