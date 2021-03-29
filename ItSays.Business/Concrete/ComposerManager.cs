using ItSays.Business.Abstract;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Results.Concrete;
using ItSays.DataAccess.Abstract;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ItSays.Entities.Dtos;

namespace ItSays.Business.Concrete
{
    public class ComposerManager : IComposerService
    {
        IComposerDal _composerDal;
        public ComposerManager(IComposerDal composerDal)
        {
            _composerDal = composerDal;
        }

        public IDataResult<ComposerDto> GetComposer(int Id)
        {
            return new SuccessDataResult<ComposerDto>(_composerDal.composerDetail(c=>c.Id == Id));
        }

        public IDataResult<List<ComposerDto>> GetComposerDetails()
        {
            return new SuccessDataResult<List<ComposerDto>>(_composerDal.composerAllDetail());
        }
    }
}
