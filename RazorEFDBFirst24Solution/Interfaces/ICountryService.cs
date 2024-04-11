using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Interfaces
{
    public interface ICountryService
    {
        List<Country> GetAllCountries();
        Country GetCountry(string code);
        void DeleteCountry(string code);
        void AddCountry(Country country);
    }
}
