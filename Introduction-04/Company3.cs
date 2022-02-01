using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    public class Company3 : Object
    {
        public Company3(string name) : base()
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
                if(_employees == null)
                {
                    _employees =
                        new List<Person>();
                }

                return _employees;
            }
        }
    }
}
