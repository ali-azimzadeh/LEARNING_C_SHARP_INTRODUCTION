using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_01
//{
//    public class Person : Object
//    {
//        public Person() : base()
//        {
//        }

//        public int Age { get; set; }  // 0

//        //را داشته باشد null به صراحت اعلام نکردیم که می تواند مقدار
//        public string FirstName { get; set; } //null

//        public string LastName { get; set; } //null
//    }
//}

//****************************************************************

//****************************************************************

//namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_01
//{
//    public class Person : Object
//    {
//        public Person() : base()
//        {
//        }

//        public int Age { get; set; }  // 0

//        // را داشته باشد null به صراحت اعلام کردیم که می تواند مقدار 
//        public string? FirstName { get; set; } //null

//        // را داشته باشد null به صراحت اعلام کردیم که می تواند مقدار 
//        public string? LastName { get; set; } //null
//    }
//}

//****************************************************************

//****************************************************************

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_01
{
    public class Person : Object
    {
        public Person(string lastName) : base()
        {
            LastName = lastName;
        }

        public Person() : base() //default constructor 
        {
        }

        public int Age { get; set; }  // 0

        // را داشته باشد null به صراحت اعلام کردیم که می تواند مقدار 
        public string? FirstName { get; set; }


        public string LastName { get; set; } //required
    }
}

