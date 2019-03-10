using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekHunter.Models;

namespace GeekHunter.Data
{
    public class DataRepository
    {
        private readonly GeekHunterContext _context;

        public DataRepository(GeekHunterContext context)
        {
            _context = context;
        }

        public List<Candidate> GetCandidates()
        {
            return _context.Candidates.ToList();
        }

        public Candidate AddCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();

            return candidate;
        }


    }
}
