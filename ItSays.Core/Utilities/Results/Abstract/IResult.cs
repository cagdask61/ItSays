using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Abstract
{
    public interface IResult
    {
         bool State { get; }
         string Message { get; }
    }
}
