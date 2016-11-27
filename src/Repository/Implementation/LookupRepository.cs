using AutoMapper;
using HackathonVZ.Data;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Models.Lookup;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class LookupRepository : ILookupRepository
    {
        private ApplicationDbContext _context;

        public LookupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            var countries = await _context.Country.ToListAsync();
            return Mapper.Map<List<Country>>(countries);
        }

        public async Task<List<QuestionType>> GetAllQuestionTypesAsync()
        {
            var questionTypes = await _context.QuestionType.ToListAsync();
            return Mapper.Map<List<QuestionType>>(questionTypes);
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            var categories = await _context.Category.ToListAsync();
            return Mapper.Map<List<Category>>(categories);
        }

        public async Task<List<Modifier>> GetAllModifiersAsync()
        {
            var modifiers = await _context.Modifier.ToListAsync();
            return Mapper.Map<List<Modifier>>(modifiers);
        }
    }
}