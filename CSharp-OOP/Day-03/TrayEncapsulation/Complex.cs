<<<<<<< HEAD
﻿namespace TryEncapsulation
{
    class Complex
    {
        #region Data

        int _real;
        int _imag;

        #endregion

        #region Setters

        public void SetReal(int real)
        {
            _real = real;
        }

        public void SetImag(int imag)
        {
            _imag = imag;
        }

        #endregion

        #region Getters

        public int GetReal()
        {
            return _real;
        }

        public int GetImag()
        {
            return _imag;
        }

        #endregion

        #region Functions

        public Complex Add(Complex secondNum)
        {
            Complex result = new Complex();
            result.SetReal(_real + secondNum.GetReal());
            result.SetImag(_imag + secondNum.GetImag());
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
=======
﻿namespace TryEncapsulation
{
    class Complex
    {
        #region Data

        int _real;
        int _imag;

        #endregion

        #region Setters

        public void SetReal(int real)
        {
            _real = real;
        }

        public void SetImag(int imag)
        {
            _imag = imag;
        }

        #endregion

        #region Getters

        public int GetReal()
        {
            return _real;
        }

        public int GetImag()
        {
            return _imag;
        }

        #endregion

        #region Functions

        public Complex Add(Complex secondNum)
        {
            Complex result = new Complex();
            result.SetReal(_real + secondNum.GetReal());
            result.SetImag(_imag + secondNum.GetImag());
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
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
