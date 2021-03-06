﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
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