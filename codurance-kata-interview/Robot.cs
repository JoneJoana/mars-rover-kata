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
        public string direction; 

        public Robot() 
        { 
            x = 0;
            y = 0;
            direction = "N";
        }

        public string Execute(string command)
        {
            var commands = command.ToArray();     

            foreach (var order in commands)
            {
                
            }

            if (command.Contains("L"))
            {                
                direction = "W";
            }

            if (command.Contains("R"))
            {
                direction = "E";
            }

            if (command.Contains("M"))
            {
                if(direction == "N")
                {
                    y++;
                }
                if(direction == "W")
                {
                    x--;
                }
                if(direction == "E")
                {
                    x++;
                }
                if(direction == "S")
                {
                    y--;
                }                    
            }


            return "0:0:N";
        }
    }  
    
}
