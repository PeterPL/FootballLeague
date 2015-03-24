using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeague.Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Played { get; set; }
        public uint Points { get; set; }
        public uint Won { get; set; }
        public uint Drawn { get; set; }
        public uint Lost { get; set; }
        public uint GoalsFor { get; set; }
        public uint GoalsAgainst { get; set; }
    }
}