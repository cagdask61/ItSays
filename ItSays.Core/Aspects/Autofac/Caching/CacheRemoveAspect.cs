using Microsoft.Extensions.DependencyInjection;
using ItSays.Core.CrossCuttingConcerns.Caching.Abstract;
using ItSays.Core.Utilities.Interceptors;
using ItSays.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace ItSays.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.CachingRemoveByPattern(_pattern);
        }
    }
}
