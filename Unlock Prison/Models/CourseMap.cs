using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Unlock_Prison.Models
{
    public class CourseMap
    {

        public struct KeyStruct
        {
            public string key;
            public string value;

            public KeyStruct(string key, string value)
            {
                this.key = key;
                this.value = value;
            }

        }

       
        public static List<KeyStruct> keys = new List<KeyStruct>()
        {
             new KeyStruct ("Ada", "ada"),
             new KeyStruct ("Bda", "bda"),
             new KeyStruct ("Cda", "cda"),
             new KeyStruct ("Dda", "dda"),
             new KeyStruct ("CourseLevel", "courselevel"),
             new KeyStruct ("CourseNumber", "coursenumber"),
             new KeyStruct ("IsAvailable", "isavailable")
        };
    }
}