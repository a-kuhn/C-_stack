using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BankAccounts.Models;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private BankContext dbContext;
        public HomeController(BankContext context)
        {
            dbContext = context;
        }

        [HttpGet("")] //render registration view
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("account")] //render account view
        public IActionResult Account()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Index");
            }

            List<Transaction> Transactions = dbContext.Transactions
                .Include(t => t.User)
                .Where(t => t.User.UserId == userId)
                .OrderByDescending(t => t.CreatedAt)
                .ToList();

            double currBalance = 0;
            foreach (Transaction t in Transactions)
            {
                currBalance += t.Amount;
            }
            ViewBag.User = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            ViewBag.currBalance = currBalance;
            ViewBag.Transactions = Transactions;
            return View();
        }

        [HttpGet("login")] //render login view
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("register")] //create new user
        public IActionResult Register(User newUser)
        {
            //if user submits valid registration info...
            if (ModelState.IsValid)
            {
                //double check to make sure user's email is not already registered
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    //add new error to ModelState if email exists in DB
                    ModelState.AddModelError("Email", "is taken");
                }
            }

            //check ModelState for error that might have been added above
            if (ModelState.IsValid == false)
            {
                //return to registration page where new error will be displayed
                return View("Index");
            }

            //todo: if passes validations and not already registered, continue with creating new user in db
            //hash password
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);
            //add CreatedAt and UpdatedAt timestamps
            newUser.CreatedAt = DateTime.Now;
            newUser.UpdatedAt = DateTime.Now;
            //add user to db and save changes
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();
            //sign user in by adding to session
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            //send user to account view
            return RedirectToAction("Account");
        }

        [HttpPost("loginUser")] //log in existing user
        public IActionResult LoginUser(LoginUser loginUser)
        {
            string genericErrMsg = "invalid email or password";
            //if user submits invalid login info...
            if (ModelState.IsValid == false)
            {
                return View("Login");
            }
            //if user submits valid info, try to retrieve user from db
            User dbUser = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
            //if email doesn't exist, add error to ModelState
            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", genericErrMsg);
            }
            //if email does exist, check if PW matches
            else
            {
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", genericErrMsg);
                }
            }
            //check ModelState for new errors
            if (ModelState.IsValid == false)
            {
                //send user back to login page where new errors will be displayed
                return View("Login");
            }
            //if email exists and PW is correct, log in user with session
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            //redirect user to account page
            return RedirectToAction("Account");
        }

        [HttpGet("logout")] //log out (clear session)
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("NewTransaction")] //process new transaction
        public IActionResult NewTransaction(double Amount)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Index");
            }
            User currUser = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            List<Transaction> Transactions = dbContext.Transactions
                .Include(t => t.User)
                .Where(t => t.User.UserId == userId)
                .OrderByDescending(t => t.CreatedAt)
                .ToList();

            double currBalance = 0;
            foreach (Transaction t in Transactions)
            {
                currBalance += t.Amount;
            }

            if (Amount < 0 && (Amount * -1 > currBalance))
            {
                return RedirectToAction("Account");
            }


            //create new transaction for input amount
            Transaction newTrans = new Transaction()
            {
                Amount = Amount,
                UserId = currUser.UserId,
                User = currUser,
            };
            //add to db using session id for UserId 
            dbContext.Transactions.Add(newTrans);
            dbContext.SaveChanges();
            //redirect to account view
            return RedirectToAction("Account");
        }
    }
}
