namespace Stack_Queue_Operator
{
    class Complex
    {
        int real;
        int imag;

        public int Real { set { real = value; } get { return real; } }
        public int Imag { set { imag = value; } get { return imag; } }

        #region Constructors
        public Complex()
        {
            real = 0;
            imag = 0;
        }
        public Complex(int _real, int _imag)
        {
            real = _real;
            imag = _imag;
        }
        public Complex(int num)
        {
            real = imag = num;
        }
        #endregion

        #region Print
        public string Print()
        {
            if (imag == 0)
                return $"{real}";
            else if (real == 0)
                return imag == 1 ? "i" : imag == -1 ? "-i" : $"{imag}i";
            else
                return imag < 0 ? $"{real}{imag}i" : $"{real}+{imag}i";
        }
        #endregion

        #region Operators Functions
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real + right.Real,
                Imag = left.Imag + right.Imag
            };
        }
        public static Complex operator +(Complex left, int right)
        {
            return new Complex()
            {
                Real = left.Real + right,
                Imag = left.Imag
            };
        }
        public static Complex operator +(int left, Complex right)
        {
            return new Complex()
            {
                Real = right.Real + left,
                Imag = right.Imag
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real - right.Real,
                Imag = left.Imag - right.Imag
            };
        }
        public static Complex operator -(Complex left, int right)
        {
            return new Complex()
            {
                Real = left.Real - right,
                Imag = left.Imag
            };
        }
        public static Complex operator -(int left, Complex right)
        {
            return new Complex()
            {
                Real = right.Real - left,
                Imag = right.Imag
            };
        }
        public static Complex operator ++(Complex operand)
        {
            return new Complex()
            {
                Real = operand.Real + 1,
                Imag = operand.Imag + 1
            };
        }
        public static Complex operator --(Complex operand)
        {
            return new Complex()
            {
                Real = operand.Real - 1,
                Imag = operand.Imag - 1
            };
        }
        public static bool operator >(Complex left, Complex right)
        {
            return left.Real > right.Real && left.Imag > right.Imag;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return left.Real < right.Real && left.Imag < right.Imag;
        }
        public static explicit operator int(Complex operand)
        {
            return operand.Real;
        }
        #endregion
    }
}
