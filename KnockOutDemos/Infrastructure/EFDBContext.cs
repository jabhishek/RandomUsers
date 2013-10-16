using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KnockOutDemos.Models;

namespace KnockOutDemos.Infrastructure
{
    public class EFDbContext : DbContext
    {
        public DbSet<RandomUser> Users { get; set; }
    }
}