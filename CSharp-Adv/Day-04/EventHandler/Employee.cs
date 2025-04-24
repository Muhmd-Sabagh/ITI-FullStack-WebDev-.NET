namespace EventHandler
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        DateTime _birthDate;
        int _vacationStock = 48;

        #region Properties
        public int EmployeeID { get; set; } = 0;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value >= DateTime.Now.AddYears(-18)) throw new ArgumentException("The Employee must be older than 18y!");
                _birthDate = value;
                Age = (int)(((DateTime.Now - _birthDate).Days) / 365.2425);
            }
        }
        public virtual int VacationStock
        {
            get { return _vacationStock; }
            set
            {
                _vacationStock = value;
                CheckVacationStockForLayOff();
            }
        }
        protected virtual int Age
        {
            get { return (int)(((DateTime.Now - BirthDate).Days) / 365.2425); }
            set { CheckAgeForLayOff(); }
        }
        #endregion

        #region Methods
        public bool RequestVacation(DateTime From, DateTime To)
        {
            if (From >= To)
                throw new ArgumentException("From date must be before To date!");
            if (VacationStock - (To - From).Days < 0)
                return false;
            VacationStock -= (To - From).Days;
            return true;
        }
        public virtual void EndOfYearOperation()
        {
            VacationStock = 48;
            CheckAgeForLayOff();
        }
        protected virtual void CheckVacationStockForLayOff()
        {
            if (VacationStock < 0)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Vacation_Stock_Under_0 });
        }
        protected virtual void CheckAgeForLayOff()
        {
            if (Age >= 60)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Age_Over_60 });
        }
        protected void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"Employee #{EmployeeID}, Age: {Age}, Vacation Stock: {VacationStock}";
        }
        #endregion
    }
}
