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
            Szemely tanulo = new Szemely();
            Console.WriteLine(tanulo.nev);
            Console.WriteLine(tanulo.kor);
        }
    }

     class Szemely
    {
        public string nev = "Kiss Péter";
        public int kor = 35;

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }
    }

}
