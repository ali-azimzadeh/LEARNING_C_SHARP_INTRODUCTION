using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_03
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Startup Method...
        /// </summary>

        public static void Main()
        {
            //سرعت بسیار بالایی دارد
            // اشغال می کند int یعنی در داخل حافظه پنج خانه ی پشت سر هم را به اندازه ی 
            //بعد از اینکه آرایه ایجاد شد امکان تغییر اندازه ی آن وجود ندارد
            //*************************************************************************

            var list =
                new int[5];

            list[0] = 10;
            list[1] = 20;
            list[2] = 30;
            list[3] = 40;
            list[4] = 50;

            //*************************************************************************
            // روش دیگر تعریف آرایه و مقدار دهی اولیه
            var list2 =
                new int[5] { 10, 20, 30, 40, 50 };

            //*************************************************************************

            int[] list3 =
                {10, 20, 30,40, 50};

            //*************************************************************************

            //Compiler Error!

            //var list4 =
            //    { 10, 20, 30, 40, 50 };

            //*************************************************************************
            // Array List
            //*************************************************************************
            //var list4 =
            //    new System.Collections.ArrayList();

            //list4.Add(10);
            //list4.Add(20);
            //list4.Add(30);
            //list4.Add(40);
            //list4.Add(50);

            //foreach (int item in list4)
            //{
            //    Console.WriteLine(item);
            //}

            //*************************************************************************

            //var list5 =
            //  new System.Collections.ArrayList();

            //list5.Add(10);
            //list5.Add(20);

            ////سوتی می دیم و مشکلی که پیش می آید آن است که
            ////خطایی در زمان اجرا اتفاق می افتد نه در زمان کامپایل
            //list5.Add("Hello");

            //list5.Add(40);
            //list5.Add(50);

            //foreach (int item in list5)
            //{
            //    Console.WriteLine(item);
            //}

            //*************************************************************************
            //  List Generic
            //*************************************************************************
            //var list6 =
            //    new System.Collections.Generic.List<int>();

            //list6.Add(10);
            //list6.Add(20);
            //list6.Add(30);
            //list6.Add(40);
            //list6.Add(50);

            //foreach (int item in list6)
            //{
            //    Console.WriteLine(item);
            //}
            //*************************************************************************

            // var list6 =
            //            new System.Collections.Generic.List<int>();

            // list6.Add(10);
            // list6.Add(20);

            // //در این حالت اگر هم سوتی بدیم کامپایلر به ما خطا می دهد و برنامه اجرا نمی شود
            // //ما باید به عنوان یک فرد حرفه ای به گونه ای کد نویسی کنیم که خطاها در زمان 
            // //کامپایل ظاهر شوند و نه در زمان اجرا

            //// list6.Add("Hello World");

            // list6.Add(40);
            // list6.Add(50);

            // foreach (int item in list6)
            // {
            //     Console.WriteLine(item);
            // }

            //*************************************************************************

            var list6 =
                new System.Collections.Generic.List<Person>();

            list6.Add(new Person { Age = 20, FullName = "fullname1" });
            list6.Add(new Person { Age = 30, FullName = "fullname2" });
            list6.Add(new Person { Age = 40, FullName = "fullname3" });
            list6.Add(new Person { Age = 50, FullName = "fullname4" });

            foreach (var item in list6)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.FullName);
            }

            //*************************************************************************


        }
    }
}
