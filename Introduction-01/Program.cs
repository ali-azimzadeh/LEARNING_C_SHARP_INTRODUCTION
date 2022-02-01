using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Startup Method...
        /// </summary>

        public static void Main()
        {
            //****************************************************************
            //Person person =
            //   new Person(lastName: null); // تخصیص دهیم lastName را به  null ما نباید مقدار   
            //****************************************************************

            //****************************************************************
            //Person person =
            //    new Person(lastName: "azimzadeh");

            //// تخصیص دهیم lastName را به  null ما نباید مقدار  
            //person.LastName = null;
            //****************************************************************

            //****************************************************************
            //Person person = new Person(lastName: "azimzadeh");

            //person.FirstName = "Ali";
            //person.Age = 20;
            //****************************************************************

            //****************************************************************
            //Person person = new(lastName: "azimzadeh");

            //person.FirstName = "Ali";
            //person.Age = 20;
            //****************************************************************

            //****************************************************************
            //var person = new Person(lastName: "azimzadeh");


            //person.FirstName = "Ali";
            //person.Age = 20;
            //****************************************************************

            //****************************************************************
            // برای تعریف متغیر استفاده می کنید حتما باید مقدار اولیه به آن بدهید var نکته : وقتی از    
            //var x; //Compiler Error!

            //var person = new Person(lastName: "azimzadeh");

            //person.FirstName = "Ali";
            //person.Age = 20;
            //****************************************************************

            //****************************************************************
            //var person = new Person(lastName: "azimzadeh")
            //{
            //    Age = 20,
            //    FirstName = "Ali"
            //};
            //****************************************************************

            //****************************************************************
            //var person = new Person(lastName: "azimzadeh") { Age = 20, FirstName = "Ali" };
            //****************************************************************

            //****************************************************************
            //var person =
            //  new Person(lastName: "azimzadeh")
            //  {
            //      Age = 20,
            //      FirstName = "Ali",
            //  };
            //****************************************************************

            //****************************************************************
            //var person =
            //  new Person()
            //  {
            //      Age = 20,
            //      FirstName = "Ali",
            //      LastName = "Azimzadeh",
            //  };
            //****************************************************************

            //****************************************************************
            //var person =
            //  new Person
            //  {
            //      Age = 20,
            //      FirstName = "Ali",
            //  };
            //****************************************************************
        }
    }
}
