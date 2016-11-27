using Models.Models;
using Models.Models.Lookup;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class LookupService : ILookupService
    {
        private List<Country> listOfCountries;
        private List<Category> listOfCategories;
        private List<Modifier> listOfModifiers;
        private List<QuestionType> listOfQuestionTypes;

        public ILookupRepository _lookupRepository;

        public LookupService(
            ILookupRepository lookupRepository
            )
        {
            _lookupRepository = lookupRepository;
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            if (listOfCountries == null)
            {
                listOfCountries = await _lookupRepository.GetAllCountriesAsync();
            }
            return listOfCountries;
        }

        public async Task<List<Modifier>> GetAllModifiersAsync()
        {
            if (listOfModifiers == null)
            {
                listOfModifiers = await _lookupRepository.GetAllModifiersAsync();
            }
            return listOfModifiers;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            if (listOfCategories == null)
            {
                listOfCategories = await _lookupRepository.GetAllCategoriesAsync();
            }
            return listOfCategories;
        }

        public async Task<List<QuestionType>> GetAllQuestionTypesAsync()
        {
            if (listOfQuestionTypes == null)
            {
                listOfQuestionTypes = await _lookupRepository.GetAllQuestionTypesAsync();
            }
            return listOfQuestionTypes;
        }
    }
}