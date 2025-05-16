using LINQD01LabClasses;
using System.Diagnostics.CodeAnalysis;

namespace Part01
{
    class EmpComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
    }
}
