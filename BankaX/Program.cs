using System;
using System.Collections.Generic;

namespace BankaX
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka inteza = new Banka("Inteza", "Brazil");


            Klijent pera = new FizickoLice("Pera", "Maksima gorkog 4", 5555);
            Klijent mika = new FizickoLice("Mika", "Alekse Santica 55", 44444);
            Klijent imiSoft = new PravnoLice("ImiSoft", "Marka Kraljevica 44", "45719GRF");



            inteza.KreirajRacun(pera, "dinarski");

            inteza.UplatiNovac("1110", 2000.00);

            Banka komercijalna = new Banka("Komercijalna", "Srbija");

            komercijalna.KreirajRacun(pera, "devizni");

            komercijalna.KreirajRacun(mika, "devizni");

            komercijalna.UplatiNovac("2222", 3000.00);

            komercijalna.dodajPunomocje("2222", mika);

            komercijalna.KreirajRacun(imiSoft, "dinarski");

            //Kartica maestro = new MaestroKartica(new Racun(), 6666);

            inteza.izdajKarticu("1110", new MaestroKartica(new Racun(), 6666));


            //new Racun("1110", inteza).dodajKarticu(new MaestroKartica(new Racun(), 6666));

            pera.DajKarticu(1);


            //PRODAVNICA TEST

            Console.WriteLine("\n \nPRODAVNICA:");

            ProdavnicaX[] prodavnice = new ProdavnicaX[3];

            prodavnice[0] = new SuperMarket("Trnava", "Pozecka bb");

            prodavnice[1] = new Trafika("Minut", "Puskinova 13");


            prodavnice[2] = new SuperMarket("Maxi", "Sarajevska 57");



            Proizvod sljivovica = new Proizvod("sljivovica", 300.00);

            Proizvod sljivovica1 = new Proizvod("sljivovica", 250.00);

            Proizvod sljivovica2 = new Proizvod("sljivovica", 290.00);

            Proizvod minas = new Proizvod("minas", 120.00);

            Proizvod minas1 = new Proizvod("minas", 130.00);

            Proizvod minas2 = new Proizvod("minas", 140.00);

            prodavnice[0].dodajProizvod(sljivovica);

            prodavnice[0].dodajProizvod(minas);

            prodavnice[1].dodajProizvod(sljivovica1);

            prodavnice[1].dodajProizvod(minas1);

            prodavnice[2].dodajProizvod(sljivovica2);

            prodavnice[2].dodajProizvod(minas2);

            List<Proizvod> proizvodi = new List<Proizvod>();
            proizvodi.Add(sljivovica);
            proizvodi.Add(sljivovica1);
            proizvodi.Add(sljivovica2);
            proizvodi.Add(minas);
            proizvodi.Add(minas1);
            proizvodi.Add(minas2);


          /*  for (int i = 0; i < prodavnice.Length; i++)
            {
                if (prodavnice[i] is SuperMarket)
                {

                    for (int j = 0; j < proizvodi.Count; j++)
                    {
                        if (proizvodi[j].Naziv.StartsWith("s"))
                        {
                            if (proizvodi[j].Cena < najmanja)
                            {
                                najmanja = proizvodi[j].Cena;
                                index = j;
                                Console.WriteLine("Najmanja cena: " + proizvodi[index].Naziv + " " + najmanja);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < prodavnice.Length; i++)
            {
                if (prodavnice[i] is SuperMarket)
                {


                    for (int j = 0; j < proizvodi.Count; j++)
                    {
                        if (proizvodi[j].Naziv.StartsWith("m"))
                        {
                            if (proizvodi[j].Cena < najmanja)
                            {
                                najmanja = proizvodi[j].Cena;
                                index = j;
                                Console.WriteLine("Najmanja cena: " + proizvodi[index].Naziv + " " + najmanja);
                            }
                        }
                    }


                }

            }*/


             double najmanja = proizvodi[0].Cena;

            double najmanjaM = proizvodi[0].Cena;

            int index = 0;


              for (int i = 0; i < prodavnice.Length; i++)
              {
                  if (prodavnice[i] is SuperMarket)
                  {




                      for (int j = 0; j < prodavnice[i].Proizvodi.Count; j++)
                      {
                          if (prodavnice[i].Proizvodi[j].Naziv.StartsWith("s"))
                          {
                              if (prodavnice[i].Proizvodi[j].Cena < najmanja)
                              {
                                  najmanja = prodavnice[i].Proizvodi[j].Cena;
                                  index = j;
                                  Console.WriteLine("Najmanja cena: " + prodavnice[i].Proizvodi[index].Naziv + " " + najmanja);
                              }
                          }
                      }



                      for (int j = 0; j < prodavnice[i].Proizvodi.Count; j++)
                      {
                          if (prodavnice[i].Proizvodi[j].Naziv.StartsWith("m"))
                          {
                              if (prodavnice[i].Proizvodi[j].Cena < najmanjaM)
                              {
                                  najmanjaM = prodavnice[i].Proizvodi[j].Cena;
                                  index = j;
                                  Console.WriteLine("Najmanja cena: " + prodavnice[i].Proizvodi[index].Naziv + " " + najmanjaM);
                              }
                          }
                      }


                  }

              }

          


             bool kupi = true;

              for (int i = 0; i < prodavnice.Length; i++)
              {
                  if (prodavnice[i] is SuperMarket)

                  {

                    kupi = prodavnice[i].KupiProizvode(new MaestroKartica(new Racun("1110", inteza), 6666), proizvodi);


                  }
             
            }

            Console.WriteLine(kupi);


            //Console.WriteLine(proizvodi.Count);

            //    bool kupi;


            //   kupi = prodavnice[0].kupiProizvode(new Kartica(racunDinarski, 8888),proizvodi);

            // Console.WriteLine(kupi);


            Console.ReadLine();


            Class2 class2 = new Class2();
            Class1 class1 = (Class1)class2;
            class1.Pitaj();

        }
    }
}
