namespace ClineIO.Infrastructure.GoogleCalendar;

public interface IGoogleCalendarService
{
    Task<List<string>> GetEventsAsync();
    Task CreateEventAsync(string summary, DateTime start, DateTime end,  string patientEmail, string doctorEmail);
}