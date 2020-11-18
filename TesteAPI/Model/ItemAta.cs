using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Model
{
    [Table("Item", Schema = "sirp")]
    [Keyless]
    public class ItemAta
    {
        [ForeignKey("CodigoAta")]
        public int CodigoAta { get; set; }
        [ForeignKey("Ano")]
        public int Ano { get; set; }
        [ForeignKey("Sequencial")]
        public long CodigoMaterial { get; set; }
    }
}
