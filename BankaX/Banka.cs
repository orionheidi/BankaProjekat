using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Banka
    {

        protected static int racunId = 0;

        protected string naziv;

        protected string brRacun;

        protected string zemlja;

        protected List<Klijent> klijenti = new List<Klijent>();

        protected List<Racun> racuni = new List<Racun>();


        public int RacunId
        {
            get { return racunId; }
            set { racunId = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string BrRacuna
        {
            get { return brRacun; }
            set { brRacun = value; }
        }

        public string Zemlja
        {
            get { return zemlja; }
            set { zemlja = value; }
        }




        public Banka()
        {
            racunId++;
        }


        public Banka(List<Racun> racuni)
        {
            this.racuni = racuni;
            racunId++;
        }



        public Banka(string naziv, string zemlja)
        {
            this.naziv = naziv;
            this.zemlja = zemlja;

        }

      /*  public void dodajRacun(Racun racun)
        {
            this.racuni.Add(racun);
        }*/


        public void KreirajRacun(Klijent klijent, string racun)
        {

            string pin = "1234";


            if (racun == "devizni")
            {
                brRacun = "222" + racunId;
             

                DevizniRacun devr = new DevizniRacun(brRacun, new Banka());
                racuni.Add(devr);
                klijent.DodajRacun(devr);
                Console.WriteLine("Kreiran je devizni racun: " + brRacun + ", sa pinom: " + pin);


            }

            else if (racun == "dinarski")
            {

                brRacun = "111" + racunId;
              

                DinarskiRacun dir = new DinarskiRacun(brRacun, new Banka());

                racuni.Add(dir);
                klijent.DodajRacun(dir);


                Console.WriteLine("Kreiran je dinarski racun: " + brRacun + ", sa pinom: " + pin);
            }

        }

    


        public void UplatiNovac(string brojRacuna, double iznos)
        {
            bool postoji = false;

            for (int i = 0; i < racuni.Count; i++)
            {

                if (racuni[i].BrRacuna == brojRacuna)
                {
                    racuni[i].Stanje = racuni[i].Stanje + iznos;
                    
                    Console.WriteLine("Novo stanje racuna je: " + racuni[i].Stanje);

                    postoji = true;
                }
            }

            if (postoji== false)
            {
                Console.WriteLine("Ne moze da se uplati.");
            }
            
        }

        public void dodajPunomocje(string brojRacuna, Klijent klijent)
        {
            bool postojiKlijent = false;

            for (int i = 0; i < racuni.Count; i++)
            {
                if (racuni[i].BrRacuna == brojRacuna)
                {
                    klijent.DodajRacun(racuni[i]);

                    klijenti.Add(klijent);

                    Console.WriteLine("Dodat je racun za klijenta " + klijent.ToStringKlijent());

                    postojiKlijent = true;

                    /* if (klijent is FizickoLice)
                     {

                             var fl = klijent as FizickoLice;

                         Console.WriteLine("Dodat je klijent: " + fl.ImePrezime);


                     }
                     else

                     {
                         var pl = klijent as PravnoLice;

                         Console.WriteLine("Dodat je klijent: " + pl.Naziv);

                     }*/
                 
                }
            }

            if (postojiKlijent == false)
            {
                Console.WriteLine("Racun ne postoji za datog klijenta;");
            }
        }



        public void izdajKarticu(string brojRacuna, Kartica kartica)
        {
            List<Kartica> kartice = new List<Kartica>();

            bool daLiPostoji = false;
            int index = 0;

            for (int i = 0; i < racuni.Count; i++)
            {
                if (racuni[i].BrRacuna == brojRacuna)
                {

                    index = i;
                    daLiPostoji = true;                 

                }

            }
             

            if (daLiPostoji)
            {
                if(kartica is MaestroKartica)
                {
                    Kartica karticaNew = new MaestroKartica(racuni[index]);

                    racuni[index].dodajKarticu(karticaNew);
                    Console.WriteLine("Maestro Kartica : " + karticaNew.Racun.BrRacuna + " je dodata." + " na racun u banci " + toStringBanka());


                }
            }
            else
            {
                Console.WriteLine("Racun ne postoji;");
            }

        }


        public string toStringBanka()
        {
            return this.naziv;
        }

    }
}

