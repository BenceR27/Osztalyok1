using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok1
{
    internal class Program
    {
        public class Butorlap
        {
            private double hossz;    
            private double szelesseg; 
            private string tipus;     

            const int tartolap_ar = 5000;
            const int hatlap_ar = 500;

            public Butorlap(string tipus, double hosszCm, double szelessegCm)
            {
                this.tipus = tipus;
                this.hossz = hosszCm / 100.0;
                this.szelesseg = szelessegCm / 100.0;
            }

            public double ArSzamol()
            {
                double terulet = hossz * szelesseg; 
                if (tipus.ToLower() == "tartolap")
                {
                    return terulet * tartolap_ar;
                }
                else if (tipus.ToLower() == "hatlap")
                {
                    return terulet * hatlap_ar;
                }
                else
                {
                    return 0; 
                }
            }
            public override string ToString()
            {
                return $"{tipus} ({hossz}m x {szelesseg}m), ár: {ArSzamol()} Ft";
            }
        }

        public class Butor
        {
            private int lapokSzama;
            private Butorlap[] lapok;

            public Butor()
            {
                lapokSzama = 0;
                lapok = new Butorlap[100];
            }

            public void LapHozzaad(Butorlap lap)
            {
                if (lapokSzama < lapok.Length)
                {
                    lapok[lapokSzama] = lap;
                    lapokSzama++;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
