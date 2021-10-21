using System;
using System.Collections.Generic;

namespace birthdays
{
    class Employee
    {
        public string name;
        public DateTime birthday;
        public Employee(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> employeeData = new Dictionary<string, List<Employee>>();
            DateTime date = DateTime.Now;
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("Yan Hurov", new DateTime(2000, 04, 01)));
            employeeList.Add(new Employee("Ivan Budko", new DateTime(2002, 05, 01)));
            employeeList.Add(new Employee("Ayn Rand", new DateTime(1990, 04, 20)));
            employeeList.Add(new Employee("Geralt Rivia", new DateTime(1995, 05, 07)));
            employeeList.Add(new Employee("Jameson Brody", new DateTime(2000, 06, 27)));
            employeeList.Add(new Employee("Dustin Poirier", new DateTime(2005, 06, 12)));
            employeeList.Add(new Employee("Ray Bradbury", new DateTime(1999, 04, 02)));
            employeeList.Add(new Employee("Oleh Baibuz", new DateTime(2000, 07, 01)));
            SortDictionary(employeeData, employeeList);
        }
        static public void SortDictionary(Dictionary<string, List<Employee>> data, List<Employee> value)
        {
            foreach(Employee human in value)
            {
                string month = human.birthday.Month.ToString();
                if(data.ContainsKey(month))
                {
                    data[month].Add(human);
                }
                else
                {
                    List<Employee> employeeList = new List<Employee>();
                    employeeList.Add(new Employee(human.name, human.birthday));
                    data.Add(month, employeeList);
                }
            }
        }
    }
}
