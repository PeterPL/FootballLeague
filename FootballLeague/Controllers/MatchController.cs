using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Domain.Abstract;

namespace FootballLeague.Controllers
{
    public class MatchController : Controller
    {
        private IMatchRepository _repository;

        public MatchController(IMatchRepository matchRepository)
        {
            _repository = matchRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
