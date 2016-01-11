using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace WSIET.Models
{
    public class VisitsContext : DbContext
    {
        public DbSet<LocationModel> Locations { get; set; }
        public DbSet<VisitModel> Visits { get; set; }
    }
}