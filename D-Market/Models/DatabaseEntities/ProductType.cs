using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class ProductType
    {   [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
