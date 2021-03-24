using ItSays.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool state,string message):this(state)
        {
            Message = message;
        }
        public Result(bool state)
        {
            State = state;
        }

        public bool State { get;}

        public string Message { get; }
    }
}
