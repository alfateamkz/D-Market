using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class ShopTransaction
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ShopID { get; set; }
        public Shop Shop { get; set; }

        [Required]
        public int TypeID { get; set; }
        public TransactionType Type { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
