
using System.Linq;
using FootballLeague.Domain.Entities;

namespace FootballLeague.Domain.Abstract
{
    public interface IPositionRepository
    {
        IQueryable<Position> Positions { get; }
    }
}
