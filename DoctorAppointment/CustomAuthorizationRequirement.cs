using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public class CustomAuthorizationRequirement : IAuthorizationRequirement
    {
        public string Role { get; }

        public CustomAuthorizationRequirement(string role)
        {
            Role = role;
        }
    }
}
