using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekHunter.Models;

namespace GeekHunter.Data
{
    interface IDbContext : IDisposable
    {
        DbSet<Candidate> Candidates { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<CandidateSkillMap> CandidateSkillMap { get; set; }
        int SaveChanges();
    }
}
