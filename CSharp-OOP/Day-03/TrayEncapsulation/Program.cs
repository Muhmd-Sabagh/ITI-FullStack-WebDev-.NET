<<<<<<< HEAD
﻿#region Lab Assignments
//class Employee [id,name,salary,age] [setters&getters][print]

//1-one employee read and write

//2-array of 3 employees read and write [new array] != [new object]

//class Complex [real,img] [setters&getters][???print][add 2 complex numbers]
//3-one complex number read and write

///real img  print
///3    4    3+4i
///3    -4   3-4i
///3    1    3+i
///3    -1   3-i
///0     1    i
///0     -1   -i
///0     0    0
///0     3    3i
///0     -3   -3i
///3     0    3

//Complex c1= new Complex();

//while (true)
//{
//    Console.WriteLine("Enter real");
//    c1.SetReal(int.Parse(Console.ReadLine()));
//    Console.WriteLine("Enter img");
//    c1.SetImg(int.Parse(Console.ReadLine()));
//    Console.WriteLine(c1.Print());
//}


#endregion

namespace TryEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using of Employee Class

            //Employee emp;            // Zero Byte in Memory
            //                         //                                                 4Bytes   0Byte         4Bytes    8Bytes
            //emp = new Employee();    // Allocate emp in memory and Initialize its data (id -> 0, name -> null, age -> 0, salary -> 0.0) 16Bytes

            //// Asking the user for employee info
            //Console.Write("Enter the Employee ID: ");
            //emp.SetID(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Employee Name: ");
            //emp.SetName(Console.ReadLine());
            //Console.Write("Enter the Employee Age: ");
            //emp.SetAge(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Employee Salary: ");
            //emp.SetSalary(double.Parse(Console.ReadLine()));

            //Console.WriteLine("=============================");

            //// Display Employee Info
            //Console.WriteLine($"Employee Info:\n{emp.Print()}");

            #region Create an Array of Employees and use it

            //Employee[] employees;        // Zero Byte in Memory
            //employees = new Employee[3]; // Zero Byte in Memory

            //// Asking the user for employees info
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    //                                                                                      4Bytes   0Byte         4Bytes    8Bytes
            //    employees[i] = new Employee();  // Allocate employee in memory and Initialize its data (id -> 0, name -> null, age -> 0, salary -> 0.0) 16Bytes

            //    Console.Write($"Enter the Employee #{i + 1} ID: ");
            //    employees[i].SetID(int.Parse(Console.ReadLine()));
            //    Console.Write($"Enter the Employee #{i + 1} Name: ");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.Write($"Enter the Employee #{i + 1} Age: ");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.Write($"Enter the Employee #{i + 1} Salary: ");
            //    employees[i].SetSalary(double.Parse(Console.ReadLine()));

            //    Console.WriteLine("=============================");
            //}

            //Console.WriteLine();

            //// Display Employess Info
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"Employee #{i+1} Info:\n{employees[i].Print()}");
            //    Console.WriteLine(i < employees.Length - 1 ? "-----------------------------" : "\n");
            //}

            #endregion


            #endregion

            #region Using of Complex Class

            //Complex cmplx1 = new Complex();
            //Complex cmplx2 = new Complex();
            //Complex cmplx3 = new Complex();

            //// // Check The Print Function
            ////char ask = 'Y';
            ////while(ask == 'Y' || ask == 'y')
            ////{
            ////    Console.Write("Enter 1st Number Real Part: ");
            ////    cmplx1.SetReal(int.Parse(Console.ReadLine()));
            ////    Console.Write("Enter 1st Number Imaginary Part: ");
            ////    cmplx1.SetImag(int.Parse(Console.ReadLine()));

            ////    Console.WriteLine();
            ////    Console.WriteLine($"The Complex number you enterd is: {cmplx1.Print()}");

            ////    Console.WriteLine("----------");
            ////    Console.WriteLine("Do you want to enter another number? (Y/N)");
            ////    ask = char.Parse(Console.ReadLine());
            ////    Console.WriteLine("----------");
            ////}

            //// Ask the user for the first complex number
            //Console.Write("Enter 1st Number Real Part: ");
            //cmplx1.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter 1st Number Imaginary Part: ");
            //cmplx1.SetImag(int.Parse(Console.ReadLine()));
            //Console.WriteLine("-------------------------");

            //// Ask the user for the second complex number
            //Console.Write("Enter 2nd Number Real Part: ");
            //cmplx2.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter 2nd Number Imaginary Part: ");
            //cmplx2.SetImag(int.Parse(Console.ReadLine()));
            //Console.WriteLine("=========================");

            //// Add the two complex numbers
            //cmplx3 = cmplx1.Add(cmplx2);

            //// Display the complex numbers
            //Console.WriteLine($"({cmplx1.Print()}) + ({cmplx2.Print()}) = {cmplx3.Print()}");

            #endregion
        }
    }
