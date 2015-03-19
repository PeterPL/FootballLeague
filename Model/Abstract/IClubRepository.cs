﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Abstract
{
    interface IClubRepository
    {
        IQueryable <Club> Clubs { get; }
    }
}
