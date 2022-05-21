using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_Robo_Dialer
{

   abstract  class Phone
    {
       private string Name;
       private string Number;
       private int Type;
        private string Information;
        
        public Phone(string _name,string _number, int _type)
        {
            Name = _name;
            Number = _number;
            Type = _type;    
        }
        public string Dial()
        {
            if (Type == 1)
            {
                Information = "\t" + Name + " is being dialed using phone number " + Number;
            }
            else if (Type == 2)
            {
                Information= "\t" + Name + " is being dialed using phone number 1-" + Number;
            }
            return Information;
        }

        
           
        

      

        //abstract public string Dial(); 
       
    }
}
