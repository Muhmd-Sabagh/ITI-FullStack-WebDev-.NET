using System.Collections.Immutable;

namespace Lab
{
    #region Assignment
    /*
        1.	Try all what we have learned in the lecture
        2.	Design and implement a class for the employees in a company
        3.	Employee is identified by an ID, security level, salary, hire date and Gender.
        4.	Develop a Class to represent the HiringDate Data Type consisting of fields to hold the day, month and Years.
        5.	We want to provide the Employee class with the standard capabilities to represent Employee data in a string Form(override ToString ())
        6.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions, (Employee[] EmpArr;)
        7.	Implement All the Necessary Member Functions on the Class
        8.	Define all the Necessary Constructors for the Class
        9.	Allow NO RUNTIME errors if the user inputs any data(using try parse)
        10.	Sort the employees based on their hire date
        11.	Print the sorted array.
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee DBA = new Employee(1, 3, 5000, new HiringDate(1, 5, 2021), "male");
            Employee guest = new Employee(id: 2, sec_level: 1, gender: "female");
            Employee sec_officer = new Employee(3, 5, 8000, new HiringDate(13, 5, 2021), "male");
            Employee[] emps =
            {
                DBA, guest, sec_officer
            };

            Employee emp = new Employee();

            int id, sec_level, day, month, year;
            double salary;
            string gender;

            Console.WriteLine("Enter Employee Data: ");
            do
            {
                Console.Write("ID: ");
            } while (!int.TryParse(Console.ReadLine(), out id));
            do
            {
                Console.Write("Security Level (0-5): ");
            } while (!int.TryParse(Console.ReadLine(), out sec_level) || (sec_level > 5 || sec_level < 0));
            do
            {
                Console.Write("Salary: ");
            } while (!double.TryParse(Console.ReadLine(), out salary));
            Console.Write("Hiring Date: ");
            do
            {
                Console.Write("Day (1 - 31): ");
            } while (!int.TryParse(Console.ReadLine(), out day) || (day > 31 || day < 1));
            do
            {
                Console.Write("Month (1 - 12): ");
            } while (!int.TryParse(Console.ReadLine(), out month) || (month > 12 || month < 1));
            do
            {
                Console.Write("Year (1990 - 2025): ");
            } while (!int.TryParse(Console.ReadLine(), out year) || (year > 2025 || year < 1990));
            do
            {
                Console.Write("Gender (male or female): ");
                gender = Console.ReadLine();
            } while (gender != "male" && gender != "female");

            emp.Id = id;
            emp.SecLevel = sec_level;
            emp.Salary = salary;
            emp.HireDate = new HiringDate(day, month, year);
            emp.Gender = gender;

            Console.WriteLine("-----------------------");
            Console.WriteLine(emp);
            Console.WriteLine("-----------------------");

            // Sorting the array
            Array.Sort(emps);

            foreach (Employee employee in emps)
            {
                Console.WriteLine(employee);
                Console.WriteLine("-----------------------");
            }
        }
    }
}
