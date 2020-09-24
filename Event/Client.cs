using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Client
    {
        string number;
        public string Name { get; set; }
        public string Number
        {
            set
            {
                bool good = false;

                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length == 10 && Char.IsNumber(value[i]))
                    {
                        good = true;
                        number = value;
                    }
                    else
                    {
                        throw new Exception("Incorect number");
                    }

                }
                
               
                    
                
            }
            get { return number; }
            
        }
        public Client(string name="NoName",string numb = "Nonumber")
        {
            this.Name = name;
            this.Number = numb;
        }
       
        public override string ToString()
        {
            return $"Naame->{Name}\nNumber->{Number}";
        }
    }
}
