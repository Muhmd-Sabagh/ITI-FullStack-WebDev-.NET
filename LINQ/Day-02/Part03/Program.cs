using System.Collections;

namespace Part03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 03
            // Data
            Book[] Books = SampleData.Books;

            // Queries
            Console.WriteLine("1- Book Title and its ISBN");
            var q1 = Books.Select(b => new { b.Title, b.Isbn });
            foreach (var b in q1)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2- First 3 Books with Price more than 25");
            var q2 = Books.Where(b => b.Price > 25).Take(3);
            foreach (var b in q2)
            {
                Console.WriteLine($"Title: {b.Title}, Price: {b.Price}");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("3- Book Title along with its Publisher Name");
            var q3 = Books.Select(b => new { b.Title, Publisher = b.Publisher.Name });
            foreach (var b in q3)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("4- Number of Books which cost more than 20");
            var q4 = Books.Count(b => b.Price > 20);
            Console.WriteLine($"Num of Books which cost more than 20 = {q4}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("5- Book (Title, Price, Subject Name) Sorted by its Subject Name Asc and by its Price Desc");
            var q5 = Books
                .OrderBy(b => b.Subject.Name)
                .ThenByDescending(b => b.Price)
                .Select(b => new
                {
                    b.Title,
                    b.Price,
                    b.Subject.Name
                });
            foreach (var b in q5)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("6- All Subjects with Books related to this Subject. (Using 2 methods)");
            Console.WriteLine("Method 1:");
            var q6 = Books.GroupBy(b => b.Subject.Name);
            foreach (var group in q6)
            {
                Console.WriteLine($"Subject: {group.Key}");
                foreach (var b in group)
                {
                    Console.WriteLine($" - {b}");
                }
            }

            Console.WriteLine("\nMethod 2:");
            var q6_1 = SampleData.Subjects.Select(sub => new
            {
                Subject = sub.Name,
                Books = Books.Where(b => b.Subject == sub)
            });
            foreach (var group in q6_1)
            {
                Console.WriteLine($"Subject: {group.Subject}");
                foreach (var b in group.Books)
                {
                    Console.WriteLine($" - {b}");
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("7- Books Grouped by Publisher & Subject");
            var q7 = Books.GroupBy(b => new { Publisher = b.Publisher.Name, Subject = b.Subject.Name });
            foreach (var group in q7)
            {
                Console.WriteLine($"Publisher: {group.Key.Publisher}, Subject: {group.Key.Subject}");
                foreach (var b in group) {
                    Console.WriteLine($" - {b}");
                }
            }
            #endregion
        }
    }
}
