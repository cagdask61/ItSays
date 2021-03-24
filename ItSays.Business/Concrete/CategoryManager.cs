using ItSays.Business.Abstract;
using ItSays.Business.BusinessAspects.Autofac;
using ItSays.Business.Constants;
using ItSays.Core.Aspects.Autofac.Caching;
using ItSays.Core.Utilities.Business;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Results.Concrete;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItSays.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [CacheAspect(duration:30)]
        public IDataResult<List<Category>> GetAllCategory()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }


        public IDataResult<Category> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.Id == categoryId));
        }

        public IDataResult<Category> GetByCategoryName(string categoryName)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryName == categoryName));
        }

        //[SecuredOperation("admin,moderator")]
        public IResult GetCategoryAdd(Category category)
        {
            var result = BusinessRules.Run(CheckCategoryNameExists(category.CategoryName));
            if (result != null)
            {
                return result;
            }
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        //[SecuredOperation("admin")]
        public IResult GetCategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        //[SecuredOperation("admin,moderator")]
        public IResult GetCategoryUpdate(Category category)
        {
            var result = BusinessRules.Run(CheckCategoryNameExists(category.CategoryName));
            if (result != null)
            {
                return result;
            }
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        //
        private IResult CheckCategoryNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(c => c.CategoryName == categoryName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CategoryAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
