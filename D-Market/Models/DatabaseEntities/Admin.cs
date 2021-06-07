using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string Nickname { get; set; }
        [Required]
        [MaxLength(200)]
        public string Token { get; set; }
        [Required]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}
