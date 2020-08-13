using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories.Cached
{
    public class CustomMemoryCache:ICachedMemory
    {
        IMemoryCache memory;
       
        public CustomMemoryCache(IMemoryCache memory)
        {
            this.memory = memory;
        }

        public IMemoryCache GetCache()
        {
            return memory ;
        }
    }
}
