using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeekHunter.Models;
using GeekHunter.Data;

namespace GeekHunter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        private readonly DataRepository _data;
        public SkillController(GeekHunterContext context)
        {
            _data = new DataRepository(context);
        }

        // GET api/skill
        [HttpGet]
        public List<Skill> Get()
        {
            return _data.GetAllSkills();
        }
    }
}