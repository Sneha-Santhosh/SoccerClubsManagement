using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sneha_S_301096645.Models;
using Sneha_S_301096645.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Sneha_S_301096645.Controllers
{
    public class ClubsController : Controller
    {
        private IClubRepository repository;
        public int PageSize = 4;
        public ClubsController(IClubRepository repo)
        {
            repository = repo;
        }
        public ViewResult Clubs(int clubsPage = 1)
                        => View(new ClubListViewModel{
                           Clubs = repository.Clubs
                           .OrderBy(c => c.ClubID)
                           .Skip((clubsPage - 1) * PageSize)
                           .Take(PageSize),
                           PagingInfo = new PagingInfo
                           {
                              CurrentPage = clubsPage,
                              ItemsPerPage = PageSize,
                              TotalItems = repository.Clubs.Count()
                           } 
                        });
        public ViewResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ViewResult AddClub()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ViewResult AddClub(ClubResponse clubResponse)
        {   
            repository.AddNewClub(clubResponse);
            ModelState.Clear();
            return View("ClubDetails",repository.Clubs);    
        }
        public ViewResult ClubDetails(string name)
        {
            return View(repository.Clubs);
        }
        [Authorize]
        public ViewResult Edit(int clubId) => View(repository.Clubs.FirstOrDefault(c => c.ClubID == clubId));
       
        [Authorize]
        [HttpPost]
        public IActionResult Edit(ClubResponse club)
        {
            if (ModelState.IsValid)
            {
                repository.SaveClub(club);
                TempData["message"] = $"{club.ClubName} has been edited";
                return RedirectToAction("ClubDetails");
            }
            else
            {               
                return View(club);
            }
        }
        [Authorize]    
        public IActionResult Delete(ClubResponse club)
        {
            ClubResponse deletedClub = repository.DeleteClub(club);
            if (deletedClub != null)
            {
                TempData["message"] = $"{deletedClub.ClubName} has been deleted";
            }
            return RedirectToAction("ClubDetails");
        }
    }
}
