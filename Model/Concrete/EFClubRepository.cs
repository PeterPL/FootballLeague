using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFClubRepository:IClubRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Club> Clubs
        {
            get { return context.Clubs; }
        }
    }
}