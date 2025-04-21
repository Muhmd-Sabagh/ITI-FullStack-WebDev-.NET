namespace EventHandler
{
    enum LayOffCause
    {

    }
    class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
