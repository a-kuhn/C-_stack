using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WedPlanContext db;
        public HomeController(WedPlanContext context)
        {
            db = context;
        }

        [HttpGet("")] //render reg/login view
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("dashboard")] //render dashboard view w/ AllWeddings table
        public IActionResult Dashboard()
        {
            ViewBag.AllWeddings = db.Weddings
                .Include(w => w.Attendees)
                .ThenInclude(r => r.User)
                .ToList();

            int? uid = HttpContext.Session.GetInt32("UserId");
            ViewBag.CurrUser = db.Users
                .Include(u => u.WeddingsToAttend)
                .Include(u => u.Weddings)
                .FirstOrDefault(u => u.UserId == (int)uid);

            return View();
        }

        [HttpPost("register")] //create new user, redirect to Dashboard
        public IActionResult Register(User newUser)
        {
            //if user submits valid registration info...
            if (ModelState.IsValid)
            {
                //double check to make sure user's email is not already registered
                if (db.Users.Any(u => u.Email == newUser.Email))
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
            //add user to db and save changes
            db.Users.Add(newUser);
            db.SaveChanges();
            //sign user in by adding to session
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            //send user to success view
            return RedirectToAction("Dashboard");
        }

        [HttpPost("login")] //login existing user, redirect to Dashboard
        public IActionResult Login(LoginUser loginUser)
        {
            string genericErrMsg = "invalid email or password";
            //if user submits invalid login info...
            if (ModelState.IsValid == false)
            {
                return View("Login");
            }
            //if user submits valid info, try to retrieve user from db
            User dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
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
            //redirect user to success page
            return RedirectToAction("Dashboard");
        }

        [HttpGet("logout")] //logout user, redirect to Index
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("new")] //render new wedding view
        public IActionResult NewWedding()
        {
            return View();
        }

        [HttpPost("create")] //create new wedding, redirect to dashboard for now
        public IActionResult Create(Wedding newWedding)
        {
            int? uid = HttpContext.Session.GetInt32("UserId");
            User currUser = db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            newWedding.CreatedBy = currUser;
            newWedding.CreatedById = currUser.UserId;
            db.Weddings.Add(newWedding);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("Wedding")] //render wedding details view
        public IActionResult Wedding()
        {

            return View();
        }

        [HttpPost("CreateRSVP")] //create RSVP, redirect to dashboard
        public IActionResult CreateRSVP(RSVP newRsvp)
        {
            int? uid = HttpContext.Session.GetInt32("UserId");
            User currUser = db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            newRsvp.User = currUser;
            newRsvp.UserId = currUser.UserId;
            db.RSVPs.Add(newRsvp);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("DeleteRSVP/{WeddingId}")] //delete RSVP
        public IActionResult DeleteRSVP(int WId)
        {
            int? uid = HttpContext.Session.GetInt32("UserId");
            User currUser = db.Users.FirstOrDefault(u => u.UserId == (int)uid);

            //FIND && DELETE rsvp in db
            RSVP RSVPtoDelete = db.RSVPs
                .Include(r => r.UserId)
                .Include(r => r.WeddingId)
                .Where(r => r.WeddingId == WId)
                .FirstOrDefault(r => r.UserId == currUser.UserId);

            db.RSVPs.Remove(RSVPtoDelete);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }
    }
}
