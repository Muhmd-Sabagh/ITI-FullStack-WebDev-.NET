namespace EventHandler
{
    [Flags]
    enum LayOffCause
    {
        Vacation_Stock_Under_0 = 1, Age_Over_60 = 2, Target_Not_Reached = 4, Resigned = 8 
    }
    class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
