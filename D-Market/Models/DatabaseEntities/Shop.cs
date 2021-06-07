using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class Shop
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
        [Required]
        public int OrderAmount { get; set; }
        public string Icon{ get; set; }
        public string Banner { get; set; }
        [Required]
        public double Money { get; set; }
        [Required]
        public int OwnerID { get; set; }
        public Owner Owner { get; set; }
        List<Product> Products { get; set; }
        List<ShopTransaction> Transactions { get; set; }
        List<Employee> Employee { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsHidden { get; set; }
    }
}
