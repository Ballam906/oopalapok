using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hallgato tanulo1 = new Hallgato("Gábor", 22, "HEKO45");
            Hallgato tanulo2 = new Hallgato("Gergő", 37, "AJEF12");
            Hallgato tanulo3 = new Hallgato("Dávid", 55, "WOPD53");
            List<Hallgato> hallgatok = new List<Hallgato>();
            hallgatok.Add(tanulo1);
            hallgatok.Add(tanulo2);
            hallgatok.Add(tanulo3);
            Console.WriteLine("Hallgatók:");
            foreach (Hallgato h in hallgatok)
            {
                Console.WriteLine(h.Nev);
            }
        }
    }

    class Hallgato : Szemely
    {
        public string neptunKod;

        public string NeptunKod
        {
            get { return neptunKod; }
            set
            {
                if (neptunKod.Length < 6)
                {
                    neptunKod = value;
                }
                else
                {
                    Console.WriteLine("A neptunkód maximum 6 karakter lehet.");
                }
            }

        }

        public string Nev
        {
            get { return nev; }
        }

        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            this.neptunKod = neptunKod;
        }
    }

    class BankSzamla
    {
        public int egyenleg;

        public void Betesz(int osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine("Nem lehet negatív.");
                return;
            }

            egyenleg += osszeg;
        }

        
        public void Kivesz(int osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine("Nem lehet minuszt kivenni");
                return;
            }

            if (osszeg > egyenleg)
            {
                Console.WriteLine("Nincs elég pénz");
                return;
            }

            egyenleg -= osszeg;
        }
    }

    class Szemely
    {
        protected string nev;
        private int kor;

        public int Kor
        {
            get { return kor; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Az életkor negatív");
                }
                kor = value;
            }
        }


        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

        public override string ToString() {
            return $"Neve: {nev}, kora: {kor}";
        }
    }

}
