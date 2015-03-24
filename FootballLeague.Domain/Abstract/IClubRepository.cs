﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeague.Domain.Entities;

namespace FootballLeague.Domain.Abstract
{
    public interface IClubRepository
    {
        IQueryable <Club> Clubs { get; }
    }
}
