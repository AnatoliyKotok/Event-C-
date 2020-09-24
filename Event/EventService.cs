using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class EventService
    {
        List<Event_class> events=new List<Event_class>();
        public void AddEvent(Event_class e)
        {
            events.Add(e);
        }
        public void DelEvent(Event_class e)
        {
            events.Remove(e);
        }  
        public void dellAll(Event_class e)
        {
            events.Clear();
        }
        public void FindByData(DateTime data)
        {
            int index = events.FindIndex(e => e.Data == data);
            if (index != -1)
            {
                Console.WriteLine("Event find");
                Console.WriteLine(events[index]);
            }
            else
            {
                Console.WriteLine($"event with data {data:d} not find");
            }
        }
        public void FindFromTo(DateTime from,DateTime to)
        {
             List<Event_class>findedEvents= events.FindAll(c => c.Data>=from&&c.Data<=to);
            foreach(var e in findedEvents)
            {
                Console.WriteLine(e);
            }
        }
        public void FindByClient(Client c)
        {
            foreach(var e in events)
            {
                if (e.cl == c)
                {
                    Console.WriteLine(e);
                }
                else
                {
                    Console.WriteLine($"Client->{c.Name} not found");
                }
            }
        }
    }
}
