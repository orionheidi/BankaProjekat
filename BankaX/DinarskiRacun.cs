using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class DinarskiRacun : Racun
    {
        public DinarskiRacun(string brRacuna, Banka banka) : base(brRacuna, banka)
        {
            this.brRacuna = brRacuna;
            this.banka = banka;
        }



        public double skiniSaRacuna(double iznosDinari)
        {
            Racun racun = new Racun();

            double iznosZaVratiti;

            double trenutnoStanjeUDin = racun.Stanje * 115.0;

            if (trenutnoStanjeUDin -iznosDinari >= 0)
            {
                return iznosZaVratiti = trenutnoStanjeUDin - iznosDinari;
            }
            else
            {
                return iznosZaVratiti = 0.0;
            }

        }


        public double dodajIznosDin(double iznosDinari)
        {
            Racun racun = new Racun();

            double trenutnoStanjeUDin = racun.Stanje * 115.0 + iznosDinari;

            return trenutnoStanjeUDin;
        }

    }
}
