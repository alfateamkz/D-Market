using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Required]
        public int ShopID { get; set; }
        public Shop Shop { get; set; }

        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
