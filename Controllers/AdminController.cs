using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sneha_S_301096645.Models;

namespace Sneha_S_301096645.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IClubRepository repository;
        public AdminController(IClubRepository repo)
        { repository = repo; }
        public ViewResult ClubDetails() => View(repository.Clubs);
        public ViewResult Edit(int clubId) => View(repository.Clubs.FirstOrDefault(c => c.ClubID == clubId));
        [HttpPost]
        public IActionResult Edit(ClubResponse club)
        {
            if (ModelState.IsValid)
            {
                repository.SaveClub(club);
                TempData["message"] = $"{club.ClubName} has been edited";
                return RedirectToAction("Index");
            }
            else
            {                // there is something wrong with the data values      
                return View(club);
            }
        }

        [HttpPost]
        public IActionResult Delete(ClubResponse club)
        {
            ClubResponse deleted = repository.DeleteClub(club);
            if (deleted != null)
            {
                TempData["message"] = $"{deleted.ClubName} has been deleted";
            }
            return RedirectToAction("Index");
        }
    }
}