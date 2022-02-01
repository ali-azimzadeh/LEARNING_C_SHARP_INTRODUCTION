using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
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
            // روش ذیل خیلی خطرناکه و همیشه با ترس و لرز استفاده می کنیم
            //*********************************************************************

            //var company1 =
            //    new Company1(name: "Apna co");

            //var person1 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //    };

            //// اشکال اول
            //// شده یا نه  new قبلا  Employees اشکال اینجاست که نمی دانیم لیست   
            ////Runtime Error!
            ////company1.Employees.Add(person1);

            //if (company1.Employees == null)
            //{
            //    //اشکال دوم 
            //    //اشکال اینجاست که می توان با این روش لیست کارمندان را به راحتی 
            //    //برابر با یک لیست دیگر قرار داد که این کار درست و حرفه ای نیست
            //    company1.Employees =
            //        new List<Person>();
            //}

            //company1.Employees.Add(person1);

            //foreach (var item in company1.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************
            // روش ذیل یگر خطرناک نیست و  ترس و لرزی نداریم
            //ولی یک اشکال دیگر دارد 
            //مثلا درشرایطی که ما نیازی به فهرست کارکنان نداریم
            //بیخودی لیست ایجاد می شود
            //*********************************************************************

            //var company2 =
            //    new Company2(name: "Apna co");

            //var person2 =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Azimzadeh",
            //    };

            ////Compiler Error!

            ////company2.Employees =
            ////    new List<Person>();

            //company2.Employees.Add(person2);


            //foreach (var item in company2.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************
            // روش ذیل هم خطرناک نیست و  ترس و لرزی نداریم
            //و درشرایطی که ما نیازی به فهرست کارکنان نداریم
            //بیخودی لیست ایجاد نمی شود
            //حال فرض می کنیم که شخصی را می خواهیم در شرکت استخدام کنیم و
            //طبق قوانین شرکت فقط می توانیم افراد بالای 20 سال را استخدام کنیم
            //*********************************************************************

            //var company3 =
            //    new Company3(name: "Apna co");

            //var person1 =
            //    new Person
            //    {
            //        Age = 25,
            //        FullName = "Ali Azimzadeh",
            //    };


            //company3.Employees.Add(person1);


            //var person2 =
            //    new Person
            //    {
            //        Age = 15,
            //        FullName = "sara ahmadi",
            //    };

            //company3.Employees.Add(person2);


            //foreach (var item in company3.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************
            // هر چند که با این روش مشکل مدیریت سن استخدام را رفع کردیم
            //بصورت مستقیم از همان Hire ولی همچنان ممکن است که به جای استفاده از متد  
            //استفاده شود که باز هم خطر در نقض قانون شرکت وجود خواهد داشت employees لیست 
            //*********************************************************************

            //var company4 =
            //         new Company4(name: "Apna co");

            //var person1 =
            //    new Person
            //    {
            //        Age = 25,
            //        FullName = "Ali Azimzadeh",
            //    };


            //company4.Hire(person1);


            //var person2 =
            //    new Person
            //    {
            //        Age = 15,
            //        FullName = "sara ahmadi",
            //    };

            //company4.Hire(person2);

            //company4.Employees.Add(person2);

            //foreach (var item in company4.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************
            // هر چند که با این روش مشکل مدیریت سن استخدام را رفع کردیم
            //بصورت مستقیم از همان Hire ولی همچنان ممکن است که به جای استفاده از متد  
            //استفاده شود که باز هم خطر در نقض قانون شرکت وجود خواهد داشت employees لیست 
            //*********************************************************************

        //    var company5 =
        //        new Company5(name: "Apna co");

        //    var person1 =
        //        new Person
        //        {
        //            Age = 25,
        //            FullName = "Ali Azimzadeh",
        //        };


        //    company5.Hire(person1);


        //    var person2 =
        //        new Person
        //        {
        //            Age = 15,
        //            FullName = "sara ahmadi",
        //        };

        //    company5.Hire(person2);

        //    //Compiler Error!
        //    //company5.Employees.Add(person2); 

        //    foreach (var item in company5.Employees)
        //    {
        //        Console.WriteLine(item);
        //    }
        }
    }
}
