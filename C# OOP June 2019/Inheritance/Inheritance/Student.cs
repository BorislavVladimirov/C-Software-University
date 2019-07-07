using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : Person
    {
        public Student(string name, string school)
            :base(name)
        {
            this.School = school;
        }

        public string School { get; set; }
    }
}
