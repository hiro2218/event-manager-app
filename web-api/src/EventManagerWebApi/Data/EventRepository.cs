using System;
using System.Collections.Generic;
using EventManagerWebApi.Data.Models;

namespace EventManagerWebApi.Data;

public class EventRepository
{
    public List<Event> GetAll()
    {
        List<Event> events = [
            new Event()
            {
                Title = "Event 01",
                Description = "This is a dummy description of an event",
                DateStartTime = new DateTime(2026, 9, 13, 9, 0, 0),
                DateEndTime = new DateTime(2026, 9, 13, 12, 30, 0),
                Location = "Test Location 01",
                PlacesAvailable = 20
            },
            new Event()
            {
                Title = "Event 02",
                Description = "This is a dummy description of an event",
                DateStartTime = new DateTime(2026, 10, 12, 13, 0, 0),
                DateEndTime = new DateTime(2026, 10, 12, 15, 30, 0),
                Location = "Test Location 02",
                PlacesAvailable = 16
            }
        ];

        return events;
    }
}