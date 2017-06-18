using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceShop.Models
{
    public interface IPerson
    {
        IEnumerable<Person> Persons { get; }
        Person GetPersonById(int PersonId);
    }
}
