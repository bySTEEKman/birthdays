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
            Dictionary<int, List<Employee>> employeeData = new Dictionary<int, List<Employee>>();
            DateTime date = DateTime.Now;
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("Yan Hurov", new DateTime(2000, 11, 01)));
            employeeList.Add(new Employee("Ivan Budko", new DateTime(2002, 01, 01)));
            employeeList.Add(new Employee("Ayn Rand", new DateTime(1990, 11, 20)));
            employeeList.Add(new Employee("Geralt Rivia", new DateTime(1995, 01, 07)));
            employeeList.Add(new Employee("Jameson Brody", new DateTime(2000, 12, 27)));
            employeeList.Add(new Employee("Dustin Poirier", new DateTime(2005, 12, 12)));
            employeeList.Add(new Employee("Ray Bradbury", new DateTime(1999, 11, 02)));
            employeeList.Add(new Employee("Oleh Baibuz", new DateTime(2000, 01, 01)));
            SortDictionary(employeeData, employeeList);
            PrintBirth(employeeData, date.AddMonths(1), 2);
        }
        static public void SortDictionary(Dictionary<int, List<Employee>> data, List<Employee> value)
        {
            foreach (Employee human in value)
            {
                int month = int.Parse(human.birthday.Month.ToString());
                if (data.ContainsKey(month))
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
        static public void PrintBirth(Dictionary<int, List<Employee>> data, DateTime actualDate, int counter)
        {
            int actualMonth = int.Parse(actualDate.Month.ToString());
            int actualYear = int.Parse(actualDate.Year.ToString());
            for (int i = 0; i <= counter; i++)
            {
                string title =  actualDate.AddMonths(i).ToString("MMMM yyyy");
                Console.WriteLine($"{title}");
                foreach(Employee human in data[actualMonth])
                {
                    int howOld = actualYear - int.Parse(human.birthday.Year.ToString());
                    string polarization = howOld%10 == 1 ? "год" : (2 <= howOld%10 && howOld%10 <= 4 ? "года" : "лет");
                    int birthday = int.Parse(human.birthday.Day.ToString());
                    Console.WriteLine($"({(birthday >= 10 ? birthday : "0" + birthday)}) - {human.name} ({howOld} {polarization})");
                }
                actualMonth++;
                if(actualMonth > 12)
                {
                    actualYear++;
                    actualMonth = 1;
                }
            }
        }
    }
}
