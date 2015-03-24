using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FootballLeague.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public Match Match { get; set; }
        public Club Club { get; set; }
        public Player Player { get; set; }
        public EventKind Kind { get; set; }
        public uint Time { get; set; }
    }
}