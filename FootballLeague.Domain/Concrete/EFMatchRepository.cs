using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FootballLeague.Domain.Abstract;
using FootballLeague.Domain.Entities;

namespace FootballLeague.Domain.Concrete
{
    public class EFMatchRepository:IMatchRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Match> Matches
        {
            get { return context.Matches; }
        }
    }
}