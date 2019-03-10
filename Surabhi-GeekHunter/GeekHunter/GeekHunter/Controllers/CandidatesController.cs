using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeekHunter.Models;

namespace GeekHunter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly GeekHunterContext _context;

        public CandidatesController(GeekHunterContext context)
        {
            _context = context;
        }

        // GET: api/Candidates
        [HttpGet]
        public  List<Candidate> GetCandidate()
        {
            return _context.Candidates.ToList();
        }


        // POST: api/Candidates
        [HttpPost]
        public Candidate PostCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();

            return candidate;
        }

        
    }
}
