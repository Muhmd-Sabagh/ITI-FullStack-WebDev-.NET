namespace EventHandler
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            throw new NotImplementedException();
        }
    }
    class BoardMember : Employee
    {
        public void Resign()
        {
            throw new NotImplementedException();
        }
    }
}
