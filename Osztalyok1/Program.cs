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
            private int hosszusag;
            private int szelesseg;

            const int tartolapnegyzetar = 5000;
            const int hatlapnegyzetar = 500;

            public int Tartolap
            {
                get { return hosszusag; }
                set { hosszusag = value; }
            }
            public int Hatlap
            {
                get { return szelesseg; }
                set { szelesseg = value; }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
