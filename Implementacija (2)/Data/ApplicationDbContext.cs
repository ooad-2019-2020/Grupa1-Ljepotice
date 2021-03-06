﻿using System;
using System.Collections.Generic;
using System.Text;
using Implementacija.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Implementacija.Data
{
    public class ApplicationDbContext : IdentityDbContext<KorisnikPrijava>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
