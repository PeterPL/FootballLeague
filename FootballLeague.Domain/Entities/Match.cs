using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeague.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public Club Home { get; set; }
        public Club Away { get; set; }
        public uint HomeGoals { get; set; }
        public uint AwayGoals { get; set; }
    }
}