using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.CrossCuttingConcerns.Caching.Abstract
{
    public interface ICacheManager
    {
        A Get<A>(string key);
        object Get(string key);
        void CachingAdd(string key, object value, int duration);
        bool IsAdd(string key);
        void CachingRemove(string key);
        void CachingRemoveByPattern(string pattern);
    }
}
