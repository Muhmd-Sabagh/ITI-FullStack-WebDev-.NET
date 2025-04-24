namespace EventHandler
{
    class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        List<Employee> Members { get; } = new List<Employee>();

        public Club(int clubID, string clubName)
        {
            ClubID = clubID;
            ClubName = clubName;
        }
        public void AddMember(Employee E)
        {
            if (E != null)
            {
                if (!Members.Contains(E))
                {
                    Members.Add(E);
                    E.EmployeeLayOff += RemoveMember;
                }
            }
            else
                throw new ArgumentNullException("Enter Employee Info to add to the Club!");
        }
        public void RemoveMember (object? sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee && e.Cause == LayOffCause.Vacation_Stock_Under_0)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} is Removed from {ClubName} due to {e.Cause}");
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        public override string ToString()
        {
            return $"Club ID: {ClubID}, {ClubName}\nClub Members:\n{string.Join("\n", Members)}";
        }
    }
}
