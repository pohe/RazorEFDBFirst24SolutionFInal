using RazorEFDBFirst24Solution.Interfaces;
using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Services.DBServices
{
    public class EventService : IEventService
    {

        private EventMakerDB23Context _context;
        public EventService(EventMakerDB23Context context)
        {
            _context = context;
        }

        public void AddEvent(Event ev)
        {
            _context.Events.Add(ev);
            _context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            _context.Events.Remove(GetEvent(id));
            _context.SaveChanges();
        }

        

        public List<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }

        public Event GetEvent(int id)
        {
            return _context.Events.Find(id);
        }
        public List<Event> FilterEventsByCity(string city)
        {
            return _context.Events.Where(ev => ev.City == city).ToList();
        }
        public List<Event> SearchEventsByCountryCode(string code)
        {
            return _context.Events.Where(ev => ev.CountryCode == code).ToList();
        }

        public void UpdateEvent(Event @evt)
        {
            Event oldEvent = _context.Events.Find(evt.Id);
            oldEvent.Id = evt.Id;
            oldEvent.Name = evt.Name;
            oldEvent.City = evt.City;
            oldEvent.Description = evt.Description;
            oldEvent.DateTime = evt.DateTime;
            oldEvent.CountryCode = evt.CountryCode;
            _context.Events.Update(oldEvent);
        }
    }
}
