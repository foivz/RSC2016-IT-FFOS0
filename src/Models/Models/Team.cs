﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Team
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}