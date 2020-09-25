using System;
using System.Collections.Generic;

namespace labb2ny
{
    class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Worker();
            var emp = new List<Worker>();
            emp.Add(mechanic);
            var depart = new List<Departments>();
            var workshop = new Departments();
            depart.Add(workshop);
        }
    }
}
