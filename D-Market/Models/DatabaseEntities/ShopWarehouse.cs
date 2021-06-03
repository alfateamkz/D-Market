using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{

    public class ShopWarehouse
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public List<string> Cities { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
