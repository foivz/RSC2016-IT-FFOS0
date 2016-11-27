using Models.Models;
using Models.Models.Lookup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILookupService
    {
        Task<List<Country>> GetAllCountriesAsync();

        Task<List<Modifier>> GetAllModifiersAsync();

        Task<List<Category>> GetAllCategoriesAsync();

        Task<List<QuestionType>> GetAllQuestionTypesAsync();
    }
}