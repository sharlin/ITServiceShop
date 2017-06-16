using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceShop.Models
{
    public interface IItem
    {
        IEnumerable<Items> Items { get; }
        Items GetItemById(int itemId);
        
    }
}
