using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Klijent
    {

        protected static int brOtvorenihRacuna = 0;

        protected string adresa;

        protected List<Racun> racuni = new List<Racun>();

        protected List<Kartica> kartice = new List<Kartica>();

        public Klijent()
        {
            Racun[] racuni = new Racun[10];
            brOtvorenihRacuna++;
        }

        public Klijent(string adresa)
        {
            this.adresa = adresa;
            brOtvorenihRacuna++;
        }

        public string Adreasa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public bool DodajRacun(Racun racun)
        {
            for (int i = 0; i < racuni.Count; i++)
            {
                if (racuni[i].BrRacuna == racun.BrRacuna)
                {
                   
                    return false;
                }
            }

            
                racuni.Add(racun);
                Console.WriteLine("Dodat je : " + racun.BrRacuna);
                return true;
            
        }



       
       public Kartica DajKarticu(int id)
        {
           

            for (int i = 0; i < racuni.Count; i++)
            {
                for (int j = 0; j < racuni[i].Kartice.Count; j++)
                {

                    if (racuni[i].Kartice[j].Id == id)

                    {


                        Kartica novaK = racuni[i].Kartice[j];

                       Console.WriteLine("Pronadjena kartica je sa id: " + novaK.Id + " , sa racuna: " + novaK.Racun.ToStringRacun() + " Klijent  " + this.ToStringKlijent());
                  
                        
                         return novaK;
 

                    }

                }
            }
            Console.WriteLine("Dzaba");

            return null;
        }




        public virtual string ToStringKlijent()
        {
            return  this.adresa;
        }



    }       
        }
    