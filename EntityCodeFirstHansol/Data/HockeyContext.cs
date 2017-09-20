using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityCodeFirstHansol.Models;

namespace EntityCodeFirstHansol.Data
{
    public class HockeyContext: DbContext
    {
        public HockeyContext()
                :base("DefaultConnection")
        { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
       
    }
}