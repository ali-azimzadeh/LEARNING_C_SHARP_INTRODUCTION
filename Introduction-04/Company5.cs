using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    public class Company5 : Object
    {
        public Company5(string name) : base()
        {
            Name = name;

            _employees =
                new List<Person>();
        }

        public string Name { get; set; } //requierd

        //private IList<Person> _employees; //Compiler Error!

        //private List<Person> _employees; // تعریف شود read only بهتر است بصورت 

        private readonly List<Person> _employees;

        public System.Collections.Generic.IReadOnlyList<Person> Employees
        {
            get
            {
                //return _employees;

                return _employees.AsReadOnly();
            }
        }



        public void Hire(Person person)
        {

            if (person.Age < 20)
            {
                return;
            }

            //Employees.Add(person);
            //_employees?.Add(person);

            _employees.Add(person);
        }


        //*********************************************************************
        //بودن هر کدام از موارد زیر به خطای   null   دستور زیر ممکن است که در صورت  
        //در زمان اجرا برخورد کند 
        //*********************************************************************

        //string fullName =
        //    company.ManagementOffice.ceo.FullName;

        //*********************************************************************
        // برای حل مشکل بالا باید کدهای زیر را بنویسیم تا کنترل کامل را انجام دهیم
        //*********************************************************************

        // string fullName = null;

        //if(company != null)
        //{
        //    if(company.ManagementOffice != null)
        //    {
        //        if(company.ManagementOffice.ceo != null)
        //        {
        //           //string fullName =
        //             //    company.ManagementOffice.ceo.FullName;
        //        }
        //    }
        //}



        //*********************************************************************
        //  ? نبودن استفاده از علامت null روش جدید و مدرن مایکروسافت برای کنترل 
        //به جای نوشتن شرط های متوالی بالا می توانیم بصورت زیر بنویسیم که کد نویسی کمتری انجام شود
        //*********************************************************************

        //string fullName =
        //    company?.ManagementOffice?.ceo?.FullName;
    }
}
