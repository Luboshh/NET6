﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // tady pridavali connection string do SQLite
        }
    }
}
