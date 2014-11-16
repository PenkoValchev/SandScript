using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 
using SandSctipt.Data;
using SandScript.Data.Models;
using System.Web.Routing;

namespace SandScript.Controllers
{
    public class BaseController : Controller
    {
        protected ISandScriptData Data { get; private set; }

        protected User UserProfile { get; private set; }

        public BaseController(ISandScriptData data)
        {
            this.Data = data;
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.UserProfile = this.Data.Users.All().Where(u => u.UserName == requestContext.HttpContext.User.Identity.Name).FirstOrDefault();

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}