=======
﻿#region Lab Assignments
//class Employee [id,name,salary,age] [setters&getters][print]

//1-one employee read and write

//2-array of 3 employees read and write [new array] != [new object]

//class Complex [real,img] [setters&getters][???print][add 2 complex numbers]
//3-one complex number read and write

///real img  print
///3    4    3+4i
///3    -4   3-4i
///3    1    3+i
///3    -1   3-i
///0     1    i
///0     -1   -i
///0     0    0
///0     3    3i
///0     -3   -3i
///3     0    3

//Complex c1= new Complex();

//while (true)
//{
//    Console.WriteLine("Enter real");
//    c1.SetReal(int.Parse(Console.ReadLine()));
//    Console.WriteLine("Enter img");
//    c1.SetImg(int.Parse(Console.ReadLine()));
//    Console.WriteLine(c1.Print());
//}


#endregion

namespace TryEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using of Employee Class

            //Employee emp;            // Zero Byte in Memory
            //                         //                                                 4Bytes   0Byte         4Bytes    8Bytes
            //emp = new Employee();    // Allocate emp in memory and Initialize its data (id -> 0, name -> null, age -> 0, salary -> 0.0) 16Bytes

            //// Asking the user for employee info
            //Console.Write("Enter the Employee ID: ");
            //emp.SetID(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Employee Name: ");
            //emp.SetName(Console.ReadLine());
            //Console.Write("Enter the Employee Age: ");
            //emp.SetAge(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Employee Salary: ");
            //emp.SetSalary(double.Parse(Console.ReadLine()));

            //Console.WriteLine("=============================");

            //// Display Employee Info
            //Console.WriteLine($"Employee Info:\n{emp.Print()}");

            #region Create an Array of Employees and use it

            //Employee[] employees;        // Zero Byte in Memory
            //employees = new Employee[3]; // Zero Byte in Memory

            //// Asking the user for employees info
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    //                                                                                      4Bytes   0Byte         4Bytes    8Bytes
            //    employees[i] = new Employee();  // Allocate employee in memory and Initialize its data (id -> 0, name -> null, age -> 0, salary -> 0.0) 16Bytes

            //    Console.Write($"Enter the Employee #{i + 1} ID: ");
            //    employees[i].SetID(int.Parse(Console.ReadLine()));
            //    Console.Write($"Enter the Employee #{i + 1} Name: ");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.Write($"Enter the Employee #{i + 1} Age: ");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.Write($"Enter the Employee #{i + 1} Salary: ");
            //    employees[i].SetSalary(double.Parse(Console.ReadLine()));

            //    Console.WriteLine("=============================");
            //}

            //Console.WriteLine();

            //// Display Employess Info
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"Employee #{i+1} Info:\n{employees[i].Print()}");
            //    Console.WriteLine(i < employees.Length - 1 ? "-----------------------------" : "\n");
            //}

            #endregion


            #endregion

            #region Using of Complex Class

            //Complex cmplx1 = new Complex();
            //Complex cmplx2 = new Complex();
            //Complex cmplx3 = new Complex();

            //// // Check The Print Function
            ////char ask = 'Y';
            ////while(ask == 'Y' || ask == 'y')
            ////{
            ////    Console.Write("Enter 1st Number Real Part: ");
            ////    cmplx1.SetReal(int.Parse(Console.ReadLine()));
            ////    Console.Write("Enter 1st Number Imaginary Part: ");
            ////    cmplx1.SetImag(int.Parse(Console.ReadLine()));

            ////    Console.WriteLine();
            ////    Console.WriteLine($"The Complex number you enterd is: {cmplx1.Print()}");

            ////    Console.WriteLine("----------");
            ////    Console.WriteLine("Do you want to enter another number? (Y/N)");
            ////    ask = char.Parse(Console.ReadLine());
            ////    Console.WriteLine("----------");
            ////}

            //// Ask the user for the first complex number
            //Console.Write("Enter 1st Number Real Part: ");
            //cmplx1.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter 1st Number Imaginary Part: ");
            //cmplx1.SetImag(int.Parse(Console.ReadLine()));
            //Console.WriteLine("-------------------------");

            //// Ask the user for the second complex number
            //Console.Write("Enter 2nd Number Real Part: ");
            //cmplx2.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter 2nd Number Imaginary Part: ");
            //cmplx2.SetImag(int.Parse(Console.ReadLine()));
            //Console.WriteLine("=========================");

            //// Add the two complex numbers
            //cmplx3 = cmplx1.Add(cmplx2);

            //// Display the complex numbers
            //Console.WriteLine($"({cmplx1.Print()}) + ({cmplx2.Print()}) = {cmplx3.Print()}");

            #endregion
        }
    }
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
}