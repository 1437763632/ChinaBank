using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models

{
    public class LoginFatier:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["Name"] ==null)
            {
                filterContext.HttpContext.Response.Redirect("/Login/Login");
            }
        }
    }
}