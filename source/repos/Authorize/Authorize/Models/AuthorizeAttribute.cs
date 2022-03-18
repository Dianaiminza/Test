﻿using Microsoft.AspNetCore.Mvc;

namespace Authorize.Models
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(string permission)
            : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { permission };
        }

    }
}
