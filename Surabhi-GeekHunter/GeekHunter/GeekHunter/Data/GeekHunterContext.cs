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
        public GeekHunterContext (DbContextOptions<GeekHunterContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CandidateSkillMap> CandidateSkillMap { get; set; }

    }
}
