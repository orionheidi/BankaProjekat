using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class SuperMarket : ProdavnicaX, IElekstronskaKartica

    {
        protected string naziv;
        protected string adresa;
        
        protected List<Kartica> kartice = new List<Kartica>();

       
        public SuperMarket(string naziv, string adresa)
        {
            this.naziv = naziv;
            this.adresa = adresa;
        }


        public bool skiniNovacSaRauna(Kartica kartica, double iznos)

        {
            bool skini = false;

                for (int i = 0; i < kartice.Count; i++)
                {
                    if (kartice[i].Id == kartica.Id)
                    {
                       skini =  kartica.skiniNovacSaRauna(iznos);

                       
                    }
                }
            return skini;
            }      
        
        }



    }
