﻿namespace CodHap.RemotePairing.DAL
{
    using System;
    using System.Data.Entity;
    using Models;

    public class CalendarContextInitializer : DropCreateDatabaseIfModelChanges<CalendarDbContext>
    {
        protected override void Seed(CalendarDbContext context)
        {
            var calendarEvent = new CalendarEvent()
            {
                Title = "Event initialized from DB",
                Id = "1",
                Start = DateTime.UtcNow.ToString(),
                End = DateTime.UtcNow.AddMinutes(45).ToString()
            };

            context.CalendarEvents.Add(calendarEvent);
            context.SaveChanges();
        }
    }
}