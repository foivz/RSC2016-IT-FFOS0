using DAL.Models;
using Models.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonVZ.ViewModels.Home
{
    public class MainGameViewModel
    {
        public Quiz Quiz { get; set; }
        public List<RoundDto> Rounds { get; set; }
    }
}