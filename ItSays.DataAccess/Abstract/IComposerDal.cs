using ItSays.Core.DataAccess.Abstract;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ItSays.DataAccess.Abstract
{
    public interface IComposerDal : IEntityRepository<Composer>
    {
        List<ComposerDto> composerAllDetail();
        ComposerDto composerDetail(Expression<Func<Composer,bool>> filter);
    }
}
