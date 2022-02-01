using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_04
{
    /// <summary>
    /// کارهای زیر را انجام می دهیم company1 برای بهینه تر شدن کلاس 
    /// حذف می کنیم Employeesرا از  set
    /// عمل کنیم constructor بهتر است برای دادن مقدار اولیه به لیست در 
    ///مقدار دهی شوند  constructor تعریف می شوند می توانند فقط در  read only هاو فیلدهایی که بصورت  property
    /// استفاده شود List به جای  IList بهتر است از اینترفیس
    /// </summary>
    public class Company2 : Object
    {
        public Company2(string name) : base()
        {
            Name = name;

            Employees =
                new List<Person>();
        }

        public string Name { get; set; } //requierd

        //new in c#:
        //public IList<Person> Employees { get; } = new List<Person>();
        public IList<Person> Employees { get; } //Read only
    }
}
