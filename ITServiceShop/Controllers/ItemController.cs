using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITServiceShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITServiceShop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItem _item;

        public ItemController(IItem item)
        {
            _item = item;
        }

        public ViewResult List()
        {
            return View(_item.Items);
        }
    }
}
