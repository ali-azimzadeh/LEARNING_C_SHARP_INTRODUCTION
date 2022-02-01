using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Introduction_05
{
    public class Person : object
    {
        public Person() : base()
        {
        }

        public int Age { get; set; }

        public string? FullName { get; set; }


        //با استفاده از این اتریبیوت به سیستم اعلام می کنیم که اگر قرار بود از این
        //  رو وارد بازی نکن Decription بسازی ویژگی  json  کلاس     
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Description  { get; set; }

        public override string ToString()
        {
            string result =
                 Infrastructure.Utility.ConvertObjectToJson(theObject: this);

            return result;
        }
    }
}
