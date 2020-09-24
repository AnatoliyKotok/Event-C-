using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Event_class
    {
        string name;
        int countPeople;
        static int lastid;
        int id;
        public Client cl;
        public string Name { get=>name; set=>name=value; }
        public int CountPeople { get => countPeople; set => countPeople = value; }
        public DateTime Data{get;set;}
        public Event_class(string name, int count, Client c, DateTime data)
        {
            this.name = name;
            this.CountPeople = count;
            this.cl = c;
            if (data <= DateTime.Today)
            {
                throw new Exception("Bad data");
            }
            else
            {
                this.Data = data;
            }
            id = ++lastid;
           

        }
        public override string ToString()
        {
            return cl.ToString()+$"\nEvent name->{Name}\nCount people->{CountPeople}\nData->{Data:d}\nEvent id->{id}";
        }
        public void AddDay(double days)
        {
            if (days < 0)
            {
                throw new Exception("Bad count of days");
            }
            else
            {
                DateTime today = this.Data;
                this.Data = today.AddDays(days);
            }
        }
        public void AddWeek(double weeks)
        {
            if (weeks < 0)
            {
                throw new Exception("Bad count of weeks");
            }
            else
            {
                double days = weeks * 7;
                DateTime today = this.Data;
                this.Data = today.AddDays(days);
            }
        }
    }
}
