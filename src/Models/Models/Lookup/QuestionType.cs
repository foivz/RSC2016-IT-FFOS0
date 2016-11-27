using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models.Lookup
{
    public class QuestionType
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Abrv { get; set; }

        public int TimerSeconds { get; set; }
    }
}