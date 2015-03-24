using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeague.Domain.Entities;

namespace FootballLeague.Domain.Abstract
{
    public interface IMatchRepository
    {
        IQueryable<Match> Matches { get; }
    }
}
