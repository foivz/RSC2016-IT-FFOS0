using Models.Models;
using Models.Models.Lookup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ILookupRepository
    {
        Task<List<Country>> GetAllCountriesAsync();

        Task<List<Modifier>> GetAllModifiersAsync();

        Task<List<Category>> GetAllCategoriesAsync();

        Task<List<QuestionType>> GetAllQuestionTypesAsync();
    }
}