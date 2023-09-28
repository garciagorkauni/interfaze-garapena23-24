using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa02_Array
{
    internal class Ariketa
    {
        public Ariketa() { }

        float[] zenbakiak = new float[4];
        public float[] Zenbakiak
        {
            get
            {
                return zenbakiak;
            }
            set
            {
                zenbakiak = value;
            }
        }
        public float eragiketa { get; set; }

        public float eragiketaluzea()
        {
            return eragiketa = (this.zenbakiak[0] + 2 * this.zenbakiak[1] + 3 * this.zenbakiak[2] + 4 * this.zenbakiak[3]) / 4;

        }
    }
}
