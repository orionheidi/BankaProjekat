using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class DevizniRacun : Racun
    {
        public DevizniRacun(string brRacuna, Banka banka) :base (brRacuna,banka)
        {
            this.brRacuna = brRacuna;
            this.banka = banka;
        }

        public DevizniRacun(string brRacuna) : base(brRacuna)
        {
            this.brRacuna = brRacuna;
            
        }


        public double skiniSaRacuna(double iznosDinari)
        {
            Racun racun = new Racun();

            double iznosZaVratiti;
            double stanjeUEvrima;

            double trenutnoStanjeUDin = racun.Stanje * 115.0;

            if(racun.Stanje > 0)
            {
                iznosZaVratiti = trenutnoStanjeUDin - iznosDinari;
                stanjeUEvrima = iznosZaVratiti / 115.0;
                return stanjeUEvrima;
            }
            else
            {
                return stanjeUEvrima = 0.0;
            }
            
        }

        public double dodajIznosDin(double iznosDinari)
        {
            Racun racun = new Racun();

            double trenutnoStanjeUDin = racun.Stanje * 115.0 + iznosDinari;

            double stanjeUEurima = trenutnoStanjeUDin / 115.0;

            return stanjeUEurima;
        }
    }
}
