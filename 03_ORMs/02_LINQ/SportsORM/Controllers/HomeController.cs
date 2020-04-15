using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;

namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context context;

        public HomeController(Context DBContext)
        {
            context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = context.Leagues
                .Where(l => l.Sport.Contains("Baseball"));
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //create queries and add results to ViewBag
            ViewBag.AllWomensLeagues = context.Leagues.Where(l => l.Name.Contains("Women")).ToList();
            ViewBag.AllHockeyTypeLeagues = context.Leagues.Where(l => l.Sport.Contains("Hockey") || l.Sport.Contains("hockey")).ToList();
            ViewBag.AllNonFootballLeagues = context.Leagues.Where(l => l.Sport != "Football").ToList();
            ViewBag.AllConferenceLeagues = context.Leagues.Where(l => l.Name.Contains("Conference")).ToList();
            ViewBag.AllAtlanticLeagues = context.Leagues.Where(l => l.Name.Contains("Atlantic")).ToList();
            ViewBag.AllDallasTeams = context.Teams.Where(t => t.Location.Contains("Dallas")).ToList();
            ViewBag.AllRaptors = context.Teams.Where(t => t.TeamName.Contains("Raptors")).ToList();
            ViewBag.AllCityLocations = context.Teams.Where(t => t.Location.Contains("City")).ToList();
            ViewBag.AllTTeams = context.Teams.Where(t => t.TeamName[0] == 'T').ToList();
            ViewBag.AllTeamsOrderedByLocation = context.Teams.OrderBy(t => t.Location).ToList();
            ViewBag.AllTeamsDescendingOrder = context.Teams.OrderByDescending(t => t.TeamName).ToList();
            ViewBag.AllPlayersCooper = context.Players.Where(p => p.LastName == "Cooper").ToList();
            ViewBag.AllPlayersJoshua = context.Players.Where(p => p.FirstName == "Joshua").ToList();
            ViewBag.AllPlayersCooperButNotJoshuaCoopers =
                context.Players
                    .Where(p => p.LastName == "Cooper")
                    .Where(p => p.FirstName != "Joshua").ToList();
            ViewBag.AllAlexandersAndWyatts = context.Players.Where(p => p.FirstName == "Alexander" || p.FirstName == "Wyatt").ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}