using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Employee
    {
        private static int _Counter = 1;
        public int ID;
        public string _fullname;
        public int _department;
        public double _salary;

        public Employee(string fullname, int department, double salary)
        {
            ID = Counter;
            Counter++;
            _fullname = fullname;
            _department = department;
            _salary = salary;
        }
        public string Fullname
        {
            get => _fullname;
            set => _fullname = value;
        }
        public int Department
        {
            get => _department;
            set => _department = value;
        }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public int Counter
        {
            get => _Counter;
            set => _Counter = value;
        }
    }
}
