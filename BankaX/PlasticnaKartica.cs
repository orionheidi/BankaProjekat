using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class PlasticnaKartica : Kartica
    {

        public PlasticnaKartica(Racun racun, int pin) : base(racun, pin)
        {
            this.racun = racun;
            this.pin = pin;
        }

    }
}
