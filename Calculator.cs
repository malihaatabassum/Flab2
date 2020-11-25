using System;
using System.Collections.Generic;
using System.Text;

namespace Flab2
{
    abstract class Calculator
    {
        public string Name { get; set; }
      
       

        public Calculator() { }
        public Calculator(string name)
        {
            Name = name;
           
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
    }
}
    }
}
