using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Areas.Users.Controllers
{
    public class UsersController : Controller
    {

        [Area("Users")] // especificamos al controlador el area en que se encuentra
        // esto se hace cada vez que se agrega un controller
        public IActionResult Users()
        {
            return View();
        }
    }
}
