using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace IdentityServerAspNetIdentity.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AccessDenied() => View();

    }
}