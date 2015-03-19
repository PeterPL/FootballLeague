using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFPositionRepository:IPositionRepository
    {
    
        private EFDbContext context = new EFDbContext();
        public IQueryable<Position> Positions
        {
            get { return context.Positions; }
        }
    }
}