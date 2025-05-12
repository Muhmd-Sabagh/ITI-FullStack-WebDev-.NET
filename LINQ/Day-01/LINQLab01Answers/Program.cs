using System.Collections.Generic;
using System.Data.Common;

namespace LINQLab01Answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = Repository.GetStudents();

            #region 1. Display all Student using LINQ Query Expression.
            //var q1 = from student in students select student;
            //foreach (var student in q1)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 2. Display all Student using LINQ Method Syntax [fluent syntax].
            //var q2 = students.ToList();
            //foreach (var student in q2)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 3.Display all Students with Age > 30 using LINQ Query Expression.
            //var q3 = from student in students where student.Age > 30 select student;
            //foreach (var student in q3)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 4. Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
            //var q4 = students.Where(student => student.Salary < 5000);
            //foreach (var student in q4)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 5. Display all Students with TrackId =1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            //var q5 = from student in students
            //         where student.TrackId == 1 && student.Salary > 4000
            //         orderby student.FName descending
            //         select student;
            //foreach (var student in q5)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 6. Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
            //var q6 = students
            //    .Where(student => student.TrackId == 1 && student.FName.ToLower().Contains('m'))
            //    .OrderBy(student => student.Salary);

            //foreach (var student in q6)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            #endregion
            #region 7. Find First Student with Salary more than 5000. Hint: (using First and FirstOrDefault and Explain difference)
            //var q7 = students.First(student => student.Salary > 5000);  // Will throw exception if not found
            //Console.WriteLine(q7);

            //var q7 = students.FirstOrDefault(student => student.Salary > 5000);   // Will return the default value if not found
            //Console.WriteLine(q7);
            #endregion
            #region 8. Find Last Student in Track number 10. Hint: (using Last and LastOrDefault and Explain difference)
            //var q8 = students.Last(student => student.TrackId == 10);    // Will throw exception because TrackId or 10 is not exists
            //Console.WriteLine(q8);

            //var q8 = students.LastOrDefault(student => student.TrackId == 10);    // Will return null as it is the default value
            //Console.WriteLine(q8);
            #endregion
            #region 9. Find Student with Age equal 25. Hint: (using Single and SingleOrDefault and Explain difference)
            //var q9 = students.Single(student => student.Age == 25);     // Won't throw exception because there is only on age = 25
            //Console.WriteLine(q9);

            //var q9 = students.SingleOrDefault(student => student.Age == 25);    // Will return the default value if not found 
            //Console.WriteLine(q9);
            #endregion
            #region 10. Find Student with TrackId equal 8. Hint: (using Single and SingleOrDefault and Explain difference)
            //var q10 = students.Single(student => student.TrackId == 8);     // Will throw exception because TrackId or 8 is not exists
            //Console.WriteLine(q10);

            //var q10 = students.SingleOrDefault(student => student.TrackId == 8);    // Will return null as it is the default value
            //Console.WriteLine(q10);
            #endregion
            #region 11. Find Student in index 4.
            //var q11 = students.ElementAt(4);     // Will throw exception if not found
            //Console.WriteLine(q11);
            #endregion
            #region 12. Ask the user for sorting method (by Name,  Age, etc….) and sorting way (ASC. Or DESC.)…. And implement a function named FindStudentsSorted() that displays all Students sorted as the user requested.
            SortColumn column;
            SortDirection direction;
            int choice;
            do
            {
                Console.Write("Sort by:\n" +
                              "1. First Name\n" +
                              "2. Last Name\n" +
                              "3. Age\n" +
                              "4. Salary\n" +
                              "Enter your choice (1–4): ");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(SortColumn), choice));
            Console.WriteLine(typeof(SortColumn));
            column = (SortColumn)choice;

            do
            {
                Console.Write("Sort direction:\n" +
                              "1. Ascending\n" +
                              "2. Descending\n" +
                              "Enter your choice (1 or 2): ");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(SortColumn), choice));
            direction = (SortDirection)choice;

            List<Student> sortedStudents = RepoHelper.FindStudentsSorted(students, column, direction).ToList();

            //// Display
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            #endregion
        }
    }
}
