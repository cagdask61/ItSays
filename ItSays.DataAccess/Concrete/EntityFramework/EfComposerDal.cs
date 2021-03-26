using ItSays.Core.DataAccess.EntityFramework;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class EfComposerDal : EfEntityRepositoryBase<Composer, ItSaysContext>, IComposerDal
    {
        
    }
}
