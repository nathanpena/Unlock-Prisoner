using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unlock_Prison.Models;

namespace Unlock_Prison
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"ada", "asdf"},
                {"bda", "asdf" },
                {"cda", "asdf" },
                {"dda", "adfk" },
                {"courselevel", "UG" },
                {"coursenumber","1230" },
                {"isavailable", "1" }
            };

            Course course = new Course();
            Type courseType = course.GetType();
            PropertyInfo[] properties = courseType.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                string setValue;
                string propertyName = CourseMap.keys.FirstOrDefault(m => m.key == property.Name).value;           

                bool foundValue = data.TryGetValue(propertyName, out setValue);
                if (foundValue)
                    try
                    {
                        string caseSwitch = courseType.GetProperty(property.Name).PropertyType.ToString();
                        bool boolValue;
                        bool valid;
                        switch (caseSwitch)
                        {
                            case "System.String":
                                courseType.GetProperty(property.Name).SetValue(course, setValue, null);
                                break;
                            case "System.Int32":
                                int intValue;
                                valid = int.TryParse(setValue, out intValue);
                                if(valid)
                                    courseType.GetProperty(property.Name).SetValue(course, intValue, null);
                                break;
                            case "System.Boolean":
                                valid = bool.TryParse(setValue, out boolValue);
                                if(valid)
                                    courseType.GetProperty(property.Name).SetValue(course, boolValue, null);
                                break;
                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                                  
            }

            Console.WriteLine(course.ToString());
        }
    }
}
