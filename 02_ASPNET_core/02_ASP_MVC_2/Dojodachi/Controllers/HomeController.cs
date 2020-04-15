using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Happiness") == null)
            {
                //start session for new dachi if needed
                HttpContext.Session.SetInt32("Happiness", 20);
                HttpContext.Session.SetInt32("Fullness", 20);
                HttpContext.Session.SetInt32("Energy", 50);
                HttpContext.Session.SetInt32("Meals", 3);
                HttpContext.Session.SetString("ActionMsg", "Here's your new little dojodachi; take good care of them!");
            }
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Meals = HttpContext.Session.GetInt32("Meals");
            int newHappiness = (int)Happiness;
            int newFullness = (int)Fullness;
            int newEnergy = (int)Energy;
            int newMeals = (int)Meals;
            string ActionMsg = HttpContext.Session.GetString("ActionMsg");

            //check win conditions
            if (newEnergy >= 40 && newFullness >= 40 && newHappiness >= 40)
            {
                ActionMsg = "Congratulations! You Won!";
            }

            //check lose conditions
            if (newFullness <= 0 || newHappiness <= 0)
            {
                ActionMsg = "Good job. Your dojodachi is dead.";
            }

            //update session data
            HttpContext.Session.SetInt32("Happiness", newHappiness);
            HttpContext.Session.SetInt32("Fullness", newFullness);
            HttpContext.Session.SetInt32("Energy", newEnergy);
            HttpContext.Session.SetInt32("Meals", newMeals);
            HttpContext.Session.SetString("ActionMsg", ActionMsg);

            //send session data to view
            ViewBag.Happiness = newHappiness;
            ViewBag.Fullness = newFullness;
            ViewBag.Energy = newEnergy;
            ViewBag.Meals = newMeals;
            ViewBag.ActionMsg = ActionMsg;

            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            //get necessary props from session
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? meals = HttpContext.Session.GetInt32("Meals");
            int newFullness = (int)fullness;
            int newMeals = (int)meals;
            string ActionMsg = HttpContext.Session.GetString("ActionMsg");

            //logic for FEED action --> meals -= 1; 75% fullness += 5-10; 25% nothing
            Random rand = new Random();
            int amount = rand.Next(5, 11);
            if (newMeals > 0)
            {
                newMeals--;
                if (rand.Next(0, 4) != 0)
                { newFullness += amount; }
                else { amount = 0; }
                ActionMsg = $"Waffles and ice cream -- yum! +{amount} fullness; -1 meal";
            }
            else { ActionMsg = "Sorry, dude, you ain't got no food. Best get to workin' for some more."; }

            //update session
            HttpContext.Session.SetInt32("Fullness", newFullness);
            HttpContext.Session.SetInt32("Meals", newMeals);
            HttpContext.Session.SetString("ActionMsg", ActionMsg);

            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            //get necessary props from session
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int newEnergy = (int)energy;
            int newHappiness = (int)happiness;
            string ActionMsg = HttpContext.Session.GetString("ActionMsg");

            //logic for play action --> energy -= 5; 75% happiness += 5-10; 25% nothing
            Random rand = new Random();
            int amount = rand.Next(5, 11);
            newEnergy -= 5;
            if (rand.Next(0, 4) != 0)
            { newHappiness += amount; }
            else { amount = 0; }
            ActionMsg = $"I love fetch! +{amount} happiness; -5 energy";

            //update session
            HttpContext.Session.SetInt32("Energy", newEnergy);
            HttpContext.Session.SetInt32("Happiness", newHappiness);
            HttpContext.Session.SetString("ActionMsg", ActionMsg);

            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            //get necessary props from session
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? meals = HttpContext.Session.GetInt32("Meals");
            int newEnergy = (int)energy;
            int newMeals = (int)meals;
            string ActionMsg = HttpContext.Session.GetString("ActionMsg");

            //logic for work action --> energy -= 5; meals += 1-3
            Random rand = new Random();
            int amount = rand.Next(1, 4);
            newMeals += amount;
            newEnergy -= 5;
            ActionMsg = $"money pleeaaseee +{amount} meal(s); -5 energy";

            //update session
            HttpContext.Session.SetInt32("Energy", newEnergy);
            HttpContext.Session.SetInt32("Meals", newMeals);
            HttpContext.Session.SetString("ActionMsg", ActionMsg);

            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            //get necessary props from session
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int newFullness = (int)fullness;
            int newEnergy = (int)energy;
            int newHappiness = (int)happiness;
            string ActionMsg = HttpContext.Session.GetString("ActionMsg");

            //logic for sleep action --> energy += 15; fullness && happiness -= 5
            newEnergy += 15;
            newFullness -= 5;
            newHappiness -= 5;
            ActionMsg = $"just taking a little nappy +15 energy; -5 fullness; -5 happiness";

            //update session
            HttpContext.Session.SetInt32("Fullness", newFullness);
            HttpContext.Session.SetInt32("Energy", newEnergy);
            HttpContext.Session.SetInt32("Happiness", newHappiness);
            HttpContext.Session.SetString("ActionMsg", ActionMsg);

            return RedirectToAction("Index");
        }

        [HttpGet("restart")]
        public IActionResult Restart()
        {
            //logic for restart action
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
