using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class MaestroKartica : Kartica
    {
        
        public MaestroKartica(Racun racun,int pin) : base(racun,pin)
        {
            this.racun = racun;
            this.pin = pin;
           
        }

        public MaestroKartica(Racun racun) : base(racun)
        {
            this.racun = racun;
        

        }

        public override string ToStringKartica()
        {

            string strId = id.ToString();

            return strId;
        }

    }
}
