using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Price
    {
        [Key]
        public int PriceId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitCost { get; set; }
    }
}
