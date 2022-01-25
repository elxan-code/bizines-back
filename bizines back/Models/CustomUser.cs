using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bizines_back.Models
{
    public class CustomUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
