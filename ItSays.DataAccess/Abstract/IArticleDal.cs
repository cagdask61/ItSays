using ItSays.Core.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ItSays.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
        List<ArticleDto> ArticleDetail();
        //
        List<ArticleDto> ArticleDetailFilter(Expression<Func<Article, bool>> filter = null);
        //
        ArticleDto ArticleDtoFilter(Expression<Func<Article, bool>> filter = null);
        //
        ArticleDto ArticleDetailDto(Expression<Func<ArticleDto, bool>> filter);

        List<ArticleDto> ArticleDetailDtoList(Expression<Func<ArticleDto, bool>> filter);
    }
}
