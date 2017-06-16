using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITServiceShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITServiceShop.Controllers
{
    
    public class PersonController : Controller
    {
        private readonly IPerson _person;

        public PersonController(IPerson person)
        {
            _person = person;
        }

        public IActionResult List()
        {
            return View(_person.Persons);
        }
    }
}
