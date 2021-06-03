using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models.DatabaseEntities
{
    
    public class DisputeChat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int DisputeID { get; set; }
        public Dispute Dispute { get; set; }
        [Required]
        public DateTime MessageDateTime { get; set; }
        public string Message { get; set; }
        public string Image { get; set; }
        //public Video Video { get; set; }
    }
}
