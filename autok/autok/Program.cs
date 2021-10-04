using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    class Program
    {
        enum autoMarkak
        {
            BMW,
            Audi,
            Skoda,
            Mercedes,
            Lada,
        }
        public static Random rn = new Random();

        public static string RandomLetters(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rn.Next(s.Length)]).ToArray());
        }
        public static string RandomNumbers(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rn.Next(s.Length)]).ToArray());
        }



        class auto
        {
            double atlFogyazt;
            int tankMeret;
            int aktualisUzema;
            bool matricaVane;
            string rendszam;

            public double AtlFogyazt
            {
                get => atlFogyazt;
                set => value = rn.NextDouble() * (3.0 - 20.0) + 3.0;

            }
            public int TankMeret
            {
                get => tankMeret;
                set => value = rn.Next(20, 100);
            }
            public int AktualisUzema
            {
                get => aktualisUzema;
                set => value = rn.Next(0, 100);
            }
            public bool MatricaVane
            {
                get => matricaVane;
                set
                {
                    int asd = rn.Next(0, 100);
                    if (asd % 2 == 0) matricaVane = true;
                    else matricaVane = false;
                }
            }

            public string Rendszam
            {
                get => rendszam;
                set
                {
                    value = RandomLetters(3);
                    value += "-";
                    value += RandomNumbers(3);
                }
            }




            public autoMarkak atoumarkak { get; set; }            
        }


        static List<auto> atoLista = new List<auto>();

        static void Main(string[] args)
        {
            Listaba(30);
            KiIrat();

            Console.ReadKey();
        }

        private static void Listaba(int hossz )
        {
            for (int i = 0; i < hossz; i++)
            {
                atoLista.Add(new auto()
                {
                    AtlFogyazt = rn.NextDouble() * (3.0 - 20.0) + 3.0,
                    TankMeret = rn.Next(20, 100),
                    AktualisUzema = rn.Next(0, 100),
                    Rendszam = RandomLetters(3) + "-" + RandomNumbers(3)
                });
            }


        }

        private static void KiIrat()
        {
            foreach (var a in atoLista)
            {
                Console.WriteLine( /*a.AtlFogyazt + " " + a.TankMeret + " " + a.AktualisUzema + " " + a.MatricaVane + " " +*/ a.Rendszam );
            }
        }
    }
}
