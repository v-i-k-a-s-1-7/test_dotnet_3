using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Student
    {
        // Personal Details
        public int StudentID { get; set;}
        public string? Name { get; set; }
        public int PhoneNumber { get; set; }
        public string FatherName { get; set; }

        public void getPhoneNumber(int phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }


    }
}
