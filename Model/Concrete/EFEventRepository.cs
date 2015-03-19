using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFEventRepository:IEventRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Event> Clubs
        {
            get { return context.Events; }
        }
    }
}