using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    internal class Student
    {
        int string name;
        int string surname;
        int email;
        int age;

        public void GetFullName() 
        {
            Console.WriteLine(name + " " surname);
        }
        public void GetFullData()
        {
            Console.WriteLine(name + " " +surname + " " + email " "+ age );
        }
    }
}
