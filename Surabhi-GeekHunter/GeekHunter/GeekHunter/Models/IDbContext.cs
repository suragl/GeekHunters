using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekHunter.Models
{
    interface IDbContext : IDisposable
    {
        DbSet<Candidate> Candidates { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<CandidateSkillMap> CandidateSkillMap { get; set; }
        int SaveChanges();
    }
}
