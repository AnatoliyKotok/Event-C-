using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client c = new Client("Den","1234567890");
                Client c2 = new Client("Bob", "1234567890");
                Event_class ev = new Event_class("Weedeng", 150, c, new DateTime(2020, 12, 12));
                Event_class ev2 = new Event_class("Birdh", 20, c2, new DateTime(2020, 11, 20));
                EventService es=new EventService();
                es.AddEvent(ev);
                //es.AddEvent(ev2);
                //es.FindByData(new DateTime(2020, 12, 12));
                //es.FindFromTo(new DateTime(2020, 10, 1), new DateTime(2020, 12, 14));
                es.FindByClient(c2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
