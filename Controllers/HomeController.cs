using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sneha_S_301096645.Models;

namespace Sneha_S_301096645.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddClub()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddClub(ClubResponse clubResponse)
        {
            if (ModelState.IsValid)
            {
                ClubRepository.AddResponse(clubResponse);
                return View("Clubs", ClubRepository.ClubResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult Clubs()
        {
            return View(ClubRepository.ClubResponse);
        }
        [HttpGet]
        public ViewResult ManagePlayers()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ManagePlayers(PlayerResponse playerResponse)
        {
            if (ModelState.IsValid)
            {
                PlayerRepository.AddResponse(playerResponse);
                return View("ClubDetails", PlayerRepository.PlayerResponses.Where(r => r.Deregister == false).OrderBy(r => r.ClubID));
            }
            else
            {
                return View();
            }
        }
        public ViewResult ClubDetails()
        {
            return View(ClubRepository.ClubResponse);
        }
    }
}
