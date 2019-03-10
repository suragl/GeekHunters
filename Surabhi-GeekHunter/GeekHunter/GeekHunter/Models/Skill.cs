﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GeekHunter.Models
{
    [Table("Skill")]
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
