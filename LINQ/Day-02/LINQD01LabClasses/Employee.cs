namespace LINQD01LabClasses
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DepartmentId: {DeptId}";
        }
    }
}
