using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Quiz
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public int MaxTeams { get; set; }
        public DateTime StartTime { get; set; }
        public bool Finished { get; set; }
    }
}