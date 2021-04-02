using ItSays.Business.Abstract;
using ItSays.Business.Concrete;
using ItSays.DataAccess.Abstract;
using ItSays.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.DependencyResolvers.Ninject
{
    public class NinjectBusinessModule 
        //: NinjectModule
    {
        //public override void Load()
        //{
        //    Bind<IArticleService>().To<ArticleManager>();
        //    Bind<IArticleDal>().To<EfArticleDal>();
        //}
    }
}
