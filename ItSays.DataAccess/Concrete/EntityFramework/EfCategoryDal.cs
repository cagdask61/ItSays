using ItSays.Core.DataAccess.EntityFramework;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ItSaysContext>, ICategoryDal
    {
        
    }
}
