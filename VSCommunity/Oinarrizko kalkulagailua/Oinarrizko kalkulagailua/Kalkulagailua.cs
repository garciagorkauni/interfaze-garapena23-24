using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oinarrizko_kalkulagailua
{
    internal class Kalkulagailua
    {
        public float Zenbaki1 { get; set; }
        public float Zenbaki2 { get; set; }

        public Kalkulagailua( float zenbakia1, float zenbakia2)
        {
            this.Zenbaki1 = zenbakia1;
            this.Zenbaki2= zenbakia2;
        }

        public Kalkulagailua() { }

        public float Gehiketa()
        {
            return this.Zenbaki1 + this.Zenbaki2;
        }

        public float Kenketa()
        {
            return this.Zenbaki1 - this.Zenbaki2;
        }

        public float Biderketa()
        {
            return this.Zenbaki1 * this.Zenbaki2;
        }

        public float Zatiketa()
        {
            return this.Zenbaki1 / this.Zenbaki2;
        }

    }
}
