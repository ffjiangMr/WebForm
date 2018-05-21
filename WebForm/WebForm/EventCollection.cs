using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm
{
    public enum EventSource
    {
        Application,
        Page,
        MasterPage,
        Control
    }

    public class EventDescription
    {
        public EventSource Source { get; set; }
        public String Type { get; set; }
    }

    public class EventCollection
    {
        private static List<EventDescription> events = new List<EventDescription>();

        public static void Add(EventSource level, String type)
        {
            events.Add(new EventDescription() { Source = level,Type = type });
            System.Diagnostics.Debug.WriteLine($"Event:{level},{type}"); 
        }
    }
}