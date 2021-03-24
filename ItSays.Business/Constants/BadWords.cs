using ItSays.Core.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Constants
{
    public class BadWords : IBadWord
    {
        public List<string> _word = new List<string>() 
        {
            "Hıyar", "Salak", "Mal", "Aptal","Beyinsiz"
        };
    }
}
