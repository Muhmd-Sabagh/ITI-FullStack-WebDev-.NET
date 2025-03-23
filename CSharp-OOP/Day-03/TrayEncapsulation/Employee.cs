<<<<<<< HEAD
﻿namespace TryEncapsulation
{
    class Employee
    {
        #region Data

        int _id;
        string _name;
        double _salary;
        int _age;

        #endregion

        #region Setters

        public void SetID(int id)
        {
            _id = id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetSalary(double salary)
        {
            _salary = salary;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        #endregion

        #region Getters

        public int GetID()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetSalary()
        {
            return _salary;
        }

        public int GetAge()
        {
            return _age;
        }

        #endregion

        #region Printing Employee Info

        public string Print ()
        {
            return $"ID: {_id} | Name: {_name} | Age: {_age} | Salary: {_salary}";
        }

        #endregion
    }
}
=======
﻿namespace TryEncapsulation
{
    class Employee
    {
        #region Data

        int _id;
        string _name;
        double _salary;
        int _age;

        #endregion

        #region Setters

        public void SetID(int id)
        {
            _id = id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetSalary(double salary)
        {
            _salary = salary;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        #endregion

        #region Getters

        public int GetID()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetSalary()
        {
            return _salary;
        }

        public int GetAge()
        {
            return _age;
        }

        #endregion

        #region Printing Employee Info

        public string Print ()
        {
            return $"ID: {_id} | Name: {_name} | Age: {_age} | Salary: {_salary}";
        }

        #endregion
    }
}
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
