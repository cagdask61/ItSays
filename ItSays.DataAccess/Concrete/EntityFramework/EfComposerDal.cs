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
                               join ar in context.Articles on co.ArticleId equals ar.Id
                               select new ComposerDto
                               {
                                   Number = co.Id,
                                   Title = ar.Title,
                                   FirstName = au.FirstName,
                                   LastName = au.LastName,
                                   Date = ar.Date
                               };
                return joinList.ToList();
            }
        }

        public ComposerDto composerDetail(Expression<Func<Composer, bool>> filter)
        {
            using (ItSaysContext context = new ItSaysContext())
            {
                var joinSingle = from co in filter == null ? context.Composers : context.Composers.Where(filter)
                                 join au in context.Authors on co.AuthorId equals au.Id
                                 join ar in context.Articles on co.ArticleId equals ar.Id
                                 select new ComposerDto
                                 {
                                     Number = co.Id,
                                     FirstName = au.FirstName,
                                     LastName  = au.LastName,
                                     Title = ar.Title,
                                     Date = ar.Date
                                 };
                return joinSingle.SingleOrDefault();
            }
        }
    }
}
