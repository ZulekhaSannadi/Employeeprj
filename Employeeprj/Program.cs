using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeprj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int choice;

            do
            {
                Console.Write("\nEnter your choice: ");
                Console.WriteLine("\n1. Input employee details");
                Console.WriteLine("2. Display employee details");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = new Employee();
                        emp.InputDetails();
                        employees.Add(emp);
                        break;
                    case 2:
                        foreach (Employee e in employees)
                        {
                            e.DisplayDetails();
                        }
                        break;
                    case 3:
                        Console.Write("Enter employee name to delete: ");
                        string name = Console.ReadLine();
                        employees.RemoveAll(e => e.Name == name);
                        Console.WriteLine("successfully deleted");
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);

            Console.ReadKey();
        }
    }

}