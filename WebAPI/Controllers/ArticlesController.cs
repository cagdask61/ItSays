using ItSays.Business.Abstract;
using ItSays.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;
        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }


        [HttpGet("articleall")]
        public IActionResult GetArticleAll()
        {
            var result = _articleService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("articlebyid")]
        public IActionResult GetByArticleId(int articleId)
        {
            var result = _articleService.GetById(articleId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Route("getby/{articleId}")]
        [HttpGet]
        public IActionResult GetByArticleIdRoute(int articleId)
        {
            var result = _articleService.GetById(articleId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("articlebycategoryid")]
        public IActionResult GetArticleByCategoryId(int categoryId)
        {
            var result = _articleService.GetArticleByCategoryId(categoryId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //dto start

        //Blazor
        [HttpGet("articledetaildata")]
        public IActionResult GetArticleDetailData()
        {
            var result = _articleService.GetArticleDetail();
            if (result.State)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [Route("articledetaildata/{articleId}")]
        [HttpGet]
        public IActionResult GetArticleDtoFilterArticleData(int articleId)
        {
            var result = _articleService.GetArticleDtoFilterArticle(articleId);
            if (result.State)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        //blazor -- end

        [HttpGet("articledetail")]
        public IActionResult GetArticleDetail()
        {
            var result = _articleService.GetArticleDetail();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
        [HttpGet("articledetailfiltercategory")]
        public IActionResult GetArticleDetailFilterCategoryId(int categoryId)
        {
            var result = _articleService.GetArticleDetailFilterCategory(categoryId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //
        [HttpGet("articledtoauthor")]
        public IActionResult GetArticleDtoAuthor(int authorId)
        {
            var result = _articleService.GetArticleDtoAuthorId(authorId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //--
        [HttpGet("articledtofilter")]
        public IActionResult GetArticleDtoFilterArticle(int articleId)
        {
            var result = _articleService.GetArticleDtoFilterArticle(articleId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("articledetailnew")]
        public IActionResult GetArticleDetailDto(int articleId)
        {
            var result = _articleService.GetArticleNewDto(articleId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //dto end

        [HttpPost("articleadd")]
        public IActionResult GetArticleAdd(Article article)
        {
            var result = _articleService.ArticleAdd(article);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("articledelete")]
        public IActionResult GetArticleDelete(Article article)
        {
            var result = _articleService.ArticleDelete(article);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("articleupdate")]
        public IActionResult GetArticleUpdate(Article article)
        {
            var result = _articleService.ArticleUpdate(article);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
