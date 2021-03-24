using ItSays.Core.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
