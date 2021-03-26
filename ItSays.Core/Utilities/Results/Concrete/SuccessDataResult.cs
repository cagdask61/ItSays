using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<D> : DataResult<D>
    {
        public SuccessDataResult(D data, string message):base(data,true,message)
        {

        }
        public SuccessDataResult(D data):base(data, true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        
    }
}
