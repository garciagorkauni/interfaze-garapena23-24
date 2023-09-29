using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public String nan { get; set; }
        public String izena { get; set; }
        public String abizena { get; set; }
        public virtual String email { get; set; }
        public String izenOsoa
        { 
            get => this.izena + " " + this.abizena;
        }

        public virtual void gorde()
        {
            MessageBox.Show("Kontaktua ondo gorde da");
        }

        public virtual string ToString()
        {
            return this.izenOsoa + " (" + this.nan + ")";
        }

    }
}
