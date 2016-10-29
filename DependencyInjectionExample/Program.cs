using DependencyInjectionExample.Interfaces;
using DependencyInjectionExample.Models;
using DependencyInjectionExample.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student utcJames = new Student("James", new UtcEnroller());
            Student localBrett = new Student("Brett", new LocalEnroller());
            Console.ReadLine();
        }
    }
}
