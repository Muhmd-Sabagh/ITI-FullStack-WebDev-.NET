namespace CtorAndProperty
{
    class Complex
    {
        #region Data

        int _real;
        int _imag;

        #endregion

        #region Properties

        public int Real
        {
            set { _real = value; }
            get { return _real; }
        }

        public int Imag
        {
            set { this._imag = value; }
            get { return this._imag; }
        }

        #endregion

        #region Constructor

        public Complex()
        {
            _real = 0;
            _imag = 0;
        }

        public Complex(int real, int imag)
        {
            this._real = real;
            this._imag = imag;
        }

        public Complex(int num)
        {
            this._real = this._imag = num;
        }

        #endregion

        #region Functions

        public Complex Add(Complex secondNum)
        {
            Complex result = new Complex();
            result.Real = _real + secondNum.Real;
            result.Imag = _imag + secondNum.Imag;
            return result;
        }

        public string Print()
        {
            if (_imag == 0)
                return $"{_real}";
            else if (_real == 0)
                return _imag == 1 ? "i" : _imag == -1 ? "-i" : $"{_imag}i";
            else if (_imag > 0)
                return $"{_real}+{_imag}i";
            else
                return $"{_real}{_imag}i";
        }

        #endregion
    }
}
