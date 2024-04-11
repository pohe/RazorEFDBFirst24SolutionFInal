using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Pages.Events
{
    public class EditEventModel : PageModel
    {
        IEventService repo;
        [BindProperty]
        public Event Event { get; set; }
        public EditEventModel(IEventService repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int id)
        {
            Event = repo.GetEvent(id);
            if (Event == null)
            {
                return null;
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateEvent(Event);
            return RedirectToPage("IndexEvent");
        }
    }
}
