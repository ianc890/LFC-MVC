using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LFCMVC.Models
{
    public class LFCContext : DbContext
    {
        //constructor
        public LFCContext() : base("LFCContext")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Honour> Honours { get; set; }


       
    }
}