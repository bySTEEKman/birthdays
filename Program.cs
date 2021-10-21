using System;
using System.Collections.Generic;

namespace birthdays
{
    class Dictionary
    {
        private Dictionary<string, Employee> dict = new Dictionary<string, Employee>();
        public Dictionary<string, Employee> getDictionary()
        {
            return dict;
        }
        public void addItems(List<Employee> list)
        {
            foreach (Employee employ in list)
            {
                string key = employ.birthday.Month.ToString("");
                if (dict.ContainsKey(key){
                    dict[k]
                    }
                dict.Add(key, employ);

            }
        }
    }
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
            Dictionary names = new Dictionary();
            DateTime date = DateTime.Now;
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee("Yan Hurov", new DateTime(2000, 04, 01)));
            empList.Add(new Employee("Ivan Budko", new DateTime(2002, 05, 01)));
            empList.Add(new Employee("Ayn Rand", new DateTime(1990, 04, 20)));
            empList.Add(new Employee("Geralt Rivia", new DateTime(1995, 05, 07)));
            empList.Add(new Employee("Jameson Brody", new DateTime(2000, 06, 27)));
            empList.Add(new Employee("Dustin Poirier", new DateTime(2005, 06, 12)));
            empList.Add(new Employee("Ray Bradbury", new DateTime(1999, 04, 02)));
            empList.Add(new Employee("Oleh Baibuz", new DateTime(2000, 07, 01)));
            names.addItems(empList);
            foreach (KeyValuePair<string, Employee> value in names.getDictionary())
            {
                Console.WriteLine($"{value.Value.name}: {value.Key}");
            }
        }
    }
}
