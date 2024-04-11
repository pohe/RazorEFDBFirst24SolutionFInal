using RazorEFDBFirst24Solution.Models;

namespace RazorEFDBFirst24Solution.Interfaces
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void DeleteEvent(int id);
        void UpdateEvent(Event ev);
        List<Event> FilterEventsByCity(string city);
        List<Event> SearchEventsByCountryCode(string code);
    }
}
