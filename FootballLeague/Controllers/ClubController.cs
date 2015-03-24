using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Domain.Abstract;
using FootballLeague.Domain.Concrete;


namespace FootballLeague.Controllers
{
    public class ClubController : Controller
    {
        private IClubRepository _repository;

        public ClubController(IClubRepository clubRepository)
        {
            _repository = clubRepository;
        }

        public ViewResult List()
        {
            
            return View(_repository.Clubs);
        }

    }
}
