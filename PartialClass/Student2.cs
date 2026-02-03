using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Student
    {
        public string? stream { get; set; }


        public void getName()
        {
            Console.WriteLine("The Name of the Student is: " + this.Name);
        }

        
    }
}
