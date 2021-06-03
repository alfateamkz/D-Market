using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class Product
    {   [Key]
        public int ID { get; set; }
        [Required]
        public int TypeID { get; set; }
        public ProductType Type { get; set; }
        [Required]
        public int ShopID { get; set; }
        public Shop Shop { get; set; }
        [Required]
        public int MeasureID { get; set; }
        public MeasureType Measure { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
