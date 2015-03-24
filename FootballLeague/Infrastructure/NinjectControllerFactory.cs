using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FootballLeague.Domain.Abstract;
using FootballLeague.Domain.Concrete;
using Ninject;

namespace FootballLeague.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController) ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IClubRepository>().To<EFClubRepository>();
            ninjectKernel.Bind<IPlayerRepository>().To<EFPlayerRepository>();
            ninjectKernel.Bind<IEventKindRepository>().To<EFEventKindRepository>();
            ninjectKernel.Bind<IEventRepository>().To<EFEventRepository>();
            ninjectKernel.Bind<IMatchRepository>().To<EFMatchRepository>();
            ninjectKernel.Bind<IPositionRepository>().To<EFPositionRepository>();
        }
    }
}