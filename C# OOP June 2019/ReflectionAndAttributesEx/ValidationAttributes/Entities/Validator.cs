using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Entities
{
    public static class Validator 
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propInfo = obj.GetType().GetProperties();
            foreach (var property in propInfo)
            {
                MyValidationAttribute[] attributes = property.GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute).Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attr in attributes)
                {
                    if (!attr.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }  
            }

            return true;
        }
    }
}
