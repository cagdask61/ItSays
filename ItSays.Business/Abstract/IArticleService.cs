using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Abstract
{
    public interface IArticleService
    {
        IResult ArticleAdd(Article article);
        IResult ArticleDelete(Article article);
        IResult ArticleUpdate(Article article);

        IDataResult<List<Article>> GetAll();

        IDataResult<Article> GetById(int articleId);

        IDataResult<List<Article>> GetArticleByCategoryId(int categoryId);


        IDataResult<List<ArticleDto>> GetArticleDetail();

        IDataResult<List<ArticleDto>> GetArticleDetailFilterCategory(int categoryId);

        IDataResult<ArticleDto> GetArticleDtoAuthorId(int authorId);

        //
        IDataResult<ArticleDto> GetArticleDtoFilterArticle(int Id);

    }
}
