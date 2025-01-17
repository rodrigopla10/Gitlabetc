﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitlabetcAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GitlabetcAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
