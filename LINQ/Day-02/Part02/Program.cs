namespace Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1
            Console.WriteLine("--------------- PART01 ---------------");
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            Console.WriteLine("- Query1: Display numbers without any repeated Data and sorted -");
            var q1 = numbers.Distinct().OrderBy(n => n);
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- Query2: using Query1 result and show each number and it’s multiplication -");
            var q2 = q1.Zip(q1, (n, m) => new { Number = n, Multiplication = m * m });
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            #endregion
            #region #2
            Console.WriteLine("--------------- PART02 ---------------");
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            Console.WriteLine("- Query1: Select names with length equal 3 -");
            var q3 = from name in names
                     where name.Length == 3
                     select name;
            // var q3_1 = names.Where(n => n.Length == 3);
            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- Query2: Select names that contains 'a' letter (Capital or Small ) then sort them by length\n(Use toLower method and Contains method ) -");
            var q4 = from name in names
                     where name.ToLower().Contains('a')
                     orderby name.Length
                     select name;
            // var q4_1 = names.Where(n => n.ToLower().Contains('a')).OrderBy(n => n.Length);
            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- Query3: Display the first 2 names -");
            var q5 = names.Take(2);
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            #endregion
            #region #3
            Console.WriteLine("--------------- PART03 ---------------");
            List<Student> students = new List<Student>(){
                new Student(){
                    ID=1,
                    FirstName="Ali",
                    LastName="Mohammed",
                    subjects=new Subject[]{
                        new Subject(){ Code=22,Name="EF" },
                        new Subject(){ Code=33,Name="UML" }
                    }
                },
                new Student(){
                    ID=2,
                    FirstName="Mona",
                    LastName="Gala",
                    subjects=new Subject []{
                        new Subject(){ Code=22,Name="EF" },
                        new Subject(){ Code=34,Name="XML" },
                        new Subject(){ Code=25, Name="JS"}
                    }
                },
                new Student(){
                    ID=3,
                    FirstName="Yara",
                    LastName="Yousf",
                    subjects=new Subject[]{
                        new Subject(){ Code=22,Name="EF" },
                        new Subject(){ Code=25,Name="JS" }
                    }
                },
                new Student(){
                    ID=1,
                    FirstName="Ali",
                    LastName="Ali",
                    subjects=new Subject []{
                        new Subject (){ Code=33,Name="UML"}
                    }
                },
                };

            Console.WriteLine("- Query1: Display Full name and number of subjects for each student -");
            var q6 = students.Select(s => new
            {
                FullName = $"{s.FirstName} {s.LastName}",
                SubCount = s.subjects.Length
            });
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- Query2: Write a query which orders the elements in the list by FirstName\r" +
                "\nDescending then by LastName Ascending and result of query displays only first\r" +
                "\nnames and last names for the elements in list -");
            var q7 = students
                .OrderByDescending(s => s.FirstName)
                .ThenBy(s => s.LastName)
                .Select(s => new { FullName = $"{s.FirstName} {s.LastName}" });
            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- Query3: Display each student and student’s subject (use selectMany) -");
            var q8 = students.SelectMany(s => s.subjects, (s, subj) => new
            {
                Student = $"{s.FirstName} {s.LastName}",
                Subject = subj.Name
            });
            foreach (var item in q8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("- BONUS: Then as follow (use GroupBy Student FullName) -");
            var q9 = q8.GroupBy(g=>g.Student);
            foreach (var items in q9)
            {
                Console.WriteLine($"Student: {items.Key}");
                int i = 1;
                foreach (var item in items)
                {
                    Console.WriteLine($" - SubJect {i++}: {item.Subject}");
                }
            }
            #endregion
        }
    }
}
