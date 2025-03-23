namespace Early_Late_Binding
{
    class SubChild : Child
    {
        int z;
        public int Z { get { return z; } set { z = value; } }

        public string Show()
        {
            return "I'm The SubChild!";
        }
        public override string Print()
        {
            return "I'm The SubChild!";
        }
    }
}
