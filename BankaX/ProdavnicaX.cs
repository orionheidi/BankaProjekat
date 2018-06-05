using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class ProdavnicaX
    {
        protected static int brDodatihProizvoda = 0;

        List<Proizvod> proizvodi;



        public ProdavnicaX()
        {
            proizvodi = new List<Proizvod>(100);

            brDodatihProizvoda++;
        }

        public List<Proizvod> Proizvodi
        {
            get { return proizvodi; }
            set { proizvodi = value; }
        }



        public void dodajProizvod(Proizvod proizvod)
        {
            bool dodatProizvod = true;

            for (int i = 0; i < proizvodi.Count; i++)
            {
                if (proizvodi[i].Naziv == proizvod.Naziv)
                {

                    dodatProizvod = false;

                }
            }

            if (dodatProizvod == true)
            {

                proizvodi.Add(proizvod);

            }

        }

        public double DajCenu(string naziv)

        {

            for (int i = 0; i < proizvodi.Count; i++)
            {
                if (proizvodi[i].Naziv == naziv)
                {
                    double cenaProizvoda = proizvodi[i].Cena;

                    return cenaProizvoda;
                }
            }
            return 0;

        }

        public bool KupiProizvode(Kartica kartica, List<Proizvod> proizvodi)
        {

            //bool kupljeno = false;

            double sumaCena = 0;

            int index = 0;


            List<ProdavnicaX> prodavnice = new List<ProdavnicaX>();


            for (int i = 0; i < prodavnice.Count; i++)
           {
                if (prodavnice[i] is SuperMarket )
                {

                    for (int j = 0; j < prodavnice[i].proizvodi.Count; j++)
                    {

                        sumaCena = sumaCena + prodavnice[i].proizvodi[j].Cena;

                        index = j;

                        //var kast = this as SuperMarket;
                        //kupljeno = kast.skiniNovacSaRauna(kartica,sumaCena);

                        ((SuperMarket)this).skiniNovacSaRauna(kartica, sumaCena);

                        Console.WriteLine("Proizvodi su uspesno kupljeni za sumu: " + sumaCena + " " + prodavnice[i].proizvodi[index].Naziv);

                        //kupljeno true;

                        return true;

                    }


                }

            }

                return false;

           
        }
    }

}