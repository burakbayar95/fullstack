using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
       

        public Team(int id,string name)
        {
            ID = id;
            Name = name;

        }


       
    }
}
