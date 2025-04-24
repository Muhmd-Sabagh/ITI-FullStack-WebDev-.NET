namespace EventHandler
{
    #region Assignment
    // The PDF attached
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Normal Employees
                Employee emp1 = new Employee()
                {
                    EmployeeID = 1,
                    BirthDate = new DateTime(1998, 04, 15),
                    VacationStock = 20
                };
                Employee emp2 = new Employee()
                {
                    EmployeeID = 2,
                    BirthDate = new DateTime(2000, 05, 17),
                    VacationStock = 10
                };
                Employee emp3 = new Employee()
                {
                    EmployeeID = 3,
                    BirthDate = new DateTime(1970, 11, 01),
                    VacationStock = 30
                };
                #endregion
                #region Sales People
                SalesPerson sp1 = new SalesPerson()
                {
                    EmployeeID = 1,
                    BirthDate = new DateTime(1962, 02, 25),
                    AchievedTarget = 50
                };
                SalesPerson sp2 = new SalesPerson()
                {
                    EmployeeID = 2,
                    BirthDate = new DateTime(1995, 09, 27),
                    AchievedTarget = 40
                };
                #endregion
                #region Board Members
                BoardMember bm1 = new BoardMember()
                {
                    EmployeeID = 1,
                    BirthDate = new DateTime(1960, 12, 01),
                };
                BoardMember bm2 = new BoardMember()
                {
                    EmployeeID = 2,
                    BirthDate = new DateTime(1982, 07, 19),
                };
                #endregion
                #region Add Employees to Department and Club
                Department management = new Department(1, "Management");
                Department sales = new Department(2, "Sales");
                Department tech = new Department(3, "Tech");

                Club sportsClub = new Club(1, "Sports Club");

                management.AddStaff(bm1);
                management.AddStaff(bm2);
                sales.AddStaff(bm1);
                sales.AddStaff(sp1);
                sales.AddStaff(sp2);
                sales.AddStaff(emp3);
                tech.AddStaff(bm2);
                tech.AddStaff(emp1);
                tech.AddStaff(emp2);

                sportsClub.AddMember(bm1);
                sportsClub.AddMember(bm2);
                sportsClub.AddMember(sp1);
                sportsClub.AddMember(sp2);
                sportsClub.AddMember(emp1);
                sportsClub.AddMember(emp2);
                sportsClub.AddMember(emp3);

                // Test Classes
                Console.WriteLine(management);
                Console.WriteLine("-----------------------");
                Console.WriteLine(sales);
                Console.WriteLine("-----------------------");
                Console.WriteLine(tech);
                Console.WriteLine("-----------------------");
                Console.WriteLine(sportsClub);
                Console.WriteLine("-----------------------");
                #endregion
                #region Test Lay Off Event
                Console.WriteLine($"Employee #{emp2.EmployeeID} Vacation of (12 Days) Approved? {emp2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(12))}");
                Console.WriteLine($"Employee #{emp2.EmployeeID} Vacation Stock = {emp2.VacationStock}");
                Console.WriteLine("-----------------------");

                // Remove some Employees
                emp2.VacationStock = -1;                        // Will be removed
                emp3.BirthDate = DateTime.Now.AddYears(-61);    // Will be removed
                bm1.Resign();                                   // Will be removed
                sp1.VacationStock = -1;                         // Do Nothing
                sp2.CheckTarget(60);                            // Will be removed

                Console.WriteLine("-----------------------");
                // Check Count of Employees
                Console.WriteLine(management);
                Console.WriteLine("-----------------------");
                Console.WriteLine(sales);
                Console.WriteLine("-----------------------");
                Console.WriteLine(tech);
                Console.WriteLine("-----------------------");
                Console.WriteLine(sportsClub);
                Console.WriteLine("-----------------------");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
