using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Entities.Concrete;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Abstract
{
    public interface IComposerService
    {
        IDataResult<List<ComposerDto>> GetComposerDetails();
    }
}
