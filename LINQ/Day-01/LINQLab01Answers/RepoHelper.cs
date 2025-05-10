namespace LINQLab01Answers
{
    public enum SortColumn
    {
        FName = 1,
        LName = 2,
        Age = 3,
        Salary = 4
    }

    public enum SortDirection
    {
        Asc = 1,
        Desc = 2
    }

    class RepoHelper
    {

        public static IEnumerable<Student> FindStudentsSorted(IEnumerable<Student> students, SortColumn column, SortDirection direction)
        {
            IEnumerable<Student> result;

            switch (column)
            {
                case SortColumn.FName:
                    result = direction == SortDirection.Asc
                        ? students.OrderBy(s => s.FName)
                        : students.OrderByDescending(s => s.FName);
                    break;

                case SortColumn.LName:
                    result = direction == SortDirection.Asc
                        ? students.OrderBy(s => s.LName)
                        : students.OrderByDescending(s => s.LName);
                    break;

                case SortColumn.Age:
                    result = direction == SortDirection.Asc
                        ? students.OrderBy(s => s.Age)
                        : students.OrderByDescending(s => s.Age);
                    break;

                case SortColumn.Salary:
                    result = direction == SortDirection.Asc
                        ? students.OrderBy(s => s.Salary)
                        : students.OrderByDescending(s => s.Salary);
                    break;

                default:
                    result = students;
                    break;
            }

            return result;
        }
    }
}
