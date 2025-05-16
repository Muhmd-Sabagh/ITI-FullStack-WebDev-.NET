using LINQD01LabClasses;

namespace Part01
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Entities Data
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            #endregion
            #region 1. First 4 Employees in the List Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q1 ---------------");
            var q1 = employees.Take(4);

            foreach (var emp in q1)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 2. First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q2 ---------------");
            var q2 = employees.Where(e => e.Salary > 5000).Take(3);

            foreach (var emp in q2)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 3. Last 4 Employees in the List Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q3 ---------------");
            var q3 = employees.TakeLast(3);

            foreach (var emp in q3)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 4. Second 2 Employees in the List Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q4 ---------------");
            var q4 = employees.Skip(1).Take(2);

            foreach (var emp in q4)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 5. All Employees While Name length < 5 Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q5 ---------------");
            var q5 = employees.Where(e => e.Name.Length < 5);

            foreach (var emp in q5)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 6. Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q6 ---------------");
            var q6 = employees.Distinct(new EmpComparer());

            foreach (var emp in q6)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 7. Name and Id of All Employees Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q7 ---------------");
            var q7 = employees.Select(e => new { EmpID = e.Id, EmpName = e.Name });

            foreach (var emp in q7)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 8. Name and Id of All Employees Using Query Syntax.
            Console.WriteLine("--------------- Q8 ---------------");
            var q8 = from emp in employees select new { EmpID = emp.Id, EmpName = emp.Name };

            foreach (var emp in q8)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 9. Name and DeptName of All Employees Using Query Syntax.
            Console.WriteLine("--------------- Q9 ---------------");
            var q9 = from emp in employees
                     join dept in departments
                     on emp.DeptId equals dept.DeptId
                     select new { EmpName = emp.Name, DeptName = dept.DeptName };

            foreach (var emp in q9)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 10. Name and DeptName of All Employees Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q10 ---------------");
            var q10 = employees
                .Join(departments,
                    e => e.DeptId,
                    d => d.DeptId,
                    (emp, dept) => new { EmpName = emp.Name, DeptName = dept.DeptName }
                );

            foreach (var emp in q10)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 11. All Employees Group by DeptName Using Method Syntax [fluent syntax].
            Console.WriteLine("--------------- Q11 ---------------");
            var q11 = employees
                .Join(departments,
                    e => e.DeptId,
                    d => d.DeptId,
                    (emp, dept) => new { EmpName = emp.Name, DeptName = dept.DeptName }
                ).GroupBy(d => d.DeptName);

            foreach (var items in q11)
            {
                Console.WriteLine($"Department Name: {items.Key}");
                foreach (var emp in items)
                    Console.WriteLine(emp);
            }
            #endregion
            #region 12. All Employees Group by DeptName Using Query Syntax.
            Console.WriteLine("--------------- Q12 ---------------");
            var q12 = from e in employees
                      join d in departments on e.DeptId equals d.DeptId
                      group e by d.DeptName;

            foreach (var items in q12)
            {
                Console.WriteLine($"Department Name: {items.Key}");
                foreach (var emp in items)
                    Console.WriteLine(emp);
            }
            #endregion
            #region 13. Min Salary, Max Salary, Avg Salary.
            Console.WriteLine("--------------- Q13 ---------------");
            var minSal = employees.Min(e => e.Salary);
            var maxSal = employees.Max(e => e.Salary);
            var avgSal = employees.Average(e => e.Salary);

            Console.WriteLine($"Min Salary = {minSal}");
            Console.WriteLine($"Max Salary = {maxSal}");
            Console.WriteLine($"Avg Salary = {avgSal}");
            #endregion
            #region 14.	Employee Where Salary < Avg Salary.
            Console.WriteLine("--------------- Q14 ---------------");
            var q14 = employees.Where(e => e.Salary < employees.Average(e => e.Salary));

            foreach (var emp in q14)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region 15.	Create two lists of int and try Except, Concat, Union, Intersect.
            Console.WriteLine("--------------- Q15 ---------------");
            List<int> list1 = new() { 1, 2, 3, 4, 5 };
            List<int> list2 = new() { 4, 5, 6, 7 };

            var except = list1.Except(list2);
            var concat = list1.Concat(list2);
            var union = list1.Union(list2);
            var intersect = list1.Intersect(list2);

            foreach (var item in list1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            foreach (var item in except)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            foreach (var item in concat)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            foreach (var item in union)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            foreach (var item in intersect)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            #endregion
            #region 16. Create list of Phone Number and Names and try Zip Operator.
            Console.WriteLine("--------------- Q16 ---------------");
            var names = new List<string> { "Ali", "Sara", "Ahmed" };
            var phones = new List<string> { "123", "456", "789" };

            var namesWithPhones = names.Zip(phones, (names, phones) => $"{names} - {phones}");

            foreach (var item in namesWithPhones)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
