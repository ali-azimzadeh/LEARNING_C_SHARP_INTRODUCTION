using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    public class Company4 : Object
    {
        public Company4(string name) : base()
        {
            Name = name;
        }

        public string Name { get; set; } //requierd

        private IList<Person>? _employees;

        /// <summary>
        /// Lazy Loading =  Lazy Initialization
        /// </summary>
        public IList<Person> Employees
        {
            get
            {
                if (_employees == null)
                {
                    _employees =
                        new List<Person>();
                }

                return _employees;
            }
        }

        public void Hire(Person person)
        {
            //در اینجا نیازی به کنترل نیست
            //if (person == null)
            //{
            //    return;
            //}

            if (person.Age < 20)
            {
                return;
            }

            Employees.Add(person);

            //تا جایی که امکان داشته باشد درون کلاس از فیلد متناظر 
            // استفاده نمی کنیم property
            //_employees.Add(person);
        }
    }
}
