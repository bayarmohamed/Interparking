using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories.Cached
{
    public interface ICachedMemory
    {
        IMemoryCache GetCache();
    }
}
