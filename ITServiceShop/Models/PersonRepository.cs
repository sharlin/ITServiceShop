using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceShop.Models
{
    public class PersonRepository : IPerson
    {
        private readonly AppDbContext _appDbContext;

        public PersonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Person> Persons
        {
            get
            {
                return _appDbContext.People;
            }
        }


        public Person GetPersonById(int PersonId)
        {
            return _appDbContext.People.FirstOrDefault(p => p.BusinessEntityID == PersonId);
                       
        }
    }
}
