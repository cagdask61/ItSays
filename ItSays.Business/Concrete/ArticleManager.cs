using ItSays.Business.Abstract;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Results.Concrete;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ItSays.Business.Constants;
using ItSays.Core.Aspects.Autofac.Validation;
using ItSays.Business.ValidationRules.FluentValidation;
using ItSays.Core.Utilities.Business;
using ItSays.Entities.Dtos;
using ItSays.Business.BusinessAspects.Autofac;
using ItSays.Core.Aspects.Autofac.Caching;

namespace ItSays.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        //[CacheRemoveAspect("IArticleService.Get")]
        [ValidationAspect(typeof(ArticleValidator))]
        //[SecuredOperation("author,admin,moderator")]
        public IResult ArticleAdd(Article article)
        {

            article.Date = DateTime.Now;
            var result = BusinessRules.Run(IfTheseArticlesContain(article.Writing), CheckArticleTitleExists(article.Title), CheckDate(article.Date));

            if (result != null)
            {
                return result;
            }

            _articleDal.Add(article);
            return new SuccessResult(Messages.SuccessAdded);
        }


        //[SecuredOperation("author,admin,moderator")]
        public IResult ArticleDelete(Article article)
        {
            _articleDal.Delete(article);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        [ValidationAspect(typeof(ArticleValidator))]
        //[SecuredOperation("author,admin,moderator")]
        public IResult ArticleUpdate(Article article)
        {
            article.Date = DateTime.Now;
            var result = BusinessRules.Run(IfTheseArticlesContain(article.Writing), CheckArticleTitleExists(article.Title), CheckDate(article.Date));
            if (result != null)
            {
                return result;
            }
            _articleDal.Update(article);
            return new SuccessResult(Messages.SuccessUpdated);
        }

        [CacheAspect(duration: 20)]
        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll().OrderByDescending(ar => ar.Id).ToList());
        }

        [CacheAspect(duration: 20)]
        public IDataResult<List<ArticleDto>> GetArticleDetail()
        {
            return new SuccessDataResult<List<ArticleDto>>(_articleDal.ArticleDetail());
        }

        [CacheAspect(duration: 20)]
        public IDataResult<Article> GetById(int articleId)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(a => a.Id == articleId), Messages.SuccessFilter);
        }

        public IDataResult<List<Article>> GetArticleByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll(c => c.CategoryId == categoryId));
        }

        //--
        public IDataResult<List<ArticleDto>> GetArticleDetailFilterCategory(int categoryId)
        {
            return new SuccessDataResult<List<ArticleDto>>(_articleDal.ArticleDetailFilter(a => a.CategoryId == categoryId));
        }

        public IDataResult<ArticleDto> GetArticleDtoAuthorId(int authorId)
        {
            return new SuccessDataResult<ArticleDto>(_articleDal.ArticleDtoFilter(a => a.AuthorId == authorId));
        }

        public IDataResult<ArticleDto> GetArticleDtoFilterArticle(int Id)
        {
            return new SuccessDataResult<ArticleDto>(_articleDal.ArticleDtoFilter(a => a.Id == Id));
        }

        // Küfür ve kötü söz engelleme
        private IResult IfTheseArticlesContain(string articleWriting)
        {
            BadWords badWords = new BadWords();
            foreach (var item in badWords._word)
            {
                var result = articleWriting.Contains(item);
                if (result)
                {
                    return new ErrorResult(Messages.YouCannotUseThesePosts);
                }
            }
            return new SuccessResult();
        }

        public IDataResult<ArticleDto> GetArticleNewDto(int articleId)
        {
            return new SuccessDataResult<ArticleDto>(_articleDal.ArticleDetailDto(ar=>ar.Number == articleId));
        }

        //
        private IResult CheckArticleTitleExists(string articleTitle)
        {
            var result = _articleDal.GetAll(ar => ar.Title == articleTitle).Any();
            if (result)
            {
                return new ErrorResult(Messages.ArticleTitleAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckDate(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return new ErrorResult(Messages.DateError);
            }
            return new SuccessResult();
        }


    }
}
