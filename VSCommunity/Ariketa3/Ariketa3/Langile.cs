using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Langile:Kontaktua
    {
        public float soldata {  get; set; }
        public String segurtasunSoziala { get; set; }
        public override string email
        {
            get => base.email;
            set
            {
                try { 
                    if (value.Substring(value.Length - 14, 14) != "@iesunibhi.com")
                    {
                        Exception ex = new Exception("Emaila ez duzu ondo jarri");
                        throw ex;
                    }
                    else
                    {
                        base.email = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Restart();
                } 
            }
        }
        public override void gorde()
        {
            MessageBox.Show("Langilea ondo gorde da");
        }

        public override string ToString()
        {
            return this.izenOsoa + " (" + this.nan + ") - " + this.soldata + "€";
        }
    }
}
