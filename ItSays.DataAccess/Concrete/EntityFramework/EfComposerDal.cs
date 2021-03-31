using ItSays.Core.DataAccess.EntityFramework;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class EfComposerDal : EfEntityRepositoryBase<Composer, ItSaysContext>, IComposerDal
    {
        public List<ComposerDto> composerAllDetail()
        {
            using (ItSaysContext context = new ItSaysContext())
            {
                var joinList = from co in context.Composers
                               join au in context.Authors on co.AuthorId equals au.Id
                               select new ComposerDto
                               {
                                   Email = au.Email,
                                   FirstName = au.FirstName,
                                   LastName = au.LastName,
                                  
                               };
                return joinList.ToList();
            }
        }

       
    }
}
