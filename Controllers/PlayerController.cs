using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sneha_S_301096645.Models;

namespace Sneha_S_301096645.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository repository;
        public PlayerController(IPlayerRepository repo)
        {
            repository = repo;
        }
        [Authorize]
        [HttpGet]
        [Route("/Player/ManagePlayers/{id?}")]
        public ViewResult ManagePlayers()
        {
            
            return View();
        }
       [Authorize]
        [HttpPost]
        public ViewResult ManagePlayers(PlayerResponse player)
        {
            repository.SavePlayer(player);
            return View("PlayerDetails", repository.Players);
        }

        public ViewResult PlayerDetails(int id)
        {
            return View("PlayerDetails", repository.Players.Where(c => c.ClubID == id));
        }
    }
}