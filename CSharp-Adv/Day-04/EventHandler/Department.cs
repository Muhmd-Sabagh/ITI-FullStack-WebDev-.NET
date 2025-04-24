namespace EventHandler
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff { get; } = new List<Employee>();

        public Department(int deptID, string deptName)
        {
            DeptID = deptID;
            DeptName = deptName;
        }
        public void AddStaff(Employee E)
        {
            if (E != null)
            {
                if (!Staff.Contains(E))
                {
                    Staff.Add(E);
                    E.EmployeeLayOff += RemoveStaff;
                }
            }
            else
                throw new ArgumentNullException("Enter Employee Info to add to the Department!");
        }
        public void RemoveStaff(object? sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee)
            {
                Staff.Remove(employee);
                if (employee is SalesPerson salesPerson)
                    Console.WriteLine($"Sales Person #{salesPerson.EmployeeID} is Removed from {DeptName} Department due to {e.Cause}");
                else if (employee is BoardMember boardMemebr)
                    Console.WriteLine($"Board Memebr #{boardMemebr.EmployeeID} is Removed from {DeptName} Department due to {e.Cause}");
                else
                    Console.WriteLine($"Employee {employee.EmployeeID} is Removed from {DeptName} Department due to {e.Cause}");
            }
            ///Employee Will be removed from the Department if Age>=60
            ///Employee will be removed from Department if Vacation Stock < 0
        }
        public override string ToString()
        {
            return $"DepID: {DeptID}, {DeptName} Department\nDepartment Staff:\n{string.Join("\n", Staff)}";
        }
    }
}
