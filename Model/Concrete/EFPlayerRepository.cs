using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFPlayerRepository:IPlayerRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Player> Clubs
        {
            get { return context.Players; }
        }
    }
}