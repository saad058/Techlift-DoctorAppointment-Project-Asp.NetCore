using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DoctorAppointment
{
    public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        //private readonly string _role;

        //public CustomAuthorizeAttribute(string role)
        //{
        //    _role = role;
        //}

        //public void OnAuthorization(AuthorizationFilterContext context)
        //{
        //    var userRole = context.HttpContext.Session.GetString("Role");
        //    if (userRole != _role)
        //    {
        //        context.Result = new ForbidResult();
        //    }
        //}

        private readonly string[] _roles;

        public CustomAuthorizeAttribute(params string[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userRole = context.HttpContext.Session.GetString("Role");
            if (_roles.All(role => role != userRole))
            {
                context.Result = new ForbidResult();
            }
        }
    }

}
