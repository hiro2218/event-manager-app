using System;

namespace EventManagerWebApi.Data.Models;

public class Event
{
    public Event()
    {
        Title = "UNDEFINED";
        Description = "MISSING DESCRIPTION";
        Location = "UNDEFINED";
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DateStartTime { get; set; }
    public DateTime DateEndTime { get; set; }
    public string Location { get; set; }
    public short PlacesAvailable { get; set; }
}
