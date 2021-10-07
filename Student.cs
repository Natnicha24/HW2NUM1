using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num1
{
    class Student:Person
    {
        private string studentID;
        public Student(string name, string address, string citizenID, string studentID) : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
    }
}
