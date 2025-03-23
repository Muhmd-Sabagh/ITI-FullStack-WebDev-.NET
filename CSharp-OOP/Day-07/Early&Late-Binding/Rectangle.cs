namespace Early_Late_Binding
{
    class Rectangle : Geoshape
    {
        public Rectangle() { Console.WriteLine("Rectangle default Ctor!!"); }
        public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2) { Console.WriteLine("Rectangle 2Param Ctor!!"); }

        // With and without Open Close Principle
        public override double CalcArea()
        {
            return dim1 * dim2;
        }
        public double CArea()
        {
            return dim1 * dim2;
        }
    }
}
