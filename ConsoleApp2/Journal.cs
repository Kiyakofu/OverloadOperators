using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace OverloadOperators
{
    internal class Journal
    {
        private int _employeeCount;

        public string Title { get; set; }

        public int EmployeeCount
        { 
            get => _employeeCount;
            set
            {
                if (value < 0)
                {
                    Write("Error");
                }
                _employeeCount = value;
            }
        }

        public Journal()
        {
            Title = "Nothing";
            EmployeeCount = 0;
        }
        public Journal(string title, int employee)
        {
            Title = title;
            EmployeeCount = employee;
        }

        public static Journal operator +(Journal journal, int value)
        {
            return new Journal(journal.Title, journal.EmployeeCount + value);
        }
        public static Journal operator -(Journal journal, int value)
        {
            return new Journal(journal.Title, journal.EmployeeCount - value);
        }
        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.EmployeeCount == j2.EmployeeCount;
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return !(j1.EmployeeCount == j2.EmployeeCount);
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.EmployeeCount > j2.EmployeeCount;
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.EmployeeCount < j2.EmployeeCount;
        }
        public override string ToString()
        {
            return $"title: {Title}, EmployeeCount: {EmployeeCount}";
        }
    }
}
