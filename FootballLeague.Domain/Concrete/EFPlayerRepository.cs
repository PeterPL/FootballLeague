using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using FootballLeague.Domain.Abstract;
using FootballLeague.Domain.Entities;
using System.Data.Entity;

namespace FootballLeague.Domain.Concrete
{
    public class EFPlayerRepository:IPlayerRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Player> Players
        {
            get { return context.Players; }
        }

        public void AddPlayer(Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }
    }
}