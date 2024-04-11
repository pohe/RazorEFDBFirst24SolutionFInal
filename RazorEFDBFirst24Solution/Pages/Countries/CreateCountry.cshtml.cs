using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Pages.Countries
{
    public class CreateCountryModel : PageModel
    {
        private ICountryService repo;
        [BindProperty]
        public Country Country { get; set; }
        public CreateCountryModel(ICountryService repository)
        {
            repo = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo.AddCountry(Country);
            return RedirectToPage("IndexCountry");
        }
    }
}
