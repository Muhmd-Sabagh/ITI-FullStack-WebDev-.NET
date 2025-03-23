namespace Early_Late_Binding
{
    abstract class Geoshape
    {
        protected double dim1;
        protected double dim2;

        public double Dim1
        {
            get { return dim1; }
            set
            {
                if (value < 0)
                    dim1 = -value;
                else
                    dim1 = value;
            }
        }
        public double Dim2
        {
            get { return dim2; }
            set
            {
                if (value < 0)
                    dim2 = -value;
                else
                    dim2 = value;
            }
        }

        #region Constructors
        public Geoshape()
        {
            dim1 = 0.0;
            dim2 = 0.0;
            Console.WriteLine("Geoshape default Ctor!!");
        }
        public Geoshape(double _dim1, double _dim2)
        {
            if (_dim1 >= 0 && _dim2 >= 0)
            {
                dim1 = _dim1;
                dim2 = _dim2;
            }
            else
            {
                Dim1 = _dim1;
                Dim2 = _dim2;
            }
            Console.WriteLine("Geoshape 2Param Ctor!!");
        }
        public Geoshape(double _dim1)
        {
            if (_dim1 >= 0)
                dim1 = dim2 = _dim1;
            else
                Dim1 = Dim2 = _dim1;
            Console.WriteLine("Geoshape 1Param Ctor!!");
        }
        #endregion

        // With and without Open Close Principle
        abstract public double CalcArea();
        public double CArea() 
        {
            return -1;
        }
    }
}
