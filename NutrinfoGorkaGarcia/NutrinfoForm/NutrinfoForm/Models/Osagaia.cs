using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    [Table("Osagaia")]
    internal class Osagaia
    {
        [Key]
        public int Id { get; set; }
        public String Izena { get; set; }
        public String Unitatea { get; set; }
        public int Konparaketa { get; set; }
    }
}
