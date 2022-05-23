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
       private int Type; // does type need to be protected here?? Or since we aren't doing anything with it, should it just be private?
        // protected string Information;
        // This is a variable I created to hold the "correct" string for dial to return, it was just an
        // experiment to see if I could also override the value of a piece of data, along with reading the data. I like how the subclasses just 
        // act like "setters" it's pretty cool. It's cool to see past knowledge sink into another use than what I am used to.  I was in the middle
        // of making this run the correct way, sending data directly back to the phone, before it sunk in that the subclasses are just setters for the phone
        // class. 
        public string GetName()
        {
            return Name;
        }
        public string GetNumber()
        {
            return Number;
        }
            
        public Phone(string _name,string _number, int _type)
        {
            Name = _name;
            Number = _number;
            Type = _type;    
        }
        public virtual string Dial()
        {
            
            return Name + " is being dialed using the number: " + Number;
        }

        
           
        

      

        //abstract public string Dial(); 
       
    }
}
