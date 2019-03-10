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

        public List<Candidate> GetCandidates(int skillId)
        {
            List<Candidate> candidates;

            // If skill id is not set send all candidates
            if (skillId == 0)
            {
                candidates = _context.Candidates.ToList();
            }
            else 
            {
                candidates = (from c in _context.Candidates
                              join m in _context.CandidateSkillMap
                              on c.Id equals m.CandidateRefId
                              where m.SkillRefId == skillId
                              select new Candidate
                              {
                                  Id = c.Id,
                                  FirstName = c.FirstName,
                                  LastName = c.LastName
                              }).ToList();
            }

            foreach (var cand in candidates)
            {
                List<CandidateSkillMap> csMaps = _context.CandidateSkillMap.Where(c => c.CandidateRefId.Equals(cand.Id)).ToList();
                foreach (var cs in csMaps)
                {
                    cand.SkillIds.Add(cs.SkillRefId);
                }
            }

            return candidates;
        }

        public Candidate AddCandidate(Candidate candidate)
        {
            candidate.Id = 0;
            _context.Candidates.Add(candidate);
            _context.SaveChanges();

            foreach (var s in candidate.SkillIds)
            {
                var newMap = new CandidateSkillMap { CandidateRefId = candidate.Id, SkillRefId = s };
                _context.CandidateSkillMap.Add(newMap);

            }
            _context.SaveChanges();

            return candidate;
        }


    }
}
