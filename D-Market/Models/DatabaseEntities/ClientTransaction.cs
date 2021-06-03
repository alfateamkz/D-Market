using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    public class ClientTransaction
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Required]
        public int TypeID { get; set; }
        public TransactionType Type { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
