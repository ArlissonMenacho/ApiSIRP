using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Model
{
    [Table("Ata", Schema = "sirp")]
    public class Ata
    {
        [Key]
        public int CodigoAta { get; set; }
        public int Ano { get; set; }
        public string NumeroPregao { get; set; }
        public double LimiteAdesao { get; set; }
        public DateTime DataFinalVigencia { get; set; }
    }
}
