﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace App.Areas.Identity.Data
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}