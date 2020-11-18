using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Model
{
    [Table("TB_Item", Schema = "catmas")]
    public class ItemCatalogo
    {
        [Key]
        public long Sequencial { get; set; }
        public string DescricaoBasica { get; set; }
    }
}
