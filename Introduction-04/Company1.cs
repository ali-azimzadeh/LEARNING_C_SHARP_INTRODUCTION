using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    public class Company1 :Object
    {
        public Company1(string name) :base()
        {
            Name = name;
        }

        public string Name { get; set; } //requierd

        public List<Person>? Employees { get; set; }
    }
}
