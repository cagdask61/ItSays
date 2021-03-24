using ItSays.Core.DataAccess.EntityFramework;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, ItSaysContext>, IArticleDal
    {
        public List<ArticleDto> ArticleDetail()
        {
            using (ItSaysContext context = new ItSaysContext())
            {
                var join = from ar in context.Articles
                           join au in context.Authors on ar.AuthorId equals au.Id
                           join ca in context.Categories on ar.CategoryId equals ca.Id
                           select new ArticleDto
                           {
                               Number = ar.Id,
                               FirstName = au.FirstName,
                               LastName = au.LastName,
                               Title = ar.Title,
                               Writing = ar.Writing,
                               Date = ar.Date,
                               CategoryName = ca.CategoryName

                           };
                return join.ToList();
            }
        }

        //
        public List<ArticleDto> ArticleDetailFilter(Expression<Func<Article, bool>> filter = null)
        {
            using (ItSaysContext context = new ItSaysContext())
            {
                var join = from ar in filter == null ? context.Articles : context.Articles.Where(filter)
                           join au in context.Authors on ar.AuthorId equals au.Id
                           join ca in context.Categories on ar.CategoryId equals ca.Id
                           select new ArticleDto
                           {
                               Number = ar.Id,
                               FirstName = au.FirstName,
                               LastName = au.LastName,
                               Title = ar.Title,
                               Writing = ar.Writing,
                               Date = ar.Date,
                               CategoryName = ca.CategoryName

                           };
                return join.ToList();
            }
        }

        public ArticleDto ArticleDtoFilter(Expression<Func<Article, bool>> filter = null)
        {
            using (ItSaysContext context = new ItSaysContext())
            {
                var join = from ar in filter == null ? context.Articles : context.Articles.Where(filter)
                           join au in context.Authors on ar.AuthorId equals au.Id
                           join ca in context.Categories on ar.CategoryId equals ca.Id
                           select new ArticleDto
                           {
                               Number = ar.Id,
                               FirstName = au.FirstName,
                               LastName = au.LastName,
                               CategoryName = ca.CategoryName,
                               Title = ar.Title,
                               Writing = ar.Writing,
                               Date = ar.Date
                           };
                return join.SingleOrDefault();
            }
        }
    }
}
