using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekHunter.Models
{
    [Table("Candidate")]
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public List<int> SkillIds { get; set; } = new List<int>();
    }
}
