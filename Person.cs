using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num1
{
    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;

        public Person(string name, string address, string citizenID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
