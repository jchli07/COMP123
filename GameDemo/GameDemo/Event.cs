using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name:    James Li
//Student: ID300588427

namespace GameDemo
{
    class Event : Item
    {
        public EventType Type { get; set; }
        public int Distance { get; set; }
        public double CurrentRecord { get; set; }
        public bool IsMedalEvent { get; set; }

        public Event(string name, int distance, bool isTeamSport, EventType type, double currentRecord, bool isMedalEvent = false)
        {
            Name = name;
            Distance = distance;
            IsTeamSport = isTeamSport;
            Type = type;
            CurrentRecord = currentRecord;
        }
        public int CompareTo(Item item)
        {
            return Name.CompareTo(item.Name);
        }

        public static List<Event> CreateEvents()
        {
            List<Event> events = new List<Event>();
            Event a = new Event("Mens 100m Heats 1", 100, false, EventType.Sprint, 9.63);
            events.Add(a);
            a = new Event("Mens 100m Finals", 100, false, EventType.Sprint, 9.63);
            events.Add(a);
            a = new Event("Women 10000m", 10000, false, EventType.Sprint, 29.17, true);
            events.Add(a);
            a = new Event("Mens Decathlon Finals", 100, false, EventType.Decathlon, 2119,
            false);
            events.Add(a);
            a = new Event("Mens 4X100m", 100, false, EventType.Relay, 29.17, true);
            events.Add(a);
            a = new Event("Mens 100m Heats 3", 100, false, EventType.Sprint, 9.63, true);
            events.Add(a);
            a = new Event("Women 100m", 100, false, (EventType)Enum.Parse(typeof(EventType),
            "Hurdles"), 11.17);
            events.Add(a);
            return events;
        }
    }
}
