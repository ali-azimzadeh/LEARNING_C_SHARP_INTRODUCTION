using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Startup Method...
        /// </summary>

        public static void Main()
        {

            var person =
                new Person
                {
                    Age = 20,
                    FullName = "Ali Azimzadeh",
                };

            //Result = "My Name is Ali Azimzadeh and Age :20 years old"

            //*********************************************************************
            //String concatinate
            string result1 = "My FullName is " + person.FullName + "and Age:" + person.Age + "years old";

            Console.WriteLine(result1);
            //*********************************************************************

            string result2 =
                "My FullName is " + person.FullName + "and Age:" + person.Age + "years old";

            Console.WriteLine(result2);
            //*********************************************************************

            string result3 =
                string.Format("My FullName is {0} and age :{1} years old", person.FullName, person.Age);

            Console.WriteLine(result3);
            //*********************************************************************

            int A = 10;
            int B = 20;
            int C = 30;

            string result4 =
                string.Format("A={1},B={0},C{2}", A, B, C);

            Console.WriteLine(result4);

            //out put : A=20,B=10,C=30
            //*********************************************************************

            string result5 =
                $"My FullName is { person.FullName } and Age:{ person.Age }years old";

            Console.WriteLine(result5);
            //*********************************************************************

            //اگر موقع تایپ کردن سوتی بدیم کامپایلر به ما خطا نمی دهد
            string result6 =
               $"My FoolName is { person.FullName } and Aig:{ person.Age }years old";

            Console.WriteLine(result6);
            //*********************************************************************

            //اگر موقع تایپ کردن سوتی بدیم کامپایلر به ما خطا می دهد
            //string result7 =
            //    $"My {nameof(person.FoolName)} is { person.FullName } and {nameof(person.Aig)}:{ person.Age }years old";

            //*********************************************************************

            //روش زیر اصلا هوشمندانه و مناسب نیست 
            // !را در می آورد memory چون پدر 
            string result8 =
                $"My {nameof(person.FullName)} is " +
                $"{ person.FullName } and {nameof(person.Age)}" +
                $":{ person.Age }years old";

            Console.WriteLine(result8);
            //*********************************************************************

            string result9;
            result9 = "A";  //"A"
            result9 += "B"; //"AB"
            result9 += "C"; //"ABC"
            result9 += "D"; //"ABCD"
            result9 += "E"; //"ABCDE"

            Console.WriteLine(result9);
            //*********************************************************************

            //بهترین روش استفاده از کلاس string  نکته : اگر به هر دلیلی خواستید چند تا   
            //است stringbuilder  را با هم جمع کنید

            //*********************************************************************

            var result10 =
                new StringBuilder();

            result10.Append($"My {nameof(person.FullName)} is ");
            result10.Append($"{ person.FullName } and {nameof(person.Age)}");
            result10.Append($":{ person.Age }years old");
            //            result10.AppendLine();

            string result11 =
                result10.ToString();

            Console.WriteLine(result11);

        }
    }
}
