using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    [Table("Elikagaia")]
    internal class Elikagaia
    {
        [Key]
        public int Id { get; set; }
        public String Izena { get; set; }
        public String Marka { get; set; }
    }
}
