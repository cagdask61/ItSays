using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Abstract
{
    public interface ICategoryService
    {
        IResult GetCategoryAdd(Category category);
        IResult GetCategoryDelete(Category category);
        IResult GetCategoryUpdate(Category category);

        IDataResult<Category> GetByCategoryId(int categoryId);
        IDataResult<List<Category>> GetAllCategory();
        IDataResult<Category> GetByCategoryName(string categoryName);
    }
}
