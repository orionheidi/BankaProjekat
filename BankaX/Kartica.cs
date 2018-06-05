using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Kartica
    {
        protected static int brojac = 0;
        protected int id;
        protected int pin;
        protected Racun racun;

        public Kartica()
        {
            this.id = brojac++;
        }

        public Kartica(Racun racun)
        {
            this.racun = racun;
            this.id = brojac++;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        public Racun Racun
        {
            get { return racun; }
            set { racun = value; }
        }

        public Kartica(Racun racun, int pin)
        {
         
            this.racun = racun;
            this.pin = pin;
            this.id = brojac++;
        }

        public bool skiniNovacSaRauna(double iznos)
        {

            if (Racun.Stanje - iznos >= 0){

                double noviIznos = Racun.Stanje - iznos;
                Console.WriteLine("Novo stanje posle skidanja: " + noviIznos);
                return true;
            }

            return false;

        }

        public virtual string ToStringKartica()
        {

            string strId = id.ToString();

            return strId;
        }


    }
}

