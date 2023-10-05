using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AginteKoadroa.Models
{
    internal class Bezeroa
    {
        [Key]
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string Helbidea { get; set; }
        public string Telf { get; set; }
        public string Emaila { get; set; }
        public string SaltzaileaId { get; set; }
        public virtual Saltzailea Saltzailea { get; set; }
        public virtual List<Salmenta> Salmenta { get; set; }
    }
}
