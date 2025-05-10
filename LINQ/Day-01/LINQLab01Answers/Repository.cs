namespace LINQLab01Answers
{
    class Repository
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {Id = 1, FName = "Muhammad", LName = "Abdullah", Age = 26, Salary = 4000, TrackId = 2},
                new Student {Id = 2, FName = "Ahmed", LName = "Amr", Age = 24, Salary = 5000, TrackId = 5},
                new Student {Id = 3, FName = "Mustafa", LName = "Reda", Age = 24, Salary = 3000, TrackId = 1},
                new Student {Id = 4, FName = "Yousra", LName = "Ehab", Age = 23, Salary = 4500, TrackId = 2},
                new Student {Id = 5, FName = "Hazem", LName = "Ahmed", Age = 24, Salary = 3500, TrackId = 3},
                new Student {Id = 6, FName = "Rowayda", LName = "Ehab", Age = 22, Salary = 5000, TrackId = 4},
                new Student {Id = 7, FName = "Somaya", LName = "Yasser", Age = 22, Salary = 5500, TrackId = 2},
                new Student {Id = 8, FName = "Amr", LName = "Ehab", Age = 20, Salary = 3000, TrackId = 1},
                new Student {Id = 9, FName = "Eslam", LName = "Muhammad", Age = 25, Salary = 6000, TrackId = 4},
                new Student {Id = 10, FName = "Nehal",  LName = "Khaled", Age = 21, Salary = 4000, TrackId = 3}
            };
        }

        public static List<Track> GetTracks()
        {
            return new List<Track>
            {
                new Track {TrackId = 1, TrackName = ".NET"},
                new Track {TrackId = 2, TrackName = "MEARN"},
                new Track {TrackId = 3, TrackName = "Python"},
                new Track {TrackId = 4, TrackName = "JAVA"},
                new Track {TrackId = 5, TrackName = "PHP"},
            };
        }
    }
}
