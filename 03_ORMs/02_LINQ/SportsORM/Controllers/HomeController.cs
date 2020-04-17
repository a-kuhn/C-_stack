using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            // ...all teams in the Atlantic Soccer Conference
            ViewBag.AllAtlanticSoccerConferenceTeams = context.Teams
                .Include(team => team.CurrLeague)
                .Where(team => team.CurrLeague.Name.Contains("Atlantic Soccer Conference"));

            // ...all (current) players on the Boston Penguins
            ViewBag.AllCurrPenguinsPlayers = context.Players
                .Include(player => player.CurrentTeam)
                .Where(p => p.CurrentTeam.TeamName.Contains("Penguins"))
                .ToList();

            // ...all (current) players in the International Collegiate Baseball Conference
            //--> all players on all teams in ICBC
            ViewBag.AllPlayersInICBC = context.Players
                .Include(p => p.CurrentTeam.CurrLeague)
                .Where(p => p.CurrentTeam.CurrLeague.Name.Contains("International Collegiate Baseball"))
                .ToList();

            // ...all (current) players in the American Conference of Amateur Football with last name "Lopez"
            ViewBag.LopezsInACAF = context.Players
                .Include(p => p.CurrentTeam.CurrLeague)
                .Where(p => p.LastName == "Lopez")
                .Where(p => p.CurrentTeam.CurrLeague.Name.Contains("American Conference of Amateur Football"))
                .OrderBy(p => p.LastName)
                .ToList();

            // ...all football players
            ViewBag.AllFootballPlayers = context.Players
                .Include(p => p.CurrentTeam.CurrLeague)
                .Where(p => p.CurrentTeam.CurrLeague.Sport.Contains("Football"))
                .ToList();

            // ...all teams with a (current) player named "Sophia"
            ViewBag.AllTeamsWithACurrSophia = context.Teams
                .Include(t => t.CurrentPlayers)
                .Where(t => t.CurrentPlayers.Any(p => p.FirstName == "Sophia"))
                .ToList();

            // ...all leagues with a (current) player named "Sophia"
            // ViewBag.AllLeaguesWithACurrSophia = context.Leagues
            //     // i want to select all players from every list of teams for every league
            //     //how do I say something like: .Include(l => l.Teams.CurrentPlayers)
            //     .Include(l => l.Teams.Any(t => t.TeamName != null))
            //     .Where(l => l.Teams.CurrentPlayers.FirstName === "Sophia")
            //     .ToList();

            // ...everyone with the last name "Flores" who DOESN'T (currently) play for the Washington Roughriders

            // ...all teams, past and present, that Samuel Evans has played with
            // ...all players, past and present, with the Manitoba Tiger-Cats
            // ...all players who were formerly (but aren't currently) with the Wichita Vikings
            // ...every team that Jacob Gray played for before he joined the Oregon Colts
            // ...everyone named "Joshua" who has ever played in the Atlantic Federation of Amateur Baseball Players
            // ...all teams that have had 12 or more players, past and present. (HINT: Look up the Django annotate function.)
            // ...all players and count of teams played for, sorted by the number of teams they've played for

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}