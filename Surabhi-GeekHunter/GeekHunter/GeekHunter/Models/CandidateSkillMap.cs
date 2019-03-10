using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GeekHunter.Models
{
    [Table("CandidateSkillMap")]
    public class CandidateSkillMap
    {
        public int CandidateRefId { get; set; }

        public int SkillRefId { get; set; }
    }
}
