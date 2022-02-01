using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_05
{
    public class Company : Object
    {
        public Company(string name) : base()
        {
            Name = name;

            _employees =
                new List<Person>();
        }

        public string Name { get; set; } //requierd


        private readonly List<Person> _employees;

        public System.Collections.Generic.IReadOnlyList<Person> Employees
        {
            get
            {
                //return _employees;

                return _employees.AsReadOnly();
            }
        }



        public void Hire(Person person)
        {

            if (person.Age < 20)
            {
                return;
            }

            //Employees.Add(person);
            //_employees?.Add(person);

            _employees.Add(person);
        }


        //public override string ToString()
        //{
        //    string result =
        //        Infrastructure.Utility.ConvertObjectToJson(this);

        //    return result;
        //}
    }
}
