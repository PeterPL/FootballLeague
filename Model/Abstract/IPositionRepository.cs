
using System.Linq;
using Model.Entities;

namespace Model.Abstract
{
    interface IPositionRepository
    {
        IQueryable<Position> Positions { get; }
    }
}
