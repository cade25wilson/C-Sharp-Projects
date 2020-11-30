using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Joe", "Leonard", 0));
            list.Add(new Employee("Isaiah", "Beal", 1));
            list.Add(new Employee("Bradley", "Butler", 2));
            list.Add(new Employee("Jimmy", "Crowder", 3));
            list.Add(new Employee("Jay", "Vincent", 4));
            list.Add(new Employee("Gabe", "Robinson", 5));
            list.Add(new Employee("Duncan", "Silva", 6));
            list.Add(new Employee("Joe", "WhiteSide", 7));
            // using loop to add employee named joe to a list
            List<Employee> joe = new List<Employee>();
            foreach (Employee emp in list)
                if (emp.FirstName.Equals("Joe"))
                    joe.Add(emp);
            //getting each employee named joe adding it to list
            joe.Clear();
            list.ForEach(i => { if (i.FirstName.Equals("Joe")) joe.Add(i); });
            //Displaying Lambda function
            Console.WriteLine("The Joes List: ");
            foreach (Employee emp in joe)
                emp.SayName();

            List<Employee> fiveUpID = new List<Employee>();
            list.ForEach(i => { if (i.ID > 5) fiveUpID.Add(i); });
            //writing employees with id > 5
            Console.WriteLine("The ID greater than 5 List: ");
            foreach (Employee emp in fiveUpID)
                emp.SayName();

            Console.ReadLine();
        }
    }
}
