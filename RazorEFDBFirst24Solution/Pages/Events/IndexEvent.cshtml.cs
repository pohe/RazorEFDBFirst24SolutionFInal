using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Pages.Events
{
    public class IndexEventModel : PageModel
    {
        private IEventService _eventService;

        [BindProperty]
        public List<Event> Events { get; set; }
        public IndexEventModel(IEventService eventService) 
        {
            _eventService = eventService;
        }

        public void OnGet(string countryCode)
        {
            Events = _eventService.GetAllEvents().FindAll(e=> e.CountryCode == countryCode);
        }
    }
}
