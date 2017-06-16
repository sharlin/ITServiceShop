using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceShop.Models
{
    public class MockItemRepository : IItem
    {
        public IEnumerable<Items> Items
        {
            get
            {
                return new List<Items>
                {
                    new Items{ itmId = 1, itmModel="philips" , itmDescription = "yyyy" , DateUpdated = DateTime.Now, itmCategory = "eeee", itmDateCreated = DateTime.Now },
                    new Items{ itmId = 2, itmModel="sony" , itmDescription = "yyyy" , DateUpdated = DateTime.Now, itmCategory = "eeee", itmDateCreated = DateTime.Now },
                    new Items{ itmId = 3, itmModel="HP" , itmDescription = "yyyy" , DateUpdated = DateTime.Now, itmCategory = "eeee", itmDateCreated = DateTime.Now },
                    new Items{ itmId = 4, itmModel="Lenovo" , itmDescription = "yyyy" , DateUpdated = DateTime.Now, itmCategory = "eeee", itmDateCreated = DateTime.Now },
                };
            }
        }

        
        Items IItem.GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
