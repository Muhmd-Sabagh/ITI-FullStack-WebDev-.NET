namespace Early_Late_Binding
{
    class Child : Parent
    {
        int y;
        public int Y { get { return y; } set { y = value; } }
    
        public string Show()
        {
            return "I'm The Child!";
        }
        public override string Print()
        {
            return "I'm The Child!";
        }
    }
}
