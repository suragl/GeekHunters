using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeekHunter.Models;

namespace GeekHunter.Data
{
    public class GeekHunterContext : DbContext, IDbContext
    {
        private static bool _created = false;
        public GeekHunterContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
                Database.Migrate();
            }
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CandidateSkillMap> CandidateSkillMap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = Database/GeekHunter.sqlite ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateSkillMap>()
                .HasKey(cs => new { cs.CandidateRefId, cs.SkillRefId });
        }

    }
}

