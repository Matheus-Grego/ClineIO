using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;

namespace ClineIO.Infrastructure.GoogleCalendar;

public class GoogleCalendarService : IGoogleCalendarService
{
    private readonly string[] Scopes = { CalendarService.Scope.Calendar };
    private readonly string ApplicationName = "ClineIO";

    private readonly IConfiguration _configuration;

    public GoogleCalendarService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    private async Task<CalendarService> GetServiceAsync()
    {
        UserCredential credential;
        var path = _configuration["GoogleCalendar:CredentialsPath"];


        using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            var credPath = "token.json";

            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true));
        }

        return new CalendarService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });
    }

    public async Task<List<string>> GetEventsAsync()
    {
        var service = await GetServiceAsync();

        var request = service.Events.List("primary");
        request.MaxResults = 10;
        request.TimeMin = DateTime.UtcNow;
        request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;
        request.SingleEvents = true;

        var events = await request.ExecuteAsync();

        return events.Items?
            .Select(e => $"{e.Summary} - {(e.Start.DateTime?.ToString("g") ?? e.Start.Date)}")
            .ToList() ?? new List<string>();
    }

    public async Task CreateEventAsync(string summary, DateTime start, DateTime end, string patientEmail, string doctorEmail)
    {
        var service = await GetServiceAsync();

        var newEvent = new Google.Apis.Calendar.v3.Data.Event()
        {
            Summary = summary,
            Start = new Google.Apis.Calendar.v3.Data.EventDateTime()
            {
                DateTime = start,
                TimeZone = "America/Sao_Paulo"
            },
            End = new Google.Apis.Calendar.v3.Data.EventDateTime()
            {
                DateTime = end,
                TimeZone = "America/Sao_Paulo"
            },
            
            Attendees = new List<EventAttendee>
            {
                new EventAttendee { Email = patientEmail },
                new EventAttendee { Email = doctorEmail }
            }
            
        };

        await service.Events.Insert(newEvent, "primary").ExecuteAsync();
    }
}