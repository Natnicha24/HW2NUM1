using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num1
{
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
        public void FetchPersonList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("-------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name : {0} \nType: Student", person.GetName());
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher", person.GetName());
                }
            }
        }
    }
}
