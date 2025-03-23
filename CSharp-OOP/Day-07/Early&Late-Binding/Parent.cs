namespace Early_Late_Binding
{
    class Parent
    {
        int x;
        public int X { get { return x; } set { x = value; } }

        public string Show()
        {
            return "I'm The Parent!";
        }
        public virtual string Print()
        {
            return "I'm The Parent!";
        }
    }
}
