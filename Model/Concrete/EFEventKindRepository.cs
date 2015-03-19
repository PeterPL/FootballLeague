using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFEventKindRepository:IEventKindRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<EventKind> Clubs
        {
            get { return context.EventsKind; }
        }
    }
}