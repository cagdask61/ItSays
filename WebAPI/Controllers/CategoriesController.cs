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
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("categoryall")]
        public IActionResult Getall()
        {
            var result = _categoryService.GetAllCategory();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("categorybyId")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = _categoryService.GetByCategoryId(categoryId);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("categorybyname")]
        public IActionResult GetByCategoryName(string categoryName)
        {
            var result = _categoryService.GetByCategoryName(categoryName);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("categoryadd")]
        public IActionResult GetCategoryAdd(Category category)
        {
            var result = _categoryService.GetCategoryAdd(category);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("categorydelete")]
        public IActionResult GetCategoryDelete(Category category)
        {
            var result = _categoryService.GetCategoryDelete(category);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("categoryupdate")]
        public IActionResult GetCategoryUpdate(Category category)
        {
            var result = _categoryService.GetCategoryUpdate(category);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
