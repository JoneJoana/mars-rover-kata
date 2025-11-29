using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace codurance_kata_interview
{    
    public class Robot
    {
        public int x;
        public int y;
        public string Direction; 

        public Robot() 
        { 
            x = 0;
            y = 0;
            Direction = "N";
        }

        public string Execute(string command)
        {
            var commands = command.ToArray();     

            foreach (var order in commands)
            {
                
            }

            if (command.Contains("L"))
            {                
                Direction = "W";
            }

            if (command.Contains("R"))
            {
                Direction = "E";
            }

            if (command.Contains("M"))
            {
                if(Direction == "N")
                {
                    y++;
                }
                if(Direction == "W")
                {
                    x--;
                }
                if(Direction == "E")
                {
                    x++;
                }
                if(Direction == "S")
                {
                    y--;
                }                    
            }
            return $"{x}:{y}:{Direction}";
        }
    }  
    
}
