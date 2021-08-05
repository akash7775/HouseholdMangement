using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HouseholdMangement.Models;

namespace HouseholdMangement.Data
{
    public class HouseholdMangementContext : DbContext
    {
        public HouseholdMangementContext (DbContextOptions<HouseholdMangementContext> options)
            : base(options)
        {
        }

        public DbSet<HouseholdMangement.Models.feedBack> feedBack { get; set; }

        public DbSet<HouseholdMangement.Models.Login> Login { get; set; }

        public DbSet<HouseholdMangement.Models.Items> Items { get; set; }

        public DbSet<HouseholdMangement.Models.Inventory> Inventory { get; set; }

        public DbSet<HouseholdMangement.Models.Sale> Sale { get; set; }
    }
}
