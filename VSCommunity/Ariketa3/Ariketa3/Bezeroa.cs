using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Bezeroa:Kontaktua
    {
        public String kategoria {  get; set; }

        public override void gorde()
        {
            MessageBox.Show("Bezeroa ondo gorde da");
        }

        public override string ToString()
        {
            return this.izenOsoa + " (" + this.nan + ") - " + this.kategoria;
        }
    }
}
