using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceShop.Models
{
    public class Items
    {
        public int itmId { get; set; }
        public string itmCategory { get; set; }
        public string itmDescription { get; set; }
        public string itmModel { get; set; }
        public DateTime itmDateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        
    }
}
