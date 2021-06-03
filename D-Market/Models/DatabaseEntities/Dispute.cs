using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class Dispute
    {
        
        public int Number { get; set; }
        [Required]
        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Required]
        public int StateID { get; set; }
        public DisputeState State { get; set; }

        [Required]
        public int ShopID { get; set; }
        public Shop Shop { get; set; }

        [Required]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
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
