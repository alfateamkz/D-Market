using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class GlobalAction
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
        public int ActionID { get; set; }
        public GlobalActionType Action { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
