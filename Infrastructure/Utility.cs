using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_C_SHARP_INTRODUCTION.Infrastructure
{
    static class Utility
    {
        static Utility()
        {
        }

        public static DateTime Now
        {
            get
            {
                var result =
                    System.DateTime.Now;

                //var result =
                //    System.DateTime.UtcNow;

                return result;
            }
        }

        public static string ConvertObjectToJson(object theObject,bool isWriteIndent=true)
        {
            var option =
                new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = isWriteIndent,
                };


            var result =
                System.Text.Json.JsonSerializer
                .Serialize(value: theObject, options: option);

            return result;

        }
    }
}
