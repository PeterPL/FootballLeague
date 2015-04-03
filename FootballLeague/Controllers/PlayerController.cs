using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Domain.Abstract;
using FootballLeague.Domain.Concrete;
using FootballLeague.Domain.Entities;

namespace FootballLeague.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository _repository;
        private IClubRepository _clubRepository;
        private IPositionRepository _positionRepository;

        public PlayerController(IPlayerRepository playerRepository, IClubRepository clubRepository, IPositionRepository positionRepository)
        {
            _repository = playerRepository;
            _clubRepository = clubRepository;
            _positionRepository = positionRepository;
        }

        public ActionResult Index()
        {
            List<Position> positions = _positionRepository.Positions.ToList();
            List<string> positionNames = positions.Select(position => position.Name).ToList();
            ViewBag.Positions = new MultiSelectList(positionNames);
            
            List<Club> clubs = _clubRepository.Clubs.ToList();
            List<string> clubNames = clubs.Select(club => club.Name).ToList();
            ViewBag.Clubs = new MultiSelectList(clubNames);

            return View();
        }

        public ViewResult CreatePlayer()
        {
            return View("CreatePlayer", new Player());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ViewResult CreatePlayer(Player player)
        {
            if (ModelState.IsValid)
            {
                var clubName = Request["Club"];
                Club club = _clubRepository.Clubs.FirstOrDefault(c => c.Name == clubName);

                var positionName = Request["Position"];
                Position position = _positionRepository.Positions.FirstOrDefault(p => p.Name == positionName);

                player.Club = club;
                player.Position = position;

                
            }
        }

    }
}
