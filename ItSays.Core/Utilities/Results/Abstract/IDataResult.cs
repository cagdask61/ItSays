using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Abstract
{
    public interface IDataResult<D> : IResult
    {
        D Data { get; }
    }
}
