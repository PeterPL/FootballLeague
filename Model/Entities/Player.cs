using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;

namespace Model.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public Club Club { get; set; }
    }
}