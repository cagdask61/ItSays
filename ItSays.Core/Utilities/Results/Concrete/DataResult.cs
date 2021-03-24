using ItSays.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Concrete
{
    public class DataResult<D> : Result, IDataResult<D>
    {
        public DataResult(D data, bool state, string message):base(state,message)
        {
            Data = data;
        }
        public DataResult(D data, bool state):base(state)
        {
            Data = data;
        }

        public D Data { get; }
    }
}
