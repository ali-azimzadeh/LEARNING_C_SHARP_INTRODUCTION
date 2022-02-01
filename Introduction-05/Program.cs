using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Startup Method...
        /// </summary>

        public static void Main()
        {

            //*********************************************************************
            // کردن یک شی یا هر چیزی serialize نحوه 
            // Dont use newtonesoft for serialize!
            //*********************************************************************

            //var result1 =
            //    System.Text.Json.JsonSerializer.Serialize<object?>(value: null);

            //Console.WriteLine(result1);

            //*********************************************************************
            // 
            //*********************************************************************

            //var result2 =
            //    System.Text.Json.JsonSerializer.Serialize<object?>(value: 12345);

            //Console.WriteLine(result2);

            //*********************************************************************
            // 
            //*********************************************************************

            //var person1 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //        Description = "Somthings...",
            //    };

            //var result3 =
            //    System.Text.Json.JsonSerializer.Serialize(value: person1);

            //// استفاده کنید چون خود سیستم تشخیص میدهد که شیء مورد نظر generic نیازی نیست بصورت 
            ////از چه جنسی است
            ////var result3 =
            ////    System.Text.Json.JsonSerializer.Serialize<Person>(value: person1);

            //Console.WriteLine(result3);

            //*********************************************************************
            // 
            //*********************************************************************

            //var person2 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //        Description = "Somthings...",
            //    };

            //var person3 =
            //    new Person
            //    {
            //        Age = 15,
            //        FullName = "sara ahmadi",
            //        Description = "Somthings...",
            //    };

            //var company1 =
            //    new Company(name:"Apna Co");

            //company1.Hire(person2);
            //company1.Hire(person3);

            //var result4 =
            //    System.Text.Json.JsonSerializer.Serialize(value: company1);

            //Console.WriteLine(result3);

            //*********************************************************************

            //var option1 =
            //    new System.Text.Json.JsonSerializerOptions
            //    {
            //        WriteIndented = true,
            //    };

            //var result4 =
            //    System.Text.Json.JsonSerializer.Serialize(value: company1,options:option1);

            //Console.WriteLine(result4);

            //*********************************************************************
            // 
            //*********************************************************************

            //var person2 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //        Description = "Somthings...",
            //    };

            //Console.WriteLine(person2);

            //Console.WriteLine(person2.ToString());

            //*********************************************************************
            // 
            //*********************************************************************

            //var person3 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //        Description = "Somthings...",
            //    };

            //string jsonString = 
            //    person3.ToString();

            //var person4 =
            //    System.Text.Json.JsonSerializer.Deserialize<Person>(json:jsonString);

            //string? fullName = 
            //    person4?.FullName;

            //Console.WriteLine(fullName);
        }
    }
}
