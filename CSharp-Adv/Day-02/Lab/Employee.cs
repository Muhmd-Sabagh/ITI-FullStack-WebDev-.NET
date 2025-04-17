namespace Lab
{
    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public int SecLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int id=1, int sec_level = 0, double salary=0.0, HiringDate hire_date=null, string gender="")
        {
            hire_date ??= new HiringDate();
            Id = id;
            SecLevel = sec_level;
            Salary = salary;
            HireDate = hire_date;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Employee of Id: {Id}\nSecurity Level: {SecLevel}\nSalary: {Salary}\nHiring Date: {HireDate}\nGender: {Gender}";
        }

        public int CompareTo(Employee? other)
        {
            return HireDate.CompareTo(other.HireDate);
        }
    }
}
