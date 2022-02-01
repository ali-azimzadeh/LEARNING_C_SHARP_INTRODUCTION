using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    public class Person : object
    {
        public Person() : base()
        {
        }

        public int Age { get; set; }

        public string? FullName { get; set; }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        public override string ToString()
        {
            var stringBuilder =
                new StringBuilder();

            stringBuilder.Append($"My {nameof(FullName)} is ");

            stringBuilder.Append($"{ FullName } and {nameof(Age)}");

            stringBuilder.Append($":{ Age }years old");
            //            result10.AppendLine();

            string result =
                stringBuilder.ToString();

            return result;
        }
    }
}
