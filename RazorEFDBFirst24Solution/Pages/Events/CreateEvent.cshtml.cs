using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        IEventService repo;
        ICountryService countryService;

        [BindProperty]
        public Event Event { get; set; }
        public CreateEventModel(IEventService repository, ICountryService crepo)
        {
            repo = repository;
            Event = new Event();
            countryService = crepo;
        }
        public IActionResult OnGet(string Code)
        {
            Event.CountryCode = Code;
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Event.CountryCodeNavigation = countryService.GetCountry(Event.CountryCode); 
            repo.AddEvent(Event);
            //return RedirectToPage("IndexEvent");
            return RedirectToPage("IndexEvent", new { countryCode = Event.CountryCode});
        }
    }
}
