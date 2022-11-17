using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logintest.Models
{
    public class Customer:IdentityUser 
    {
        public string? StripeId { get; set; }
    }
}
