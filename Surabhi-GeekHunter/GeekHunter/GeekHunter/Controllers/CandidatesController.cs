using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeekHunter.Models;
using GeekHunter.Data;

namespace GeekHunter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly DataRepository _data;

        public CandidatesController(GeekHunterContext context)
        {
            _data = new DataRepository(context);
        }

        // GET: api/Candidates
        [HttpGet]
        public  List<Candidate> GetCandidate(int skillId)
        {
            return _data.GetCandidates(skillId);
        }


        // POST: api/Candidates
        [HttpPost]
        public Candidate PostCandidate(Candidate candidate)
        {
            return _data.AddCandidate(candidate);
        }
    }
}
