using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    class Student
    {
        public string Name { get; set; }

        public Student(string studentName, IEnroller enroller)
        {
            enroller.Write($"New student { studentName } has been enrolled!");
        }
    }
}
