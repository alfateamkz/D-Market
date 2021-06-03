using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class Owner
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

        List<Shop> Shops { get; set; }

    }
}
