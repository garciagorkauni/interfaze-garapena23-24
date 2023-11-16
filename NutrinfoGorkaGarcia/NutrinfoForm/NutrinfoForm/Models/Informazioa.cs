using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    [Table("Informazioa")]
    internal class Informazioa
    {
        [Key]
        public int Id { get; set; }
        public int OsagaiaId { get; set; }
        public int Urtea { get; set; }
        public int Kantitatea { get; set; }
        public int ElikagaiaId { get; set; }
        public virtual Osagaia osagaia { get; set; }
        public virtual Elikagaia elikagaia { get; set; }
    }
}
