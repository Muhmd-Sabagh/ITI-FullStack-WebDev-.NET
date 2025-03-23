namespace Early_Late_Binding
{
    class Circle : Geoshape
    {
        public Circle() { Console.WriteLine("Circle default Ctor!!"); }
        public Circle(double radius) : base(radius){ Console.WriteLine("Circle 1Param Ctor!!"); }

        // With and without Open Close Principle
        public override double CalcArea()
        {
            return Math.PI * dim1 * dim1;
        }
        public double CArea()
        {
            return Math.PI * dim1 * dim1;
        }
    }
}
