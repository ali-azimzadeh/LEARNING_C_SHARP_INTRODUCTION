using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_02
{
    public class Person : object
    {
        public Person() : base()
        {
        }

        public int Age { get; set; }

        public string? FullName { get; set; }
    }
}
