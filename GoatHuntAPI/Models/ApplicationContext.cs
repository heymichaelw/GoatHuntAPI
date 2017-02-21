using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoatHuntAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Hunt> Hunts { get; set; }
    }
}