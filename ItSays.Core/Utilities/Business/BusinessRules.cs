using ItSays.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.State)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
