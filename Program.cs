using System;

namespace plecakdynamiczny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilosc przedmiotow");
           
            int rozmiar = int.Parse(Console.ReadLine());
            Console.WriteLine("____________");
            Wypelnij wypelnij = new Wypelnij(rozmiar);
            Wyswietl wyswietl = new Wyswietl();
            wypelnij.WypelnijLosowo();
            wyswietl.WyswietlPrzedmioty();
            Console.ReadKey();
        }
    }


    public class Wypelnij
    {
        public Wypelnij(int introzmiar)
        {

            rozmiar = introzmiar;
            Przedmioty = new double[4, rozmiar];
        }
       public static int rozmiar;
       public static double[,] Przedmioty;
       public void WypelnijLosowo()
            {
                Random random = new Random();               
                for (int i = 0; i <= rozmiar-1; i++)
                    {
                      for (int j = 0; j <= rozmiar - 1; j++)
                        {
                          if (i == 0)
                            {
                                Przedmioty[0, j] = j;
                            }
                          else
                            {
                                Przedmioty[i, j] = random.Next(1, 5);
                            }
                        }
                    }
                }
    }
    public class Wyswietl:Wypelnij
    {
        int introzmiar = Wypelnij.rozmiar;
        public void WyswietlPrzedmioty()
        {
            for (int i = 0; i <= Wypelnij.rozmiar - 1; i++)
            {
                for (int j = 0; j <= Wypelnij.rozmiar - 1; j++)
                {

                    Console.WriteLine(Wypelnij.Przedmioty[i, j]);
                }
                Console.WriteLine("----");
            }
        }
    }
  }

