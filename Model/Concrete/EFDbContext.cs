using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Model.Entities;

namespace Model.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventKind>EventsKind { get; set; }
        public DbSet<Position>Positions { get; set; }
    }
}