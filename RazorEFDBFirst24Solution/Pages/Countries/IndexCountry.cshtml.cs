using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Pages.Countries
{
    public class IndexCountryModel : PageModel
    {
        ICountryService repo;

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexCountryModel(ICountryService repository)
        {
            repo = repository;
        }

        public List<Country> Countries { get; private set; }
        public IActionResult OnGet()
        {
            Countries = repo.GetAllCountries();
            return Page();
        }
    }
}
