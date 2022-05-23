using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_Robo_Dialer
{
    class CellPhone:Phone
    {
        
       
        public CellPhone(string _name, string _number, int _type):base(_name, _number, _type)
        {
          
        }
        public override string Dial()
        {


            return base.GetName() + " is being dialed using number:  1-" + base.GetNumber(); 
        }
        
       

    }
    
}
