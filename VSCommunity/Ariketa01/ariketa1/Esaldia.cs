using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariketa1
{
    internal class Esaldia
    {

        public String esaldiaLotuta
        {
            get; set;
        }
        public String hitzBakarra
        {
            get; set;
        }
        public void lotuHitzak()
        {
            esaldiaLotuta += hitzBakarra + " ";
        }
    }
}
