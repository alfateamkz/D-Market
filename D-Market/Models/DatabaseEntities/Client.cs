using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string Nickname { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(25)]
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
        public List<ClientTransaction> Transactions { get; set; }
        [Required]  
        public double Money { get; set; }
        public string Icon { get; set; }
        [Required]
        public int OrderAmount { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsHidden { get; set; }

    }
}
