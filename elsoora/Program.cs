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
            Szemely tanulo = new Szemely("Bence",2);
            Console.WriteLine(tanulo);
        }
    }

     class Szemely
    {
        public string nev;
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
