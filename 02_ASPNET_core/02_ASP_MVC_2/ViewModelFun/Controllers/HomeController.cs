using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string lorem = "here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message. here is a message.";

            return View("Index", lorem);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,10,43,5
            };
            return View(numbers);
        }

        [HttpGet("user")]
        public IActionResult UserDetail()
        {
            User newUser = new User()
            {
                FirstName = "Buttercup",
                LastName = "Kuhn"
            };
            return View(newUser);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User user1 = new User()
            {
                FirstName = "Buttercup",
                LastName = "Kuhn"
            };

            User user2 = new User()
            {
                FirstName = "Mia",
                LastName = "Buechler"
            };

            User user3 = new User()
            {
                FirstName = "Bubbles",
                LastName = "Frost"
            };

            List<User> userList = new List<User>()
            {
                user1, user2, user3
            };
            return View(userList);
        }

    }


}

