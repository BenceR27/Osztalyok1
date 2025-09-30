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

            const int tartolapnegyzetar = 5000;
            const int hatlapnegyzetar = 500;

            public Butorlap(string tipus, double hosszCm, double szelessegCm)
            {
                this.tipus = tipus;
                this.hossz = hosszCm / 100.0;
                this.szelesseg = szelessegCm / 100.0;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
