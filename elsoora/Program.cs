using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace elsoora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szemely> emberek = new List<Szemely>();

            emberek.Add(new Hallgato("Anna",32, "AB123C"));
            emberek.Add(new Dolgozo("Péter",56, 500000));
            emberek.Add(new Hallgato("Eszter",19, "XY456D"));
            emberek.Add(new Dolgozo("Ádám",22, 650000));

            foreach (var szemely in emberek)
            {
                szemely.MutatJellemzot(); 
            }
        }
    }

    class Dolgozo : Szemely
    {
        public int ber;


        public Dolgozo(string nev, int kor, int ber) : base(nev, kor)
        {
            this.ber = ber;
        }

        public override void MutatJellemzot()
        {
            Console.WriteLine($"Dolgozó: {nev}, Bér: {ber} Ft");
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

        public override void MutatJellemzot()
        {
            Console.WriteLine($"Hallgató: {nev}, Neptun kód: {neptunKod}");
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
        public virtual void MutatJellemzot()
        {
            Console.WriteLine($"Személy: {nev}");
        }


    }

}
