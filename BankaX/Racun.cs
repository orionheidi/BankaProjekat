using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Racun
    {

        protected static int racun = 0;

        protected string brRacuna;

        protected Banka banka;

        protected List<Kartica> kartice = new List<Kartica>();

        protected double stanjeRacuna;

        public string BrRacuna
        {
            get { return brRacuna; }
            set { brRacuna = value; }
        }

        public Banka Banka
        {
            get { return banka; }
            set { banka = value; }
        }


        public double Stanje
        {
            get { return stanjeRacuna; }
            set { stanjeRacuna = value; }
        }

        public List<Kartica> Kartice
        {
            get { return kartice; }
            set { kartice = value; }
        }



        public Racun()
        {
            Kartica[] kartice = new Kartica[10];
        }

        public Racun(string brRacuna)
        {
            this.brRacuna = brRacuna;

        }

        public Racun(string brRacuna, Banka banka)
        {
            this.brRacuna = brRacuna;
            this.banka = banka;
        }

        public double dodajIznos(double iznos)
        {

            double noviIznos = stanjeRacuna + iznos;

            return noviIznos;

        }

        public double skiniNovac(double iznos)
        {

            return stanjeRacuna = 0.0;

        }

        public Kartica pronadjKarticu(int id)
        {
            for (int i = 0; i < kartice.Count; i++)
            {
                if (kartice[i].Id == id)
                {
                    Kartica newK = kartice[i];

                    return newK;

                }
            }
            return null;
        }


        public void dodajKarticu(Kartica kartica)
        {
            kartice.Add(kartica);
            Console.WriteLine("Dodata je kartica : " + kartica.ToStringKartica());

        }

        public string ToStringRacun()
        {
            return "Broj Racuna: " + BrRacuna + " Stanje : " + Stanje;
        }
    }
}