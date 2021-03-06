﻿
using System.Linq;
using Model.Entities;

namespace Model.Abstract
{
    public interface IPositionRepository
    {
        IQueryable<Position> Positions { get; }
    }
}
