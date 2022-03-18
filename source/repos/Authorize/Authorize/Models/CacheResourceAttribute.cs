using Microsoft.AspNetCore.Mvc;

namespace Authorize.Models
{
    public class CacheResourceAttribute : TypeFilterAttribute
    {
        public CacheResourceAttribute()
            : base(typeof(CacheResourceFilter))
        {
        }
    }
}
