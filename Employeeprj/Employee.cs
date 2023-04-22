using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeprj
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Design{ get; set; }
       public string Department { get; set; }
        public double Salary { get; set; }


        public void InputDetails()
        {
            Console.Write("Enter employee ID: ");
            Id= Console.ReadLine();

            Console.Write("Enter employee name: ");
            Name = Console.ReadLine();

            Console.Write("Enter employee Designation: ");
            Design = Console.ReadLine();

            Console.Write("Enter employee department: ");
            Department = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            Salary = double.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Design );
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

        }
    }
}

