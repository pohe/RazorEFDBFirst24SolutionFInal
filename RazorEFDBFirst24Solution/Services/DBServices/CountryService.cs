using Microsoft.EntityFrameworkCore;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Services.DBServices
{
    public class CountryService : ICountryService
    {
        private EventMakerDB23Context _context;
        public CountryService(EventMakerDB23Context context)
        {
            _context = context;
        }
        public void AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void DeleteCountry(string code)
        {
            _context.Remove(GetCountry(code));
            _context.SaveChanges();
        }

        //public List<Country> GetAllCountries()
        //{
        //    return _context.Countries.Include(c=>c.Events).ToList<Country>();
        //}
        public List<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(string code)
        {
            return _context.Countries.Where<Country>(c => c.Code == code).FirstOrDefault<Country>();
        }
    }
}
