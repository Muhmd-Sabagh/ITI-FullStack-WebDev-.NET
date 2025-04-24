namespace EventHandler
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Target_Not_Reached });
                return false;
            }
            return true;
        }
        #region Override
        public override int VacationStock { get { return 0; } set { /* Do Nothing */ } }
        protected override int Age { get { return (int)(((DateTime.Now - BirthDate).Days) / 365.2425); } set { /* Do Nothing */ } }
        public override void EndOfYearOperation() { /* Do Nothing */ }
        protected override void CheckAgeForLayOff() { /* Do Nothing */ }
        protected override void CheckVacationStockForLayOff() { /* Do Nothing */ }
        public override string ToString()
        {
            return $"Sales Person #{EmployeeID}, Age: {Age}, Achieved Target: {AchievedTarget}";
        }
        #endregion
    }
    class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }

        #region Override
        public override int VacationStock { get { return 0; } set { /* Do Nothing */ } }
        protected override int Age { get { return (int)(((DateTime.Now - BirthDate).Days) / 365.2425); } set { /* Do Nothing */ } }
        public override void EndOfYearOperation() { /* Do Nothing */ }
        protected override void CheckAgeForLayOff() { /* Do Nothing */ }
        protected override void CheckVacationStockForLayOff() { /* Do Nothing */ }
        public override string ToString()
        {
            return $"Board Member #{EmployeeID}, Age: {Age}";
        }
        #endregion
    }
}
