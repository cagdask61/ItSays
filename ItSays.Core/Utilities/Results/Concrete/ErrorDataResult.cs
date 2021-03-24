using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<D> : DataResult<D>
    {
        public ErrorDataResult(D data,string message):base(data,false,message)
        {

        }
        public ErrorDataResult(D data):base(data,false)
        {

        }

        public ErrorDataResult(string message):base(default,false,message)
        {

        }
        public ErrorDataResult():base(default,false)
        {

        }
    }
}
